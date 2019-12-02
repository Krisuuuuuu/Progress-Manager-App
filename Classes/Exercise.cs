using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public ExerciseTypes ExerciseType { get; set; }

        public Exercise()
        {
            ExerciseName = "";
            ExerciseType = ExerciseTypes.NOT_DEFINED;
        }

        public Exercise(string exerciseName, ExerciseTypes exerciseType)
        {
            ExerciseName = exerciseName;
            ExerciseType = exerciseType;
        }
    }
}
