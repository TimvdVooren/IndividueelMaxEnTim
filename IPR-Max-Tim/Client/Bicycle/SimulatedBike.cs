using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Bicycle
{
    class SimulatedBike : IBike
    {
        private SimulatedBikeForm bikeForm;

        public SimulatedBike()
        {
            Thread simulationThread = new Thread(StartSimulator);
            simulationThread.Start();
        }

        public void Reset()
        {
            bikeForm.Reset();
        }

        public void Close()
        {
            //bikeForm.Dispose();
        }

        public void PutDistance(int distance)
        {
            throw new NotImplementedException();
        }

        public void PutPower(int power)
        {
            bikeForm.SetPower(power);
        }

        public void PutTime(int time)
        {
            bikeForm.SetTime(time);
        }

        public BikeDataPackage ReadData()
        {
            return new BikeDataPackage(bikeForm.ReadBikeData());
        }

        private void StartSimulator()
        {
            this.bikeForm = new SimulatedBikeForm();
            bikeForm.Show();
        }
    }
}
