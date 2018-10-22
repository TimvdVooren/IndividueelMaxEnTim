using Client.DataHandling;
using Client.ServerConnection;
using System;

namespace Client
{
    class Program
    {
        static int _BIKE_MODE = 1; // 0 = realbike, 1 = simbike
        static string _SERVER_IP = "localhost";

        static void Main(string[] args)
        {
            // The IP Address of the Server to connect to
            
            Console.WriteLine("---  Setting up Bicycle   ---");
            SerialDataHandler.getInstance().InitializeBike(_BIKE_MODE);
            Console.WriteLine("---  Bicycle setup succesful ---");
            Console.WriteLine("");
            Console.WriteLine("---  Connecting to Remote-Healthcare server  ---");
            Connection con = new Connection(_SERVER_IP, 6666);
            Console.WriteLine("---  Connected sucesfully to Remote-Healthcare server  ---");
            Console.ReadLine();
        }
    }
}
