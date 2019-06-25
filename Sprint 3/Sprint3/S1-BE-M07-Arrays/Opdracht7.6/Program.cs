using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int Random = random.Next(10, 100);


            int[] Randomgetallen = new int[] { random.Next(10, 100), random.Next(10, 100), random.Next(10, 100), random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),
                random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),
                random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),random.Next(10, 100),
                random.Next(10, 100),random.Next(10, 100),random.Next(10, 100) };

            Console.WriteLine("Hier zijn 25 RANDOM getallen : ");
            foreach (int currentNumber in Randomgetallen)
            {
                Console.Write(currentNumber + " ");
            }

            Array.Reverse(Randomgetallen);

            Console.WriteLine("Omgedraaid : ");

            foreach (int currentNumber in Randomgetallen)
            {
                Console.Write(currentNumber + " ");
            }

            Console.ReadLine();


        }
    }
}
