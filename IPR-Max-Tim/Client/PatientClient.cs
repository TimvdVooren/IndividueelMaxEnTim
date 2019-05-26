using Client.Bicycle;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Client
{
    class PatientClient
    {
        private TcpClient client;
        public IBike bike { get; set; }
        private System.Timers.Timer bikeDataTimer;

        public PatientClient(string ip, int port)
        {
            client = new TcpClient(ip, port);
            string clientType = JsonConvert.SerializeObject(new
            {
                command = "client/type",
                data = new
                {
                    type = "patient"
                }
            });
            WriteTextMessage(clientType);

            Thread clientThread = new Thread(StartClient);
            clientThread.Start();
        }

        private void StartClient()
        {
            while (true)
            {
                HandleData(ReadTextMessage());
            }
        }

        private void HandleData(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            string command = receivedData.command;
            string commandData = receivedData.data;
            Console.WriteLine(command);

            switch (command)
            {
                case "course_start":
                    bike.Reset();
                    bikeDataTimer = new System.Timers.Timer(1000);
                    bikeDataTimer.AutoReset = true;
                    bikeDataTimer.Elapsed += Timer_Elapsed;
                    bikeDataTimer.Start();
                    break;
                case "course_stop":
                    bikeDataTimer.Stop();
                    break;
                case "change_power":
                    HandleChangePower(commandData);
                    break;
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BikeDataPackage bdp = bike.ReadData();
  
            string data = JsonConvert.SerializeObject(new
            {
                power = bdp.Power,
                rpm = bdp.Rpm,
                minutes = bdp.Minutes,
                seconds = bdp.Seconds,
                heartrate = bdp.HeartRate,
            });
            WriteTextMessage(CreateJsonCommand("bike_data", data));
        }

        private void HandleChangePower(string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            int increment = receivedData.increment;

            int power = bike.ReadData().Power;
            power = power + 5 * increment;

            if (power < 25)
                power = 25;
            if (power > 400)
                power = 400;

            bike.PutPower(power);
        }

        private void AddPower(int power, int increment)
        {
            power = power + increment;

            if (power < 25)
                power = 25;
            if (power > 400)
                power = 400;

            bike.PutPower(power);
        }

        private string CreateJsonCommand(string command, string data)
        {
            string output = JsonConvert.SerializeObject(new
            {
                command = command,
                data = data,
            });
            return output;
        }

        private void WriteTextMessage(string message)
        {
            StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF32);
            writer.WriteLine(message);
            writer.Flush();
        }

        private string ReadTextMessage()
        {
            StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF32);
            string message = reader.ReadLine();
            return message;
        }
    }
}
