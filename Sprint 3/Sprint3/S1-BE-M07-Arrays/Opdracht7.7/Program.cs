using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int een = 0;
            int twee = 0;
            int drie = 0;
            int vier = 0;
            int vijf = 0;
            int zes = 0;
            int zeven = 0;
            int acht = 0;
            int negen = 0;
            int tien = 0;

            Console.WriteLine("geef het eerste cijfer: ");
            een = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het tweede cijfer: ");
            twee = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het derde cijfer: ");
            drie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het vierde cijfer: ");
            vier = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het vijfde cijfer: ");
            vijf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het zesde cijfer: ");
            zes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het zevende cijfer: ");
            zeven = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het achtste cijfer: ");
            acht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het negende cijfer: ");
            negen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het tiende cijfer: ");
            tien = Convert.ToInt32(Console.ReadLine());

            int[] array1 = { een, twee, drie, vier, vijf, zes, zeven, acht, negen, tien };

            int sum1 = array1.Sum();

            Console.WriteLine();
            Console.WriteLine("De som van de tien cijfers is " + sum1);

            Console.ReadKey();
        }
    }
}

