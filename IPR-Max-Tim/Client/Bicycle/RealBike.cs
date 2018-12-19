using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Bicycle
{
    class RealBike : IBike
    {
        private SerialPort SerialConnection;

        public RealBike(string comPort)
        {
            SerialConnection = new SerialPort(comPort);
            SerialConnection.Handshake = Handshake.XOnXOff;
            SerialConnection.Open();
        }

        public void Reset()
        {
            SerialConnection.WriteLine("RS");
            SerialConnection.WriteLine("CD");
        }

        public void Close()
        {
            SerialConnection.Close();
        }

        public void PutDistance(int distance)
        {
            SerialConnection.WriteLine("CM");
            SerialConnection.WriteLine("PD" + distance);
        }

        public void PutPower(int power)
        {
            SerialConnection.WriteLine("CM");
            SerialConnection.WriteLine("PW" + power);
        }

        public void PutTime(int time)
        {
            SerialConnection.WriteLine("CM");
            SerialConnection.WriteLine("PT" + time);
        }

        public BikeDataPackage ReadData()
        {
            SerialConnection.WriteLine("CM");
            SerialConnection.WriteLine("ST");
            string bikeData = SerialConnection.ReadLine();

            if (bikeData.Contains("ERROR") || bikeData.Contains("RUN") || bikeData.Contains("ACK"))
                return ReadData();
            else
                return new BikeDataPackage(bikeData);
        }
    }
}
