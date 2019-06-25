using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Opdracht3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Wat is uw naam?");
            string naam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hoe oud bent u?");
            double leeftijd = Convert.ToDouble(Console.ReadLine());
            timer.Stop();

            var seconden = timer.ElapsedMilliseconds / 1000;
            Console.WriteLine("Je deed er: " + seconden + " seconden over!");
            Console.ReadKey();
        }
    }
}
