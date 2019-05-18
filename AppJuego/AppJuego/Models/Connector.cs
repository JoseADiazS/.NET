﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Web;

namespace AppJuego.Models
{
    public class Connector
    {
        private Socket _connectingSocket;

        public void TryToConnect()
        {
            _connectingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            while (!_connectingSocket.Connected)
            {
                Thread.Sleep(1000);
                try
                {
                    _connectingSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234));
                }
                catch { };
            }
            SetupForReceiving();
        }
        private void SetupForReceiving()
        {
            Client.SetClient(_connectingSocket);
           
        }

    }
}