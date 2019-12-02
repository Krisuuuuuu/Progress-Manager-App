using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class StretchingExercise : Exercise
    {
        public byte Sets { get; set; }

        public DateTime Rest { get; set; }

        public StretchingExercise() : base()
        {
            this.Sets = 0;
            this.Rest = new DateTime(0, 0, 0, 0, 1, 30);
        }

        public StretchingExercise(string name, ExerciseTypes exerciseType, byte sets, DateTime rest) : base(name, exerciseType)
        {
            this.Sets = sets;
            this.Rest = rest;
        }
    }
}
