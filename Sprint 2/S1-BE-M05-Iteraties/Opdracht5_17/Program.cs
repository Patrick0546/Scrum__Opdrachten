using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw tekst in.");
            var input = Console.ReadLine().ToLower();
            var output = "";

            char temp = '0';
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    temp = input[i];
                    output += temp;
                    input = input.Remove(i, 1);
                    i--;
                }
                else if ((i % 2) != 0)
                {
                    temp = char.ToUpper(input[i]);
                    output += temp;
                }
                else
                {
                    temp = input[i];
                    output += temp;
                }
            }
            Console.Write(output);
            Console.ReadKey();
        }
    }
}
