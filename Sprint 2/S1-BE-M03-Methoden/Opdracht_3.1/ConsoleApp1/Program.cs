using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Wat is uw voornaam?");
            string voornaam = Convert.ToString(Console.ReadLine());

            Console.Write("Wat is uw tussenvoegsel?");
            string tussenvoegsels = Convert.ToString(Console.ReadLine());

            Console.Write("Wat is uw achternaam?");
            string achternaam = Convert.ToString(Console.ReadLine());

            Console.Write("Uw ingegeven informatie is " + tekens + " tekens lang");
            Console.ReadKey ();

            int tekens = voornaam.Length + tussenvoegsels.Length + achternaam.Length;
            

        }
    }
}
