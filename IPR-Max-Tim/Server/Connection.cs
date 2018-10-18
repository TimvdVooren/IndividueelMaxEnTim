using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace Server
{
    class Connection
    {
        public int bikeID;
        private TcpClient client;
        private IDataListener listener;
        private StreamWriter writer;

        public string ClientName { get; set; }
        public string PatientName { get; set; }
        public bool Available { get; set; }

        private ConnectionDataReceiver dataReceiver;
        private Thread worker;

        public Connection(TcpClient client, IDataListener listener, int id)
        {
            this.client = client;
            this.listener = listener;
            this.bikeID = id;
            this.ClientName = "";
            this.PatientName = "";
            this.Available = true;

            this.writer = new StreamWriter(client.GetStream());
            StartStreamreaderThead();
        }
        
        public void SendData(string data)
        {
            writer.WriteLine(data);
        }

        private void StartStreamreaderThead()
        {
            dataReceiver = new ConnectionDataReceiver(listener, client);
            worker = new Thread(new ThreadStart(dataReceiver.Start));
            worker.Start();
        }

        public void StopStreamReaderThread()
        {
            if(worker != null)
            {
                worker.Abort();
                worker.Join();
            }
        }
    }
}
