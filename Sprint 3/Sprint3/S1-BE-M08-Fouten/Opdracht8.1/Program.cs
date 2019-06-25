using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input checker");
            string input = Console.ReadLine();

            GetalChecker(input);
        }

        static void GetalChecker(string input)
        {
            int n;
            bool isNummer = int.TryParse(input, out n);

            if (isNummer)


            {
                Console.WriteLine("De invoer is een getal!");
            }
            else
            {
                Console.WriteLine("De invoer is geen getal!");
            }
            Console.ReadKey();
        }
    }
}
