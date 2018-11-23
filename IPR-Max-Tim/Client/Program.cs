using Client.Bicycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private static string ServerIP = "localhost";
        private static int ServerPort = 6666;

        static void Main(string[] args)
        {
            PatientClient patientClient = new PatientClient(ServerIP, ServerPort);
            patientClient.bike = new RealBike("COM5");
        }
    }
}
