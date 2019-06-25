using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef u deeltal?");
            int deeltal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef uw deler?");
            int deler = Convert.ToInt32(Console.ReadLine());

            if (deler == 0)
            {
                Console.WriteLine("“Wie deelt door nul is een snul!");
            }
            else
            {
                int Quotiënt = deeltal / deler;
                Console.WriteLine(deeltal + " gedeeld door " + deler + " is " + Quotiënt);
            }


            Console.ReadKey();

        }
    }
}