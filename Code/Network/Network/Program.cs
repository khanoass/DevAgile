using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Network
{
    class Program
    {
        private static ConsoleKeyInfo key;
        private static bool _running;

        /// <summary>
        /// Listens to keys
        /// </summary>
        static void KeyboardListener()
        {
            while(_running)
                key = Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // SAMPLE ROOM

            Thread keys = new Thread(() => KeyboardListener());
            keys.Start();

            uint port = 50000;

            Console.Write("Tickrate: ");
            uint ticks = Convert.ToUInt32(Console.ReadLine());

            _running = true;
            bool start = true;
            while(true)
            {
                if(start)
                {
                    //Getting the local address
                    IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                    IPAddress local = new IPAddress(new long());
                    foreach (IPAddress addr in localIPs)
                    {
                        if (addr.AddressFamily == AddressFamily.InterNetwork)
                        {
                            local = addr;
                            break;
                        }
                    }

                    start = false;

                    //Creating the room
                    Room.Start(local, port, ticks);
                }

                PlayerInfo info = new PlayerInfo();

                bool connecting = true;
                Room.Update(ref info, connecting);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    Room.Stop();
                    _running = false;
                    keys.Join();
                }
            }
        }
    }
}