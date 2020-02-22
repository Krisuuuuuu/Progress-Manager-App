using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Manager.Classes
{
    static class RoutineManager
    {
        static public WorkOutRoutine MainWorkOutRoutine {get;set;}
        static public StretchingRoutine MainStretchingRoutine { get; set; }
        static public CardioRoutine MainCardioRoutine { get; set; }

        private static string mainDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Progress Manager\Users";
        public static string routineDirectoryPath = mainDirectoryPath + @"\" + UserManager.WhoIsCurrentLoged + @"\Routines";
        public static string routineFilePath = routineDirectoryPath + @"\";

        public static void ResetPaths()
        {
            mainDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Progress Manager\Users";
            routineDirectoryPath = mainDirectoryPath + @"\" + UserManager.WhoIsCurrentLoged + @"\Routines";
            routineFilePath = routineDirectoryPath + @"\";
        }

        public static void CheckPaths()
        {
            ResetPaths();

            if (!Directory.Exists(mainDirectoryPath))
                Directory.CreateDirectory(mainDirectoryPath);

            if (!Directory.Exists(routineDirectoryPath))
                Directory.CreateDirectory(routineDirectoryPath);
        }

        public static void SerializeRoutine(Routine myRoutine)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream output = File.OpenWrite(routineFilePath))
            {
                binaryFormatter.Serialize(output, myRoutine);
            }

            MessageBox.Show("Routine (" + myRoutine.RoutineName + ") has been saved successfully.");
            ResetPaths();
        }

        public static WorkOutRoutine LoadWorkOutRoutine(string routinePath)
        {
            WorkOutRoutine workOutRoutineFromTheFile;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream input = File.OpenRead(routinePath))
            {
                workOutRoutineFromTheFile = (WorkOutRoutine)binaryFormatter.Deserialize(input);
            }

            return workOutRoutineFromTheFile;
        }

        public static StretchingRoutine LoadStretchingtRoutine(string routinePath)
        {
            StretchingRoutine stretchingRoutineFromTheFile;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream input = File.OpenRead(routinePath))
            {
                stretchingRoutineFromTheFile = (StretchingRoutine)binaryFormatter.Deserialize(input);
            }

            return stretchingRoutineFromTheFile;
        }

        public static CardioRoutine LoadCardioRoutine(string routinePath)
        {
            CardioRoutine cardioRoutineFromTheFile;

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream input = File.OpenRead(routinePath))
            {
                cardioRoutineFromTheFile = (CardioRoutine)binaryFormatter.Deserialize(input);
            }

            return cardioRoutineFromTheFile;
        }

        public static void DeleteRoutine()
        {
            if(File.Exists(routineFilePath))
            {
                File.Delete(routineFilePath);
            }
            MessageBox.Show("Routine has been deleted successfully.");
            ResetPaths();
        }
        
    }
}
