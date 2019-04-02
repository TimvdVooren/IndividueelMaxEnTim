﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPR.Client
{
    class BikeDataPackage
    {
        public int Power { get; set; }
        public int Rpm { get; set; }
        public string Time { get; set; }
        public int Distance { get; set; }
        public int Energy { get; set; }
        public int HeartRate { get; set; }

        public BikeDataPackage (string bikeDataString)
        {
            string[] values = bikeDataString.Split('\t');

            this.HeartRate = int.Parse(values[0]);
            this.Rpm = int.Parse(values[1]);
            this.Distance = int.Parse(values[3]);
            this.Power = int.Parse(values[4]);
            this.Energy = int.Parse(values[5]);

            string[] timeComponents = values[6].Split(':');
            int minutes = int.Parse(timeComponents[0]);
            int seconds = int.Parse(timeComponents[1]);
            this.Time = string.Format("{0}:{1}", minutes, seconds);
        }

        public override string ToString()
        {
            return "" +
               "Power: " + Power +
               "\nRpm: " + Rpm +
               "\nTime: " + Time +
               "\nDistance: " + Distance +
               "\nEnergy: " + Energy +
               "\nHeartrate: " + HeartRate;
        }
    }
}
