using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._9
{
    class Program
    {
        static void Main(string[] args)
        {

            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "Wout Oldenhof (0310069) 22-05-2001 Nijverdal", "Patrick Koekkoek (studentennummer) (geboortejaar) (geboorteplaats)" }, { "Cas Schuurman (studentennummer) (geboortejaar) (geboorteplaats)", "Bart Haarhuis (studentennummer) (geboortejaar) (geboorteplaats)" }, { "Martijn Legtenberg (leerlingnummer) (geboortedatum) (geboorteplaats)", "(naam) (achternaam) (leerlingenummer) (geboortedatum) (geboorteplaats)" } };
            Console.WriteLine(array2Db[0, 0]);
            Console.WriteLine(array2Db[0, 1]);
            Console.WriteLine(array2Db[1, 0]);
            Console.WriteLine(array2Db[1, 1]);
            Console.WriteLine(array2Db[2, 0]);
            Console.WriteLine(array2Db[2, 1]);

            Console.ReadKey();
        }
    }
}
