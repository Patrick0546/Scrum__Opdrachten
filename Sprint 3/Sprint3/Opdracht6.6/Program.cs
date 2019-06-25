using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //INVOER 1

            Console.WriteLine("Voer een eerste getal in voor het Machtsverheffen!");
            int invoer1 = Convert.ToInt16(Console.ReadLine());

            //INVOER 2
            Console.WriteLine("Voer een tweede getal in voor het Machtsverheffen! ");
            int invoer2 = Convert.ToInt16(Console.ReadLine());

            int antwoord = Machtsverheffen(invoer1, invoer2);

            Console.WriteLine("Het antwoord is " + antwoord);
            Console.ReadKey();
        }

        public static int Machtsverheffen(int invoer1, int invoer2)
        {
            //VARIABELEN
           int antwoord = 1;

            //BEREKEN GEDEELTE + LOOP
            for (int teller = 0; teller < invoer2; teller++)
            {
                antwoord *= invoer1;
            }

            return antwoord;
            

        }
    }
}
