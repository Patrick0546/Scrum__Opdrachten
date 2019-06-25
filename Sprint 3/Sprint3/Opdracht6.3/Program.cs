using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int dag, maand;

            Console.WriteLine("Vul je dag in.");
            dag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul je maand in.");
            maand = Convert.ToInt32(Console.ReadLine());

            DateTime datumGetal = new DateTime(DateTime.Now.Year, maand, dag);
            Zodaic(datumGetal);
            Console.ReadLine();
        }

        static void Zodaic(DateTime datumInvoer)
        {
            if ((new DateTime(DateTime.Now.Year, 3, 21) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 4, 20) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Ram);
            }

            if ((new DateTime(DateTime.Now.Year, 4, 21) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 5, 20) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Stier);
            }

            if ((new DateTime(DateTime.Now.Year, 5, 22) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 6, 21) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Tweelingen);
            }

            if ((new DateTime(DateTime.Now.Year, 6, 22) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 7, 23) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Kreeft);
            }

            if ((new DateTime(DateTime.Now.Year, 7, 24) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 8, 23) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Leeuw);
            }

            if ((new DateTime(DateTime.Now.Year, 8, 24) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 9, 23) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Maagd);
            }

            if ((new DateTime(DateTime.Now.Year, 9, 24) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 10, 23) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Weegschaal);
            }

            if ((new DateTime(DateTime.Now.Year, 10, 24) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 11, 22) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Schorpioen);
            }

            if ((new DateTime(DateTime.Now.Year, 11, 23) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 12, 22) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Boogschutter);
            }

            if (((new DateTime(DateTime.Now.Year, 12, 23) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 12, 31) >= datumInvoer)) ||
               ((new DateTime(DateTime.Now.Year, 1, 1) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 1, 20) >= datumInvoer)))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Steenbok);
            }

            if ((new DateTime(DateTime.Now.Year, 1, 21) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 2, 18) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Waterman);
            }

            if ((new DateTime(DateTime.Now.Year, 2, 19) <= datumInvoer) && (new DateTime(DateTime.Now.Year, 3, 20) >= datumInvoer))
            {
                Console.WriteLine("Je sterrenbeeld is: " + Sterrenbeeld.Vissen);
            }

        }

        enum Sterrenbeeld
        {
            Ram,
            Stier,
            Tweelingen,
            Kreeft,
            Leeuw,
            Maagd,
            Weegschaal,
            Schorpioen,
            Boogschutter,
            Steenbok,
            Waterman,
            Vissen,
        }

    }
}