using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int kleur = random.Next(1, 6);
            if (kleur == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("de kleur is geel");
            }
            else if (kleur == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("de kleur is rood");
            }
            else if (kleur == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("de kleur is blauw");
            }
            else if (kleur == 4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("de kleur is wit");
            }
            else if (kleur == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("de kleur is groen");
            }
            else if (kleur == 6)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("de kleur is grijs");
            }

            Random r = new Random();
            int prevnum = -1;
            int nummer;

            for (int loop = 0; loop < 6; loop++)
            {
                // If new random number same as previous then keep trying again until its different.
                do
                {
                    nummer = r.Next(46);
                } while (nummer == prevnum);

                Console.WriteLine(nummer);

                prevnum = nummer;
                Console.ReadKey();
            }
        }

    }
}