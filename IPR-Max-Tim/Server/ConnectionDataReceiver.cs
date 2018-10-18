using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server
{
    class ConnectionDataReceiver
    {
        private IDataListener listener;
        private TcpClient client;
        private StreamReader reader;
        private bool isAlive;

        public ConnectionDataReceiver(IDataListener listener, TcpClient client)
        {
            isAlive = true;
            this.listener = listener;
            this.client = client;
            reader = new StreamReader(client.GetStream());
        }

        public void Start()
        {
            while (isAlive)
            {
                ReadStream();
            }
        }

        private void ReadStream()
        {
            string message = reader.ReadLine();
            if(message != null && message != "")
            {
                listener.OnDataReceived(message);
            }
        }
    }
}
