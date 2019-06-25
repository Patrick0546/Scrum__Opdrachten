using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._4
{
    class Program
    {
        static void Main(string[] args)
        {
        
            for (int i = 1900; i <= 2018; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine(i + " Schrikkeljaar");
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}