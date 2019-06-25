using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw start kapitaal?");
            double input_kapitaal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is het rente percentage?");
            double input_rente = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                input_kapitaal *= 1 + (input_rente / 100);
                Console.WriteLine(input_kapitaal);
            }
            Console.ReadKey();
        }
    }
}
