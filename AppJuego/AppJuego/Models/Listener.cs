using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;

namespace AppJuego.Models
{
    public class Listener
    {
        public Socket ListenerSocket;
        public short Port = 1234;

        public Listener()
        {
            ListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void StartListening()
        {
            try
            {
                ListenerSocket.Bind(new IPEndPoint(IPAddress.Any, Port));
                ListenerSocket.Listen(10);
                ListenerSocket.BeginAccept(AcceptCallBack, ListenerSocket);

            }
            catch (Exception ex)
            {
                throw new Exception("listening error" + ex);
            }
        }

        public void AcceptCallBack(IAsyncResult ar)
        {
            try
            {
                Socket acceptedSocket = ListenerSocket.EndAccept(ar);
                ClientController.AddClient(acceptedSocket);
                ListenerSocket.BeginAccept(AcceptCallBack, ListenerSocket);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public class SendPacket
        {
            private Socket _sendSocked;

            public SendPacket(Socket sendSocket)
            {
                _sendSocked = sendSocket;
            }

            public void Send(string data)
            {
                try
                {
                    /* what hapends here:
                         1. Create a list of bytes
                         2. Add the length of the string to the list.
                            So if this message arrives at the server we can easily read the length of the coming message.
                         3. Add the message(string) bytes
                    */

                    var fullPacket = new List<byte>();
                    fullPacket.AddRange(BitConverter.GetBytes(data.Length));
                    fullPacket.AddRange(Encoding.Default.GetBytes(data));

                    /* Send the message to the server we are currently connected to.
                    Or package stucture is {length of data 4 bytes (int32), actual data}*/
                    _sendSocked.Send(fullPacket.ToArray());
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }
    }
}