using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var antwoord = 0;
            int intTeller;

            for (intTeller = 0; intTeller < 26; intTeller++)
            {
                antwoord = intTeller * intTeller;

                Console.Write( intTeller + "  " + antwoord);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}