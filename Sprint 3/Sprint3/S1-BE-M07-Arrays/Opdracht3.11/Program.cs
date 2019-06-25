
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._11
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];//De lengte van de arrays aanpassen
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Random number = new Random();

            for (int i = 0; i < 10; i++)
            {
                array1[i] = number.Next(10, 99);//Random nummers genereren van 10 tot 100
                array2[i] = number.Next(10, 99);
            }

            for (int i = 0; i < 10; i++)
            {
                array3[i] = array1[i] + array2[i]; //Array1 + array 2
            }

            string eersteArray = string.Join(" ", array1);//Laten zien van de arrays in de text
            Console.WriteLine("De eerste 10 random getallen zijn: " + eersteArray + "");
            string tweedeArray = string.Join(" ", array2);
            Console.WriteLine("De tweede 10 random getallen zijn: " + tweedeArray + "");
            string derdeArray = string.Join(" ", array3);
            Console.WriteLine("1e + 2e =                        " + derdeArray + "");
            Console.ReadKey();



        }

    }
}