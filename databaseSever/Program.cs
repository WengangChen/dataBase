﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace databaseSever
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            int port = 40400;

            TcpListener listener = new TcpListener(new IPEndPoint(addr, port));
            listener.Start();

            TcpClient remoteClient = listener.AcceptTcpClient();

            NetworkStream streamToClient = remoteClient.GetStream();
            byte[] buffer = new byte[1024];

            int bytesRead;
            try
            {
                lock (streamToClient)
                {
                    bytesRead = streamToClient.Read(buffer, 0, buffer.Length);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
