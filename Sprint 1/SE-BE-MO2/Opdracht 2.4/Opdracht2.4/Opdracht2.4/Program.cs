using System;

namespace Opdracht2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.Write("Wat is uw voornaam?: ");
            string firstname = Convert.ToString(Console.ReadLine());

            Console.Write("Wanneer bent u jarig?");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            int antwoord = now.Day - birthday.Day;
            Console.Write(firstname + " is: " + antwoord );
            Console.ReadKey();
        }
    }
}