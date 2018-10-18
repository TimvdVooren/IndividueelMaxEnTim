using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPR.Client
{
    class PointOfTime
    {
        public DateTime time;
        public int power;
        public double distance;
        public int energy;
        public double speed;
        public int bikeTime;

        public PointOfTime(int power, double distance, int energy, double speed, int bikeTime)
        {
            this.time = DateTime.Now;
            this.power = power;
            this.distance = distance;
            this.energy = energy;
            this.speed = speed;
            this.bikeTime = bikeTime;
        }

        public override string ToString()
        {
            return $"Time of recording: {time}\r\nPower: {power}\r\nDistance: {distance}\r\nEnergy: {energy}\r\nSpeed: {speed}\r\nRemaining bike time: {bikeTime}\r\n";
        }
    }
}
