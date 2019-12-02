using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    public class WorkOutSession : OneDaySession
    {
        public byte TotalSets { get; set; }


        public WorkOutSession() : base()
        {
            TotalSets = 0;
        }

        public WorkOutSession(string name, Enums.DaysOfWeek dayOfWeek) 
            : base(name, dayOfWeek)
        {
            TotalSets = 0;
        }

        public override void UpdateSession()
        {
            base.UpdateSession();
            TotalSets = 0;

            foreach(WorkOutExercise exercise in ExercisesList)
            {
                TotalSets += exercise.Sets;
            }
        }

    }
}
