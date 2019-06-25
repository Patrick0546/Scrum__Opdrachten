using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Random = random.Next(1, 5);

            string[] NaamArrays = new string[5] { "Wout Oldenhof", "Patrick Koekkoek" , "Cas Schuurman", "Bart Haarhuis)" , "Martijn Legtenberg)"};

            if (Random == 1 )
            {
                Console.WriteLine("Wout Oldenhof");
            }
            if (Random == 2)
            {
                Console.WriteLine("Patrick Koekkoek");
            }
            if (Random == 3)
            {
                Console.WriteLine("Cas Schuurman");
            }
            if (Random == 4)
            {
                Console.WriteLine("Bart Haarhuis");
            }
            if (Random == 5)
            {
                Console.WriteLine("Martijn Legtenberg");
            }
            Console.Read();
        }
    }
}
