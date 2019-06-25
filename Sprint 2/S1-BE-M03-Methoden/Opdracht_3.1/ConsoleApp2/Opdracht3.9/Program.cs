using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw geboortedag op in cijfers. DD ");
            string GDatumDag = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Geef uw geboortemaand op in cijfers MM ");
            int GDatumMaand = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Geef uw geboortejaar op in cijfers JJJJ ");
            int GDatumJaar = Convert.ToInt16(Console.ReadLine());

            int jaar = GDatumJaar;
            int maand = GDatumMaand;
            int dagen = DateTime.DaysInMonth(jaar, maand);

            if (29 > dagen)
            {
                Console.WriteLine("De hoeveelheid dagen die in de " + maand  + "e maand zitten zijn 29 dagen!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("De hoeveelheid dagen die in de " + maand + "e maand zitten zijn " + dagen + " dagen!");
                Console.ReadLine();
            }
        }
    }
}
