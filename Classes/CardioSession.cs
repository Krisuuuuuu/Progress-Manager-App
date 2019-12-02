using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class CardioSession : OneDaySession
    {
        public byte TotalSets { get; set; }
        public CardioSession() : base()
        {
            TotalSets = 0;
        }

        public CardioSession(string name, Enums.DaysOfWeek dayOfWeek)
            : base(name, dayOfWeek)
        {
            TotalSets = 0;
        }

        public override void UpdateSession()
        {
            base.UpdateSession();
            TotalSets = 0;

            foreach (CardioExercise exercise in ExercisesList)
            {
                TotalSets += exercise.Sets;
            }

        }

    }
}

