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
