using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._8
{
    class Program
    {
        public static void Main(string[] args)
        {

            string text;

            do
            {
                Console.Clear();
                Console.WriteLine("Voer meerdere getallen in");
                string input = Console.ReadLine();
                text = SomCijfers(input);
            } while (text == "Geen geldige getallen ingevoerd, voer alleen getallen in!");
            Console.Write(text);
            Console.ReadLine();
        }

        private static string SomCijfers(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 47 || input[i] > 57)
                {
                    return "Geen geldige getallen ingevoerd, voer alleen getallen in!";
                }
            }

            int som = 0;
            string optelling = "";
            for (int i = 0; i < input.Length; i++)
            {

                char x = input[i];
                som = som + Convert.ToInt32(x.ToString());


                if (i < input.Length - 1)
                {
                    optelling += input[i] + " + ";
                }
                else
                    optelling += input[i] + " = ";
            }
            return optelling + som.ToString();
        }
    }
}