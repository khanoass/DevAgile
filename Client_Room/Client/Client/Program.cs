/// ETML
/// Auteur:         Guillaume Stäubli
/// Date:           28.01.2019
/// Description:    Implémentation de la classe Program

using System;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            IPAddress ipAdressServer = IPAddress.Parse("172.16.30.46");
            IPAddress ipAdressLocal = RecupIpAdress();

            string username = "staubligu";
            
            int serverPort = 50000;
            
            Socket socket = client.ConnectSocket(ipAdressServer, serverPort);

            Console.WriteLine("Connection open with " + ipAdressServer + "\n");

            Console.WriteLine("Press enter to send test datas");

            Console.ReadLine();

            client.Send(username + ";", socket);

            Console.WriteLine("Datas sent\n");

            client.Listen(socket);

            Console.ReadLine();

            // Commentaire de test sans importance
        }

        /// <summary>
        /// Recup the ipAdress of the client
        /// </summary>
        /// <returns>client's ip adress</returns>
        static IPAddress RecupIpAdress()
        {
            IPAddress[] localIps = Dns.GetHostAddresses(Dns.GetHostName());

            foreach(IPAddress ip in localIps)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }

            return new IPAddress(new long());
        }
    }

    
}
