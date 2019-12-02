using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    public class WorkOutRoutine : Routine
    {
        public byte TotalSets { get; set; }
        public byte TotalExercises { get; set; }

        public WorkOutRoutine() : base()
        {
            TotalSets = 0;
            TotalExercises = 0;
        }

        public WorkOutRoutine(string name, DateTime start, DateTime finish):base(name, start, finish)
        {
            TotalSets = 0;
            TotalExercises = 0;
        }

        public override void UpdateRoutine()
        {
            base.UpdateRoutine();
            TotalSets = 0;
            TotalExercises = 0;

            foreach(WorkOutSession workOutSession in SessionsList)
            {
                workOutSession.UpdateSession();
                TotalExercises += workOutSession.TotalExercises;
                TotalSets += workOutSession.TotalSets;
            }
        }
    }
}
