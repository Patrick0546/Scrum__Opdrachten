using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoelang moet uw wachtwoord zijn? Minimaal 10karakters - Maximaal 60karakters");
            int lengtePW = Convert.ToInt32(Console.ReadLine());

            if (lengtePW < 10 || lengtePW > 60)
            {
                Console.WriteLine("Het wachtwoord voldoet niet aan de opgegeven eisen!");
                Console.ReadKey();
                return;
            }

            Random random = new Random();
            int Random = random.Next(10, 26);

            char[] Karakters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] Special_Karakters = { '@', '"', '!', '#', '$', '%', '&', '*', '@', '?' };

            string password = Special_Karakters[random.Next(0, Special_Karakters.Length)].ToString();

            for (int i = 1; i < lengtePW; i++)
            {
                password += Karakters[random.Next(0, Karakters.Length)].ToString();
            }

            Console.WriteLine("Uw nieuwe wachtwoord is " + password);
            Console.ReadKey();
        }
    }
}