using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            LegeRegels();
        }

        static void LegeRegels()
        {
            //
            Console.WriteLine("Hoeveel lege regels wilt u?");
            int aantalregels = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i < aantalregels; i++)
            {
                Console.WriteLine("");
            }
            Console.ReadKey();      

        }
    }
}
