using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsWeekend())
            {
                Console.WriteLine("Het is vandaag weekend");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Het is vandaag geen weekend");
                Console.ReadLine();
            }
        }


        static bool IsWeekend()
        {
            String dag;
            dag = DateTime.Now.DayOfWeek.ToString();

            if (dag == "Saturday" || dag == "Sunday")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}