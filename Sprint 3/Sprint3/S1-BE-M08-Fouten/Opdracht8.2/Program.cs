using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8._2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Geef uw geboortedag op in cijfers: ");
            string GDatumDag = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Geef uw geboortemaand op in cijfers: ");
            int GDatumMaand = Convert.ToInt16(Console.ReadLine());
            if (GDatumMaand > 12)
            {
                Console.WriteLine("Geef een geldige datum");
                Console.WriteLine("Druk op een toets om af te sluiten...");
                Console.ReadLine();
                System.Environment.Exit(0);

            }
            Console.WriteLine("Geef uw geboortejaar op in cijfers: ");
            int GDatumJaar = Convert.ToInt16(Console.ReadLine());

            int year = GDatumJaar;
            int month = GDatumMaand;
            int days = DateTime.DaysInMonth(year, month);

            Console.WriteLine("er zitten " + days + " dagen in de maand " + month + "");
            Console.ReadLine();
        }
    }
}