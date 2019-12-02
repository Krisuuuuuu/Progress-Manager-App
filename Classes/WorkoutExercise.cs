using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    public class WorkOutExercise : Exercise
    {
        public BodyPart BodyPart { get; set; }
        public byte InitialReps { get; set; }
        public byte FinalReps { get; set; }

        public byte Sets { get; set; }

        public DateTime Rest { get; set; }

        public WorkOutExercise() : base()
        {
            BodyPart = BodyPart.NOT_DEFINED;
            InitialReps = 0;
            FinalReps = 0;
            Sets = 0;
            Rest = new DateTime(0, 0, 0, 0, 1, 30);
        }

       
        public WorkOutExercise(string name, ExerciseTypes exerciseType, BodyPart bodyPart, byte ireps, byte freps,
            byte sets, DateTime dateTime):base(name, ExerciseTypes.WORKOUT_EXERCISE)
        {

            this.BodyPart = bodyPart;
            this.InitialReps = ireps;
            this.FinalReps = freps;
            this.Sets = sets;
            this.Rest = dateTime;

        }
    }
}
