using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime jaar = new System.DateTime(1999, 1, 13, 3, 57, 32, 11);
            String dag;
            int year = jaar.Year;
            dag = DateTime.Now.DayOfWeek.ToString();

            if (dag == "Saturday" || dag == "Sunday")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Het is vandaag weekend");
                Console.ReadLine();
            }
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " Dit jaar is een Schrikkeljaar ");
            }
            else
            {
                Console.WriteLine("Dit jaar is geen schrikkeljaar!");
                Console.ReadLine();
            }
            DateTime date1 = DateTime.Now;
            if (dag == "Saturday" || dag == "Sunday")
            {
                    Console.WriteLine("Het is vandaag weekend");
                    Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Het is vandaag een weekdag namelijk " + DateTime.Now.DayOfWeek);
                Console.ReadLine();
            }

        }
    }
}