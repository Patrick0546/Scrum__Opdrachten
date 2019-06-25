using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8._5
{
    class Program

    {

        static Random r = new Random();

        static void Main(string[] args)

        {

            for (int i = 0; i < 100; i++)

            {

                long getal0 = r.Next(int.MaxValue);

                long getal1 = r.Next(int.MaxValue);

                long product = getal0 + getal1;

                Console.WriteLine("{0} * {1} = {2}", getal0, getal1, product);

            }

            Console.ReadKey();

        }

    }

}