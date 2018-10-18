using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
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
            time = DateTime.Now;
            this.power = power;
            this.distance = distance;
            this.energy = energy;
            this.speed = speed;
            this.bikeTime = bikeTime;
        }
    }
}
