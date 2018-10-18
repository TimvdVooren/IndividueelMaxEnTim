using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerClient
    {
        public TcpClient Client { get; }
        public string ClientName { get; set; }
        public string PatientName { get; set; }
        public bool Available { get; set; }

        public ServerClient(TcpClient Client)
        {
            this.Client = Client;
            this.ClientName = "";
            this.PatientName = "";
            this.Available = true;
        }
    }
}
