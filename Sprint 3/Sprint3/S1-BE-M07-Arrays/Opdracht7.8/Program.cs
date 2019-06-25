using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._8
{
    class Program
    {
        static void Main(string[] args)

        {

            Random random = new Random();
            int een = random.Next(1, 100);
            int twee = random.Next(1, 100);
            int drie = random.Next(1, 100);
            int vier = random.Next(1, 100);
            int vijf = random.Next(1, 100);
            int zes = random.Next(1, 100);
            int zeven = random.Next(1, 100);
            int acht = random.Next(1, 100);
            int negen = random.Next(1, 100);
            int tien = random.Next(1, 100);

            int[] array1 = { een, twee, drie, vier, vijf, zes, zeven, acht, negen, tien };

            int sum1 = array1.Sum();


            int m = array1.Max();

            int p = array1.Min();

            int gemiddeld = (sum1 / 10);

            Console.WriteLine("getal 1 is " + een);
            Console.WriteLine("getal 2 is " + twee);
            Console.WriteLine("getal 3 is " + drie);
            Console.WriteLine("getal 4 is " + vier);
            Console.WriteLine("getal 5 is " + vijf);
            Console.WriteLine("getal 6 is " + zes);
            Console.WriteLine("getal 7 is " + zeven);
            Console.WriteLine("getal 8 is " + acht);
            Console.WriteLine("getal 9 is " + negen);
            Console.WriteLine("getal 10 is " + tien);

            Console.WriteLine();
            Console.WriteLine("De som van de tien cijfers is " + sum1);

            Console.WriteLine();
            Console.WriteLine("het hoogste cijfer in de array is " + m);

            Console.WriteLine();
            Console.WriteLine("het laagste cijfer in de array is " + p);

            Console.WriteLine();
            Console.WriteLine("het gemiddelde cijfer van alles is " + gemiddeld);
            Console.ReadKey();
        }
    }
}
