using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int telleroneven = 0;
            int tellereven = 0;
            int[] oneven = new int[25];
            int[] even = new int[25];
            int[] array = new int[25];

            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                int getal = rnd.Next(1, 10000);
                array[i] = getal;
                if ((array[i] % 2) == 0)
                {
                    even[tellereven] = array[i];
                    tellereven++;
                }
                else
                {
                    oneven[telleroneven] = array[i];
                    telleroneven++;
                }
            }
            for (int i = 0; i < 25; i++)
            {
                if (i <= tellereven)
                {
                    Console.WriteLine(even[i]);
                    Console.ReadLine();
                }

            }
            for (int i = 0; i < 25; i++)
            {
                if (i <= telleroneven)
                {
                    Console.WriteLine(oneven[i]);
                    Console.ReadLine();
                }

            }
        }
    }
}