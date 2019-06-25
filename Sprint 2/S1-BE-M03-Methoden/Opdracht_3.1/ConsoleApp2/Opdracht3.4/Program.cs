using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABELEN
            double USD, GBP, JPY, AUD, CHF;

            Console.Write("Welk bedrag wilt u in Euro's omrekenen?: ");
            Double invoer = Convert.ToDouble(Console.ReadLine());

            //BEREKEN GEDEELTE
            USD = invoer * 1.1317;

            GBP = invoer * 0.8874;

            JPY = invoer * 128.547;

            AUD = invoer * 1.5643;

            CHF = invoer * 1.1315;

            //UITVOER
            Console.WriteLine("Uw ingevoerde euro's (" + invoer + ") is " +USD + " USD waard!");
            Console.WriteLine("Uw ingevoerde euro's (" + invoer + ") is " + GBP + " GBP waard!");
            Console.WriteLine("Uw ingevoerde euro's (" + invoer + ") is " + JPY + " JPY waard!");
            Console.WriteLine("Uw ingevoerde euro's (" + invoer + ") is " + AUD + " AUD waard!");
            Console.WriteLine("Uw ingevoerde euro's (" + invoer + ") is " + CHF + " CHF waard!");
            Console.ReadKey();
        }
    }
}
