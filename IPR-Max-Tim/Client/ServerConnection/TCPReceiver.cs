using System.Net.Sockets;
using System.IO;
using System;
using System.Text;

namespace Client.ServerConnection
{
    class TCPReceiver
    {
        private StreamReader reader;
        public bool alive = true;
        private IReceiver listener;

        public TCPReceiver(TcpClient client, IReceiver listener)
        {
            reader = new StreamReader(client.GetStream());
            this.listener = listener;
        }

        public void Start()
        {
            while (alive)
            {
                ReadStream();
            }
        }

        public void Stop()
        {
            this.alive = false;
        }

        private void ReadStream()
        {
            string readLine = "";
            readLine = reader.ReadLine();
            Console.WriteLine(readLine);

            if (readLine != "")
                listener.IsStringReceived(readLine);
        }
    }
}
