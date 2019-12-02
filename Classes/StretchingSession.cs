using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class StretchingSession : OneDaySession
    {
        public byte TotalSets { get; set; }

        public StretchingSession():base()
        {
            TotalSets = 0;
        }

        public StretchingSession(string name, Enums.DaysOfWeek dayOfWeek)
            : base(name, dayOfWeek)
        {
            TotalSets = 0;
        }

        public override void UpdateSession()
        {
            base.UpdateSession();
            TotalSets = 0;
            foreach (StretchingExercise exercise in ExercisesList)
            {
                TotalSets += exercise.Sets;
            }
        }
    }
}
