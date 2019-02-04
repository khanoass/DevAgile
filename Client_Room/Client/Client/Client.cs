/// ETML
/// Auteur:         Guillaume Stäubli
/// Date:           28.01.2019
/// Description:    Implémentation de la classe Client

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        /// <summary>
        /// Create and connect a new socket to an ip adress and a port to the server
        /// </summary>
        /// <param name="ip">ip adress of the server</param>
        /// <param name="port">port number of the server</param>
        /// <returns>Socket used to transfert datas between client and server</returns>
        public Socket ConnectSocket(IPAddress ip, int port)
        {
            // create a new IpEndPoint for the server
            IPEndPoint ipe = new IPEndPoint(ip, port);

            // create a new socket to establish connection between client and server
            Socket socket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // try to connect the socket with the server
            do
            {
                try
                {
                    socket.Connect(ipe);
                }
                catch
                {
                    Console.WriteLine("Trying to connect to the server... waiting");
                }
            }
            while (socket.Connected == false);
            
            // return the socket
            return socket;
        }

        /// <summary>
        /// Send datas by a specified socket
        /// </summary>
        /// <param name="data">datas to send</param>
        /// <param name="socket">socket by wich the datas will travel</param>
        public void Send(string data, Socket socket)
        {
            // try to send the datas to the server
            do
            {
                try
                {
                    // convert the string datas to a byte datagramm
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(data);

                    // send the byte datagramm to the specified socket
                    socket.Send(bytesToSend);
                }
                catch
                { 
                    Console.WriteLine("Not connected to server... waiting");
                }
            }
            while (socket.Connected == false);
        }

        /// <summary>
        /// Listen to new client connecting
        /// </summary>
        public void Listen(Socket socket)
        {
            byte[] bytes = new byte[1000];

            // listen the new datas incoming from server
            while (true)
            {
                try
                {
                    // receive the datas
                    socket.Receive(bytes);

                    // convert the byte datagramm to a string
                    string data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                    Console.WriteLine("Received from Server : " + data + "\n");
                }
                catch
                {
                    Console.WriteLine("No datas incoming from server... waiting");
                }
            }
        }
    }
}
