using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json.Bson;

namespace Client.Bicycle
{
    class SimulatedBike : IBike
    {
        //public SimulatedBikeForm bikeForm { get; set; }
        private System.Timers.Timer simulatorTimer;
        private BikeDataPackage currentBdp;
        private BikeDataPackage oldBdp;
        private int seconds = 0;
        private int heartrate { get; set; } = 70;
        private int rpm { get; set; } = 50;
        private int power { get; set; } = 25;

        public SimulatedBike()
        {
            Thread simulatorThread = new Thread(StartSimulator);
            simulatorThread.Start();
        }

        private void StartSimulator()
        {
            simulatorTimer = new System.Timers.Timer(1000);
            simulatorTimer.AutoReset = true;
            simulatorTimer.Elapsed += Timer_Elapsed;
            simulatorTimer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //int heartrate = heartrate;
            //int rpm = rpm;
            //int power = power;
            int[] currentValues = { heartrate, rpm, 0, power, 0, seconds };
            currentBdp = new BikeDataPackage(currentValues);
            if (seconds < 360)
            {
                seconds++;
                adeptPower();
                adeptRPM();
                adeptHearthbeat();
            }

            if (seconds >=360 && seconds < 420)
            {
                seconds++;
                AdaptCooldownRPM();
                AdaptCooldownHeartBeat();
                AdaptCooldownPower();
            }
           
        }

        public void adeptPower()
        {
            if (currentBdp.Minutes >= 2 && currentBdp.Minutes < 6)
            {
                if (currentBdp.HeartRate < 130)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 2);
                    PutPower(power + increment);
                }
                else if (currentBdp.Rpm < 65)
                {
                    PutPower(power - 2);
                }

                if (currentBdp.Rpm > 65)
                {
                    PutPower(power + 2);
                }
            } else if (currentBdp.Minutes >= 0)
            {
                if (currentBdp.HeartRate < 100)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 2);
                    PutPower(power + increment);
                }
                else if (currentBdp.Rpm < 55)
                {
                    PutPower(power - 2);
                }

                if (currentBdp.Rpm > 55)
                {
                    PutPower(power + 2);
                }
            }  
        }

        public void adeptRPM()
        {
            if (currentBdp.Minutes >= 2)
            {
                if (currentBdp.HeartRate <= 130 || currentBdp.Power < 70)
                {
                    Random random = new Random();
                    int increment = random.Next(0,2);
                    PutRPM(rpm + increment);
                }
                else if (currentBdp.HeartRate > 135 || currentBdp.Power > 70 && currentBdp.Rpm > 65)
                {
                    PutRPM(rpm - 1);
                }
            } else if (currentBdp.Minutes >= 0)
            {
                if (currentBdp.HeartRate <= 100 || currentBdp.Power < 45)
                {
                    Random random = new Random();
                    int increment = random.Next(0, 2);
                    PutRPM(rpm + increment);
                }
                else if (currentBdp.HeartRate > 105 || currentBdp.Power > 45 && currentBdp.Rpm > 55)
                {
                    PutRPM(rpm - 1);
                }
            } 
        }

        public void adeptHearthbeat()
        {
            if (currentBdp.Minutes >= 2)
            {
                if (currentBdp.Rpm < 70)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 4);
                    PutHeartBeat(heartrate + increment);
                }

                if (currentBdp.HeartRate >= 135)
                {
                    Random random = new Random();
                    int increment = random.Next(2,5);
                    PutHeartBeat(heartrate - increment);
                }
            } else if (currentBdp.Minutes >= 0)
            {
                if (currentBdp.Rpm < 60)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 4);
                    PutHeartBeat(heartrate + increment);
                }

                if (currentBdp.HeartRate >= 105)
                {
                    Random random = new Random();
                    int increment = random.Next(2, 5);
                    PutHeartBeat(heartrate - increment);
                }
            }            
        }

        public void AdaptCooldownHeartBeat()
        {
            
                if (currentBdp.HeartRate >= 91)
                {
                    Random random = new Random();
                    int increment = random.Next(0, 6);
                    PutHeartBeat(heartrate - increment);
                }

                if (currentBdp.HeartRate >= 85 && currentBdp.HeartRate <= 90)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 2);
                    PutHeartBeat(heartrate + increment);
                }
            
        }

        public void AdaptCooldownRPM()
        {
            if (currentBdp.Rpm > 41)
            {
               PutRPM(rpm - 5);
            }
        }

        public void AdaptCooldownPower()
        {
           if (currentBdp.Power > 36)
           {
              PutPower(power - 5);
           }
        }

        public void Close()
        {

        }

        public void PutDistance(int distance)
        {
            throw new NotImplementedException();
        }

        public void PutPower(int power)
        {
            this.power = power;
        }

        public void PutTime(int time)
        {
            throw new NotImplementedException();
        }

        public void PutRPM(int rpm)
        {
            this.rpm = rpm;
        }

        public void PutHeartBeat(int HeartBeat)
        {
            heartrate = HeartBeat;
        }

        public BikeDataPackage ReadData()
        {
            return currentBdp;
        }

        public void Reset()
        {
            seconds = 0;
        }
    }
}
