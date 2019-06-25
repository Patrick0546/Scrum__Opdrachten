using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double gemiddeldeNED, gemiddeldeENG, gemiddeldeWIS, gemiddeldePRG, gemiddeldeDBD, gemiddeldeALG;

            Console.WriteLine("Rapport cijfers");
            Console.ReadLine();

            Console.WriteLine("Wat is uw student nummer?");
            double studentnummer = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wat is uw voornaam & achternaam?");
            string naam= Convert.ToString(Console.ReadLine());

            //NEDERLANDS
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Nederlands? (NED)");
            double NED1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Nederlands? (NED)");

            double NED2 = Convert.ToDouble(Console.ReadLine());

            //ENGELS
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Engels? (ENG)");
            double ENG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Engels? (ENG)");
            double ENG2 = Convert.ToDouble(Console.ReadLine());

            //WISKUNDE
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Wiskunde? (WIS)");
            double WIS1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Wiskunde? (WIS)");
            double WIS2 = Convert.ToDouble(Console.ReadLine());

            //PROGRAMMEREN
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Programmeren? (PRG)");
            double PRG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Programmeren? (PRG)");
            double PRG2 = Convert.ToDouble(Console.ReadLine());

            //DBD
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Nederlands? (DBD)");
            double DBD1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Nederlands? (DBD)");
            double DBD2 = Convert.ToDouble(Console.ReadLine());

            //ALGEMEEN
            Console.WriteLine("Wat is uw eerste behaalde cijfer voor het vak Algemeen? (ALG)");
            double ALG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw tweede behaalde cijfer voor het vak Algemeen? (ALG)");
            double ALG2 = Convert.ToDouble(Console.ReadLine());
            
            //BEREKEN GEDEELTE
            //double g = Math.Round(gemiddeldeNED, gemiddeldeENG,  1);

            gemiddeldeNED = (NED1 + NED2) / 2;
            gemiddeldeENG = (ENG1 + ENG2) / 2;
            gemiddeldeWIS = (WIS1 + WIS2) / 2;
            gemiddeldePRG = (PRG1 + PRG2 + PRG2) /3;
            gemiddeldeDBD = (DBD1 + DBD2 + DBD2) /3;
            gemiddeldeALG = (ALG1 + ALG2 + ALG2) /3;

            //UTIVOER + CIJFERS
            Console.WriteLine("Rapport van");
            Console.WriteLine("Studentnummer: " + studentnummer);
            Console.WriteLine("Voor & achternaam: " + naam);
            Console.WriteLine("");
            Console.ReadKey();
            //NEDERLANDS
            Console.WriteLine("Uw ingevoerde informatie voor het vak Nederlands:" + NED1 + " " + NED2);
            Console.WriteLine("Uw ingevoerde cijfers " + NED1 + " " + NED2+ " wegen 1x mee ");
            Console.WriteLine("U staat voor het vak Nederlands een : " + gemiddeldeNED);
            Console.WriteLine("");
            Console.ReadKey();
            //ENGELS
            Console.WriteLine("Uw ingevoerde informatie voor het vak Engels:" + ENG1 + " " + ENG2);
            Console.WriteLine("Uw ingevoerde cijfers " + ENG1 + " " +ENG2 + " wegen 1x mee ");
            Console.WriteLine("U staat voor het vak Engels een: " + gemiddeldeENG);
            Console.WriteLine("");
            Console.ReadKey();
            //WISKUNDE
            Console.WriteLine("Uw ingevoerde informatie voor het vak Wiskunde:" + WIS1 + " " + WIS2);
            Console.WriteLine("Uw ingevoerde cijfers " + WIS1 + " " + WIS2 + " wegen 1x mee ");
            Console.WriteLine("U staat voor het vak Wiskunde een: " + gemiddeldeWIS);
            Console.WriteLine("");
            Console.ReadKey();
            //PROGRAMMEREN
            Console.WriteLine("Uw ingevoerde informatie voor het vak Programmeren:" + PRG1 + " " + PRG2);
            Console.WriteLine("Uw ingevoerde cijfer " + PRG1 + " weegt 1x mee ");
            Console.WriteLine("Uw ingevoerde cijfer " + PRG2 + " weegt 2x mee");
            Console.WriteLine("U staat voor het vak Programmeren een: " + gemiddeldePRG);
            Console.WriteLine("");
            Console.ReadKey();
            //DBD
            Console.WriteLine("Uw ingevoerde informatie voor het vak DBD:" + DBD1 + " " + DBD2);
            Console.WriteLine("Uw ingevoerde cijfer " + DBD1 + " weegt 1x mee ");
            Console.WriteLine("Uw ingevoerde cijfer " + DBD2 + " weegt 2x mee");
            Console.WriteLine("U staat voor het vak DBD een: " + gemiddeldeDBD);
            Console.WriteLine("");
            Console.ReadKey();
            //ALGEMEEN
            Console.WriteLine("Uw ingevoerde informatie voor het vak Algemeen:" + ALG1+  " " + ALG2);
            Console.WriteLine("Uw ingevoerde cijfer " + ALG1 + " weegt 1x mee");
            Console.WriteLine("Uw ingevoerde cijfer " + ALG2 + " weegt 2x mee ");
            Console.WriteLine("U staat voor het vak Algemeen een: " + gemiddeldeALG);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
