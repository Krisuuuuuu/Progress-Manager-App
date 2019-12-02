using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class CardioExercise : Exercise
    {
        public DateTime Duration { get; set; }
        public byte Sets { get; set; }

        public DateTime Rest { get; set; }

        public CardioExercise() : base()
        {
            this.Sets = 0;
            this.Rest = new DateTime(0, 0, 0, 0, 1, 30);
            this.Duration = new DateTime(0, 0, 0, 0, 30, 0);
        }

        public CardioExercise(string name, ExerciseTypes exerciseType, DateTime duration, byte sets, DateTime rest) 
            : base(name, exerciseType)
        {
            this.Sets = sets;
            this.Rest = rest;
            this.Duration = duration;
        }
    }
}
