using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Network
{
    /// <summary>
    /// Handles the network part of the app
    /// </summary>
    static class Room
    {
        private static bool _running; // Is the server running ?
        private static bool _connection;   // Is the server listening ?
        private static uint _ticks; // Ticks

        private static readonly object ConsoleWriterLock = new object(); // Basically the mutex for writing to the console

        private static List<TcpClient> _clients; // Clients
        private static Queue<PlayerInfo> _data; // Data to pool

        private static Thread t1, t2, t3; // Threads

        /// <summary>
        /// Listen to new client connecting
        /// </summary>
        private static void ListenToConnections(IPAddress local, uint port)
        {
            lock (ConsoleWriterLock) { Console.WriteLine("Listening to new connections."); }

            // Starting the TCP listener
            TcpListener listener = new TcpListener(local, (int)port);
            listener.Start();

            while (_running && _connection)
            {
                TcpClient client = listener.AcceptTcpClient();
                lock (ConsoleWriterLock) { Console.WriteLine("New client connecting."); }

                //Adding the client to the list of clients
                lock (_clients)
                {
                    _clients.Add(client);
                }
            }

            listener.Stop();
            lock (ConsoleWriterLock) { Console.WriteLine("Listening finished."); }
        }

        /// <summary>
        /// Listens to the inputs
        /// </summary>
        private static void GetInputs()
        {
            while (_running)
            {
                Thread.Sleep((int)(_ticks / 1000));

                if (_connection)
                {
                    byte[] bytes = new byte[1000];
                    for (int i = 0; i < _clients.Count; i++)
                    {
                        // Receiving the data of the current client
                        NetworkStream stream = _clients[i].GetStream();
                        int x;
                        try
                        {
                            while ((x = stream.Read(bytes, 0, bytes.Length)) != 0)
                            {
                                string data = System.Text.Encoding.ASCII.GetString(bytes, 0, x);

                                // Parsing the data
                                IPAddress ipv4 = IPAddress.Parse(((IPEndPoint)_clients[i].Client.RemoteEndPoint).Address.ToString());
                                string username = data.Split(';')[0];

                                // Adding the new playerdata
                                PlayerInfo info = new PlayerInfo();
                                info.IPV4 = ipv4;
                                info.Username = username;

                                lock (_data)
                                {
                                    _data.Enqueue(info);
                                }

                                lock (ConsoleWriterLock) { Console.WriteLine("Received data: " + data); }
                            }
                        }
                        catch
                        {
                            Exception e = new Exception("Client not found.");
                        }
                    }
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// Polls the informations of other clients
        /// </summary>
        private static void PollOutputs()
        {
            while (_running)
            {
                Thread.Sleep((int)(_ticks / 1000));

                // If the queue is not empty
                lock (_data)
                {
                    if (_data.Count > 0)
                    {
                        if (_connection)
                        {
                            lock (_clients)
                            {
                                // Poll
                                for (int i = 0; i < _clients.Count; i++)
                                {
                                    // Get ip address
                                    IPAddress address = IPAddress.Parse(((IPEndPoint)_clients[i].Client.RemoteEndPoint).Address.ToString());

                                    if (address.ToString() != _data.Peek().IPV4.ToString())
                                    {
                                        // Sending the data
                                        byte[] bytes = Encoding.ASCII.GetBytes(_data.Peek().IPV4.ToString() + ";" + _data.Peek().Username);

                                        // Checking for the client
                                        try
                                        {
                                            _clients[i].Client.Send(bytes);
                                            lock (ConsoleWriterLock) { Console.WriteLine("Sent: " + System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length)); }
                                        }
                                        catch
                                        {
                                            Exception e = new Exception("Client not found.");
                                        }
                                    }
                                }
                            }

                            //Remove the last element
                            _data.Dequeue();
                            lock (ConsoleWriterLock) { Console.WriteLine("Sent to all clients."); }
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        /// <summary>
        /// Starts the server
        /// </summary>
        public static void Start(IPAddress local, uint port, uint ticks)
        {
            lock (ConsoleWriterLock) { Console.WriteLine("Starting room at " + local.ToString() + ":" + port + "."); }

            _clients = new List<TcpClient>();
            _data = new Queue<PlayerInfo>();

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                lock (ConsoleWriterLock) { Console.WriteLine("Not connected to the internet."); }
                _running = false;
            }
            else
            {
                _running = true;
                _ticks = ticks;

                // Starting listener thread
                t1 = new Thread(() => ListenToConnections(local, port));
                t1.Start();

                // Starting data listener thread
                t2 = new Thread(() => GetInputs());
                t2.Start();

                // Starting pool thread
                t3 = new Thread(() => PollOutputs());
                t3.Start();
            }
        }

        /// <summary>
        /// Updates the player's infos
        /// </summary>
        public static void Update(ref PlayerInfo currentInfo, bool init)
        {
            Thread.Sleep((int)(_ticks / 1000));

            _connection = init;

            // Check for disconnected clients
            for (int i = 0; i < _clients.Count; i++)
            {
                lock (_clients)
                {
                    if (!_clients[i].Connected)
                        _clients.Remove(_clients[i]);
                }
            }
        }

        /// <summary>
        /// Stops the server
        /// </summary>
        public static void Stop()
        {
            //Stopping the threads
            lock (ConsoleWriterLock) { Console.WriteLine("Stopping processes."); }
            t1.Join();
            t2.Join();
            t3.Join();
        }

        /// <summary>
        /// Returns true if running, false otherwise
        /// </summary>
        public static bool IsRunning
        {
            get { return _running; }
        }

        public static bool IsConnecting
        {
            get { return _connection; }
        }
    }
}
