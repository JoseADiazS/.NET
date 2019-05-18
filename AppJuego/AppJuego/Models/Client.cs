using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;
using static AppJuego.Models.Listener;

namespace AppJuego.Models
{
    public class Client
    {
        public Socket _socket { get; set; }
        public ReceivePacket Receive { get; set; }
        public int Id { get; set; }

        public Client(Socket socket, int id)
        {
            Receive = new ReceivePacket(socket);
            Receive.StartReceiving();
            _socket = socket;
            Id = id;
        }

        public static void SetClient(Socket socket)
        {
            //Receive = new ReceivePacket(socket);
            var SendPacket = new SendPacket(socket);
        }
    }

    static class ClientController
    {
        public static List<Client> Clients = new List<Client>();

        public static void AddClient(Socket socket)
        {
            Clients.Add(new Client(socket, Clients.Count));
        }

        public static void RemoveClient(int id)
        {
            Clients.RemoveAt(Clients.FindIndex(x => x.Id == id));
        }

    }
    public class ReceivePacket
    {
        private byte[] _buffer;
        private Socket _receiveSocket;

        public ReceivePacket(Socket receiveSocket)
        {
            _receiveSocket = receiveSocket;
        }

        public void StartReceiving()
        {
            try
            {
                _buffer = new byte[4];
                _receiveSocket.BeginReceive(_buffer,
                                            0,
                                            _buffer.Length,
                                            SocketFlags.None,
                                            ReceiveCallBack,
                                            null);
            }
            catch { }
        }

        private void ReceiveCallBack(IAsyncResult ar)
        {
            string data = "";
            try
            {
                if (_receiveSocket.EndReceive(ar) > 1)
                {
                    _buffer = new byte[BitConverter.ToInt32(_buffer, 0)];
                    _receiveSocket.Receive(_buffer, _buffer.Length, SocketFlags.None);

                    data = Encoding.Default.GetString(_buffer);
                    StartReceiving();
                }
                else
                {
                    Disconnect();
                }
            }
            catch
            {
                if (!_receiveSocket.Connected)
                {
                    Disconnect();
                }
                else
                {
                    StartReceiving();
                }
            }
            //return data;
        }

        private void Disconnect()
        {
            _receiveSocket.Disconnect(true);
            //ClientController.RemoveClient(_clientId);
        }
    }
}