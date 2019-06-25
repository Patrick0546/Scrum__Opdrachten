using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation; //Include this

namespace Opdracht8._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ipadres;
            Console.WriteLine("Voer een IP-Adres in!");
            ipadres = (Console.ReadLine());

            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ipadres, 1000);
                if (reply != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Status :  " + reply.Status );
                    Console.WriteLine("IP Adres : " + reply.Address);

                }
            }
            catch
            {
                Console.WriteLine("ERROR : TIMEOUT");
            }
             Console.ReadKey();
        }
    }
}