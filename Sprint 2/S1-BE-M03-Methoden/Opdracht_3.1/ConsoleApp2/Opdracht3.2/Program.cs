using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is de geboortedatum van uw man?(DD MM JJJJ): ");
            DateTime man = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Wat is de geboortedatum van uw vrouw?(DD MM JJJJ): ");
            DateTime vrouw = Convert.ToDateTime(Console.ReadLine());

            if (man < vrouw)
            {
                double antwoord = (vrouw - man).TotalDays;
                Console.WriteLine("Uw man is ouder");
                Console.Write("Uw man is " + antwoord + " dag(en) ouder dan uw vrouw.");
                Console.ReadKey();
            }
            else
            {
                double antwoord = (man - vrouw).TotalDays;
                Console.WriteLine("Uw vrouw is ouder");
                Console.Write("Uw vrouw is " + antwoord + " dag(en) ouder dan uw man.");
                Console.ReadKey();
            }
        }
    }
}