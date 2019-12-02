using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Enums;

namespace Progress_Manager.Classes
{
    [Serializable]
    public class OneDaySession
    {
        public string SessionName { get; set; }
        public DaysOfWeek Day { get; set; }

        public List<Exercise> ExercisesList = new List<Exercise>();

        public bool IsEmpty { get; set; }

        public byte TotalExercises { get; set; }


        public OneDaySession()
        {
            SessionName = "";
            Day = DaysOfWeek.NOT_DEFINED;
            IsEmpty = true;
            TotalExercises = 0;
        }

        public OneDaySession(string name, DaysOfWeek day)
        {
            this.SessionName = name;
            this.Day = day;
            IsEmpty = true;
            TotalExercises = 0;
        }

        public virtual void UpdateSession()
        {
            TotalExercises = (byte)ExercisesList.Count();

            if (TotalExercises == 0)
                IsEmpty = true;
            else
                IsEmpty = false;

        }

        public void Add(Exercise myExercise)
        {
            bool isIn = false;

            foreach(Exercise exercise in ExercisesList)
            {
                if (exercise.ExerciseName == myExercise.ExerciseName)
                    isIn = true;
            }
            if (isIn == true)
            {
                MessageBox.Show("This exercise (" + myExercise.ExerciseName + ") has been added before.");
                return;
            }
            else
            {
                ExercisesList.Add(myExercise);
                UpdateSession();
            }
        }

        public void Delete(Exercise myExercise)
        {
            if(IsEmpty==true)
            {
                MessageBox.Show("Exercise list is empty!");
                return;
                
            }
            else
            {
                bool isIn = ExercisesList.Contains(myExercise);

                if (isIn == true)
                {
                    int index = ExercisesList.IndexOf(myExercise);
                    ExercisesList.RemoveAt(index);
                    UpdateSession();
                }
                else
                {
                    MessageBox.Show("This exercise (" + myExercise.ExerciseName + ") does not exist on the exercise list.");
                    return;
                }
            }
           
            
        }
    }
}
