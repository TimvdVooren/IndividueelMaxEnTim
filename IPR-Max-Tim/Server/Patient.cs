using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Patient
    {
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Weight { get; set; }

        public Patient(int Age, string Sex, int Weight)
        {
            this.Age = Age;
            this.Sex = Sex;
            this.Weight = Weight;
        }
    }
}
