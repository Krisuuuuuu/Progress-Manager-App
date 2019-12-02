using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class CardioRoutine : Routine
    {
        public byte TotalSets { get; set; }

        public CardioRoutine() : base()
        {
            TotalSets = 0;
        }

        public CardioRoutine(string name, DateTime start, DateTime finish) : base(name, start, finish)
        {
            TotalSets = 0;
        }

        public override void UpdateRoutine()
        {
            base.UpdateRoutine();
            TotalSets = 0;

            foreach (CardioSession cardioSession in SessionsList)
            {
                cardioSession.UpdateSession();
                TotalSets += cardioSession.TotalSets;
            }
        }

    }
}
