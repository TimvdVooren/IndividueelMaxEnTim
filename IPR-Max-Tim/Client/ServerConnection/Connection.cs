using Newtonsoft.Json;
using Client.Bicycle;
using Client.DataHandling;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace Client.ServerConnection
{
    class Connection : IBikeDataListener, IReceiver
    {
        private TCPReceiver receiver;
        private Thread worker;
        private TcpClient client;
        private BikeDataPackage latestBikeData;
        private System.Timers.Timer dataRequestTimer;

        private bool dataRequested;

        public Connection(string ip, int port)
        {
            dataRequested = false;
            SerialDataHandler.getInstance().AddSubscriberToHandler(this);
            ConnectToServer(ip, port);

            latestBikeData = new BikeDataPackage("1970-01-01-00:00:00", "0", "0", "0", "0", "0");
            dataRequestTimer = new System.Timers.Timer(100);
            dataRequestTimer.Elapsed += OnTimerTick;
            dataRequestTimer.AutoReset = true;
            dataRequestTimer.Enabled = true;
            dataRequestTimer.Start();

            client.GetStream().Flush();
            SendMessage(ServerCommands.ClientType());
        }

        public void EndConnection()
        {
            client.GetStream().Flush();
            client.GetStream().Close();
            client.Close();
            //tim zn ip: 145.49.13.212
            //port 6666
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
            if (message != null && message != "")
            {
                StreamWriter sw = new StreamWriter(client.GetStream(), Encoding.UTF32);
                sw.WriteLine(message);
                sw.Flush();
            }
        }

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                Console.WriteLine($"Connecting to {ip}:{port}");
                client = new TcpClient(ip, port);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Server not available");
                Console.WriteLine("Error code: " + ex.ToString());
                Console.WriteLine("Retrying connection");
            }
            if (!client.Connected)
                ConnectToServer(ip, port);
            else
            {
                Console.WriteLine("Connected succesfully");
                AddReceiverThread();
            }
        }

        private void AddReceiverThread()
        {
            receiver = new TCPReceiver(client, this);
            worker = new Thread(new ThreadStart(receiver.Start));
            worker.Start();
        }

        private void HandleData(string command, string data)
        {
            dynamic receivedData = JsonConvert.DeserializeObject(data);
            switch (command)
            {
                case "course_start":
                    StartCourse();
                    break;
                case "course_stop":
                    EndCourse();
                    break;
                case "change_power":
                    int increment = receivedData.increment;
                    SetPower(increment);
                    break;
                case "client/id":
                    ServerCommands.BikeID = Convert.ToInt32(receivedData.id);
                    break;
            }
        }

        private void StartCourse()
        {
            SerialDataHandler.getInstance().Reset();
            dataRequested = true;
        }

        private void EndCourse()
        {
            dataRequested = false;
        }

        private void SetPower(int increment)
        {
            SerialDataHandler.getInstance().SetPower((int.Parse(latestBikeData.power) + 4*increment));
        }

        private void ParseData(string receivedData)
        {
            dynamic message;
            if (receivedData != "" || receivedData != null)
            {
                try
                {
                    message = JsonConvert.DeserializeObject(receivedData);
                }
                catch (Exception e)
                {
                    message = JsonConvert.DeserializeObject(receivedData.Substring(1));
                }
                string command = message.command;
                string data = message.data;
                HandleData(command, data);
            }
        }

        public void IsStringReceived(string message)
        {
            Console.WriteLine(message);
            ParseData(message);
        }

        public void OnBikeDataReceived(BikeDataPackage package)
        {
            //MISSCHIEN MOET DIT AAN DE DOKTERKANT GEBEUREN
            string time = package.time;
            string[] timeComponents = time.Split(':');

            if (int.Parse(timeComponents[0]) < 2)
            {
                SerialDataHandler.getInstance().SetPower(80);
                package.power = "80";
            }
            //else if (int.Parse(timeComponents[0]) < 6)
            //correctionPower = int.Parse(package.power);
            else if (int.Parse(timeComponents[0]) >= 6 && int.Parse(timeComponents[0]) < 7)
            {
                SerialDataHandler.getInstance().SetPower(40);
                package.power = "40";
            }
            else if (int.Parse(timeComponents[0]) >= 7)
            {
                SerialDataHandler.getInstance().SetPower(25);
                package.power = "25";
            }

            latestBikeData = package;
        }

        private void OnTimerTick(object source, ElapsedEventArgs args)
        {
            SerialDataHandler.getInstance().RequestStatus();

            if (dataRequested)
            {
                SendMessage(ServerCommands.SendBikeData(latestBikeData));
            }
        }
    }
}
