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

        public static void AddRoutine(Routine myRoutine)
        {

            if (!Directory.Exists(mainDirectoryPath))
                Directory.CreateDirectory(mainDirectoryPath);

           if(myRoutine is WorkOutRoutine)
            {
                routineDirectoryPath += @"\WorkOutRoutines";
                routineFilePath = routineDirectoryPath + @"\" + myRoutine.RoutineName;

                if (!Directory.Exists(routineDirectoryPath))
                    Directory.Exists(routineDirectoryPath);

                if(!File.Exists(routineFilePath))
                {
                    MessageBox.Show("Routine (" + myRoutine.RoutineName + ") has been added before.");
                    return;
                }

                SerializeRoutine(myRoutine);

            }

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

            using(Stream input = File.OpenRead(routinePath))
            {
                workOutRoutineFromTheFile = (WorkOutRoutine)binaryFormatter.Deserialize(input);
                Console.WriteLine("Workout Routine (" + workOutRoutineFromTheFile.RoutineName + ") was deserialized succesfully.");
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
                Console.WriteLine("Workout Routine (" + stretchingRoutineFromTheFile.RoutineName + ") was deserialized succesfully.");
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
                Console.WriteLine("Workout Routine (" + cardioRoutineFromTheFile.RoutineName + ") was deserialized succesfully.");
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
