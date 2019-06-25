using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            double GemiddeldeStudent1, GemiddeldeStudent2, GemiddeldeStudent3, GemiddeldeStudent4, GemiddeldeStudent5;

            //STUDENT1
            Console.WriteLine("Wat is uw naam student 1?");
            string NaamStudent1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw Rekencijfer student 1?");
            double RekenenStudent1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Nederlandscijfer student 1?");
            double NederlandsStudent1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Engelscijfer student 1?");
            double EngelsStudent1 = Convert.ToDouble(Console.ReadLine());


            //STUDENT 2
            Console.WriteLine("Wat is uw naam student 2?");
            string NaamStudent2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw Rekencijfer student 2?");
            double RekenenStudent2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Nederlandscijfer student 2?");
            double NederlandsStudent2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Engelscijfer student 2?");
            double EngelsStudent2 = Convert.ToDouble(Console.ReadLine());

            //STUDENT3
            Console.WriteLine("Wat is uw naam student 3?");
            string NaamStudent3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw Rekencijfer student 3?");
            double RekenenStudent3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Nederlandscijfer student 3?");
            double NederlandsStudent3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Engelscijfer student 3?");
            double EngelsStudent3 = Convert.ToDouble(Console.ReadLine());

            //STUDENT4
            Console.WriteLine("Wat is uw naam student 4?");
            string NaamStudent4 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw Rekencijfer student 4?");
            double RekenenStudent4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Nederlandscijfer student 4?");
            double NederlandsStudent4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Engelscijfer student 4?");
            double EngelsStudent4 = Convert.ToDouble(Console.ReadLine());

            //STUDENT5
            Console.WriteLine("Wat is uw naam student 5?");
            string NaamStudent5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw Rekencijfer student 5?");
            double RekenenStudent5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Nederlandscijfer student 5?");
            double NederlandsStudent5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is uw Engelscijfer student 5?");
            double EngelsStudent5 = Convert.ToDouble(Console.ReadLine());

            string[] StudentNamen = { NaamStudent1 , NaamStudent2 , NaamStudent3 , NaamStudent4 , NaamStudent5 };
            double[,] array2Db = new double[5, 3] { { RekenenStudent1 , NederlandsStudent1 , EngelsStudent1  }, { RekenenStudent2, NederlandsStudent2, EngelsStudent2 } ,{RekenenStudent3 ,NederlandsStudent3 ,EngelsStudent3 }, { RekenenStudent4, NederlandsStudent4, EngelsStudent4 },{ RekenenStudent5 , NederlandsStudent5 ,EngelsStudent5 } };

            //GEMIDDELDE BEREKENEN
            GemiddeldeStudent1 = (RekenenStudent1 + RekenenStudent1 + NederlandsStudent1 + EngelsStudent1) / 4;
            GemiddeldeStudent2 = (RekenenStudent2 + RekenenStudent2 + NederlandsStudent2 + EngelsStudent2) / 4;
            GemiddeldeStudent3 = (RekenenStudent3 + RekenenStudent3 + NederlandsStudent3 + EngelsStudent3) / 4;
            GemiddeldeStudent4 = (RekenenStudent4 + RekenenStudent4 + NederlandsStudent4 + EngelsStudent4) / 4;
            GemiddeldeStudent5 = (RekenenStudent5 + RekenenStudent5 + NederlandsStudent5 + EngelsStudent5) / 4;

            //RAPPORT STUDENT1
            Console.WriteLine(NaamStudent1);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nederlands (weging1) :" + array2Db[0, 0]);
            Console.WriteLine();
            Console.WriteLine("Engels     (weging1) :" + array2Db[0, 1]);
            Console.WriteLine();
            Console.WriteLine("Rekenen    (weging2) :" + array2Db[0, 2]);
            Console.WriteLine();
            if (GemiddeldeStudent1 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent1);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Gemiddeld: " + GemiddeldeStudent1);
            }
            Console.WriteLine();
            
            //RAPPORT STUDENT2
            Console.WriteLine(NaamStudent2);
            Console.WriteLine();
            Console.WriteLine();
            if (GemiddeldeStudent2 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent2);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Nederlands (weging1) :" + array2Db[1, 0]);
            }
            Console.WriteLine("");
            Console.WriteLine("Nederlands (weging1) :" + array2Db[1, 0]);
            Console.WriteLine();
            Console.WriteLine("Engels     (weging1) :" + array2Db[1, 1]);
            Console.WriteLine();
            Console.WriteLine("Rekenen    (weging2) :" + array2Db[1, 2]);
            Console.WriteLine();
            if (GemiddeldeStudent2 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent2);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Gemiddeld: " + GemiddeldeStudent2);
            }
            Console.WriteLine("");

            //RAPPORT STUDENT3
            Console.WriteLine(NaamStudent3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nederlands (weging1) :" + array2Db[2, 0]);
            Console.WriteLine();
            Console.WriteLine("Engels     (weging1) :" + array2Db[2, 1]);
            Console.WriteLine();
            Console.WriteLine("Rekenen    (weging2) :" + array2Db[2, 2]);
            Console.WriteLine();
            if (GemiddeldeStudent3 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent3);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Gemiddeld: " + GemiddeldeStudent3);
            }
            Console.WriteLine();

            //RAPPORT STUDENT4
            Console.WriteLine(NaamStudent4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nederlands (weging1) :" + array2Db[3, 0]);
            Console.WriteLine();
            Console.WriteLine("Engels     (weging1) :" + array2Db[3, 1]);
            Console.WriteLine();
            Console.WriteLine("Rekenen    (weging2) :" + array2Db[3, 2]);
            Console.WriteLine();
            if (GemiddeldeStudent4 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent4);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Gemiddeld: " + GemiddeldeStudent4);
            }
            Console.WriteLine();

            //RAPPORT STUDENT5
            Console.WriteLine(NaamStudent5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nederlands (weging1) :" + array2Db[4, 0]);
            Console.WriteLine();
            Console.WriteLine("Engels     (weging1) :" + array2Db[4, 1]);
            Console.WriteLine();
            Console.WriteLine("Rekenen    (weging2) :" + array2Db[4, 2]);
            Console.WriteLine();
            if (GemiddeldeStudent2 < 5.5)
            {
                Console.WriteLine("Gemiddeld: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(GemiddeldeStudent5);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Gemiddeld: " + GemiddeldeStudent5);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
