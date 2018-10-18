﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace Remote_Healthcare.TCPCommunication
{
    class TCPReceiver
    {
        private StreamReader reader;
        private Stream stream;

        private IReceiver listener;

        public TCPReceiver(TcpClient client, IReceiver listener)
        {
            reader = new StreamReader(client.GetStream());
            this.listener = listener;
            stream = client.GetStream();
        }

        public void Start()
        {
            while (true)
            {
                ReadStream();
            }
        }

        private void ReadStream()
        {
            byte[] sizeInfo = new byte[4];

            int totalRead = 0, read = 0;
            do
            {
                read = stream.Read(sizeInfo, totalRead, sizeInfo.Length - totalRead);

                totalRead += read;
            } while (totalRead < sizeInfo.Length && read > 0);

            int messageSize = BitConverter.ToInt32(sizeInfo, 0);

            byte[] data = new byte[messageSize];

            totalRead = 0;

            do
            {
                totalRead += read = stream.Read(data, totalRead, data.Length - totalRead);
            } while (totalRead < messageSize && read > 0);
            String message = Encoding.UTF8.GetString(data);
            listener.IsStringReceived(message);
        }
    }
}
