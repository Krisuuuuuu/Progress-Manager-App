using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Progress_Manager.Classes
{
    static class UserManager
    {
        
        private static string mainDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Progress Manager";
        private static string userDirectoryPath = mainDirectoryPath + @"\Users";
        private static string currentUserDirectoryPath = userDirectoryPath + @"\";
        private static string userFilePath = currentUserDirectoryPath + @"\";
        private static string profileFilePath = currentUserDirectoryPath + @"\profile_";
        public static string WhoIsCurrentLoged { get; set; }
        
        public static void ResetPaths()
        {
            mainDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Progress Manager";
            userDirectoryPath = mainDirectoryPath + @"\Users";
            currentUserDirectoryPath = userDirectoryPath + @"\";
            userFilePath = currentUserDirectoryPath + @"\";
            profileFilePath = currentUserDirectoryPath + @"\profile_";
        }

        public static void CreateDirectories()
        {
            if (!Directory.Exists(mainDirectoryPath))
                Directory.CreateDirectory(mainDirectoryPath);

            if (!Directory.Exists(userDirectoryPath))
                Directory.CreateDirectory(userDirectoryPath);

        }
        public static bool IsUserExist(string login)
        {
            currentUserDirectoryPath += login + @"\";

            if (!Directory.Exists(mainDirectoryPath))
                Directory.CreateDirectory(mainDirectoryPath);

            if (!Directory.Exists(userDirectoryPath))
                Directory.CreateDirectory(userDirectoryPath);


            if (Directory.Exists(currentUserDirectoryPath))
            {
                currentUserDirectoryPath = userDirectoryPath + @"\";
                return true;
            }
            else
            {
                currentUserDirectoryPath = userDirectoryPath + @"\";
                return false;
            }
            
        }

        public static void SaveProfile(Person myPerson)
        {
            currentUserDirectoryPath += WhoIsCurrentLoged + @"\";
            profileFilePath = currentUserDirectoryPath + @"\profile_" + WhoIsCurrentLoged;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream output = File.OpenWrite(profileFilePath))
            {
                binaryFormatter.Serialize(output, myPerson);
            }
            ResetPaths();
        }

        public static void SaveProfile(Person myPerson, string userLogin)
        {
            currentUserDirectoryPath += userLogin + @"\";
            profileFilePath = currentUserDirectoryPath + @"\profile_" + userLogin;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream output = File.OpenWrite(profileFilePath))
            {
                binaryFormatter.Serialize(output, myPerson);
            }
            ResetPaths();
        }

        public static Person LoadProfile()
        {
            currentUserDirectoryPath += WhoIsCurrentLoged + @"\";
            profileFilePath = currentUserDirectoryPath + @"\profile_" + WhoIsCurrentLoged;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream input = File.OpenRead(profileFilePath))
            {
                Person personFromTheFile = (Person)binaryFormatter.Deserialize(input);
                ResetPaths();
                return personFromTheFile;
            }
        }
        public static void SaveUser(User myUser)
        {
            currentUserDirectoryPath += myUser.Login + @"\";
            userFilePath = currentUserDirectoryPath + myUser.Login;

            if (!Directory.Exists(currentUserDirectoryPath))
                Directory.CreateDirectory(currentUserDirectoryPath);

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream output = File.OpenWrite(userFilePath))
            {
                binaryFormatter.Serialize(output, myUser);
            }

            ResetPaths();
        }

        public static User LoadUser(string userLogin)
        {
            currentUserDirectoryPath += userLogin + @"\";
            userFilePath = currentUserDirectoryPath + userLogin;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            
            using(Stream input = File.OpenRead(userFilePath))
            {
                User UserFromTheFile = (User)binaryFormatter.Deserialize(input);
                ResetPaths();
                return UserFromTheFile;
            }
                
        }


    }
}
