using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPR.Client
{
    class Patient
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Gewicht { get; set; }

        public Patient(int Age, string Sex, int Gewicht)
        {
            this.Age = Age;
            this.Sex = Sex;
            this.Gewicht = Gewicht;
        }
    }
}
