using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPR.Client
{
    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Gewicht { get; set; }

        public Patient(string Name, int Age, string Gender, int Gewicht)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Gewicht = Gewicht;
        }
    }
}
