using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class StretchingRoutine : Routine
    {
        public byte TotalSets { get; set; }
        public byte TotalExercises { get; set; }

        public StretchingRoutine() : base()
        {
            TotalSets = 0;
            TotalExercises = 0;
        }

        public StretchingRoutine(string name, DateTime start, DateTime finish) : base(name, start, finish)
        {
            TotalSets = 0;
            TotalExercises = 0;
        }

        public override void UpdateRoutine()
        {
            base.UpdateRoutine();
            TotalSets = 0;
            TotalExercises = 0;

            foreach (StretchingSession session in SessionsList)
            {
                session.UpdateSession();
                TotalExercises += session.TotalExercises;
                TotalSets += session.TotalSets;
            }
        }
    }
}

