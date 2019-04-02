using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public double Vo2 { get; set; }

        public Patient(string Name, int Age, string Gender, int Weight)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Weight = Weight;
            Vo2 = 0;
        }

        public override string ToString()
        {
            string patientString = $"{Name}, {Age} years old, {Gender}, {Weight} Kg\r\n\r\n";
            //patientString = patientString + AstrandTest.ToString();
            return patientString;
        }
    }
}
