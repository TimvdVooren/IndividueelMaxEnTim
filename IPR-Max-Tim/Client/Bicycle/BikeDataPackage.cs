using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Bicycle
{
    class BikeDataPackage
    {
        public string time;
        public string power;
        public string rpm;
        public string distance;
        public string energy;
        public string heartrate;

        public BikeDataPackage(string time, string power, string rpm, string distance, string energy, string heartrate)
        {
            this.time = time;
            this.power = power;
            this.rpm = rpm;
            this.distance = Convert.ToString(Convert.ToDouble(distance) / 20);
            this.energy = Convert.ToString(Convert.ToDouble(energy) / 10);
            this.heartrate = heartrate;
        }

        public override string ToString()
        {
            return $"{time} seconds | {power} % | {rpm} rpm | {distance} km | {energy} J/s | {heartrate} bpm";
        }
    }
}
