using Progress_Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ushort Height { get; set; }

        public double Weight { get; set; }

        public BodyTypes BodyType { get; set; }

        public Person()
        {
            Name = "Name";
            Surname = "Surname";
            DateOfBirth = DateTime.Today;
            Height = 1;
            Weight = 1;
            BodyType = BodyTypes.ECTOMORPH;
        }

        public Person(string name, string surname, DateTime dateOfBirth, ushort height, double weight, BodyTypes bodyType)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.Height = height;
            this.Weight = weight;
            this.BodyType = bodyType;
        }
        
    }
}
