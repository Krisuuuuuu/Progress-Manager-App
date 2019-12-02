using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    static class Calculators
    {
        public static double BMICalculator(double height, double weight)
        {
            height = height / 100;
            double BMI = weight/(height*height);
            return BMI;
        }

        public static ushort OneRepMaxCalculator(ushort testWeight, string onrBodyPart)
        {
            double oneRepMax;

            if(onrBodyPart==OnrBodyParts.LOWER.ToString())
            {
                oneRepMax = (testWeight * 1.09703) + 14.2546;
                return (ushort)oneRepMax;
            }
            else
            {
                oneRepMax = (testWeight * 1.1307) + 0.6998;
                return (ushort)oneRepMax;
            }
        }

        public static ushort CPMCalculator(ushort height, double weight, byte age, string sex, double activity, bool reduction)
        {
            double bmr;

            if(sex == Sex.FEMALE.ToString())
            {
                bmr = (9.99 * weight) + (6.25 * height) - (4.92 * age) - 161;
            }
            else
            {
                bmr = (9.99 * weight) + (6.25 * height) - (4.92 * age) + 5;
            }

            double CPM = bmr * activity;

            if(reduction==true)
            {
                CPM -= 200;
            }
            else
            {
                CPM += 200;
            }

            return (ushort)CPM;
        }

    }
}
