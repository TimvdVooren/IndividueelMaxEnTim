using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Client.Bicycle
{
    class SimulatedBike : IBike
    {
        public SimulatedBikeForm bikeForm { get; set; }
        private System.Timers.Timer simulatorTimer;
        private BikeDataPackage currentBdp;
        private BikeDataPackage oldBdp;
        private int seconds = 0;

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
            seconds++;
            int heartrate = bikeForm.heartrate;
            int rpm = bikeForm.rpm;
            int power = bikeForm.power;
            int[] currentValues = {heartrate, rpm, 0, power, 0, seconds};
            currentBdp = new BikeDataPackage(currentValues);

            adeptPower();
            adeptRPM();
            adeptHearthbeat();
        }


        public void adeptPower()
        {
            //Minutes need to be 2 but this is for test
            if (currentBdp.Minutes >= 1)
            {
                if (currentBdp.HeartRate < 130)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 2);
                    PutPower(bikeForm.power + increment);
                }
                else if (currentBdp.Rpm < 65)
                {
                    PutPower(bikeForm.power - 2);
                }

                if (currentBdp.Rpm > 65)
                {
                    PutPower(bikeForm.power + 2);
                }
            }
        }

        public void adeptRPM()
        {
            //Minutes need to be 2 but this is for test
            if (currentBdp.Minutes >= 1)
            {
                if (currentBdp.HeartRate <= 130 || currentBdp.Power < 70)
                {
                    Random random = new Random();
                    int increment = random.Next(0,2);
                    PutRPM(bikeForm.rpm + increment);
                }
                else if (currentBdp.HeartRate > 135 || currentBdp.Power > 70 && currentBdp.Rpm > 65)
                {
                    PutRPM(bikeForm.rpm - 1);
                }
            }
        }

        public void adeptHearthbeat()
        {
            //Minutes need to be 2 but this is for test
            if (currentBdp.Minutes >= 1)
            {
                if (currentBdp.Rpm < 70)
                {
                    Random random = new Random();
                    int increment = random.Next(1, 4);
                    PutHeartBeat(bikeForm.heartrate + increment);
                }

                if (currentBdp.HeartRate >= 135)
                {
                    Random random = new Random();
                    int increment = random.Next(2,5);
                    PutHeartBeat(bikeForm.heartrate - increment);
                }
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
            bikeForm.power = power;
        }

        public void PutTime(int time)
        {
            throw new NotImplementedException();
        }

        public void PutRPM(int rpm)
        {
            bikeForm.rpm = rpm;
        }

        public void PutHeartBeat(int HeartBeat)
        {
            bikeForm.heartrate = HeartBeat;
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
