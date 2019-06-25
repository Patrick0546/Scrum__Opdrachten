using System;

namespace Opdracht2._2
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Voer uw gewicht in (KG): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Voer uw lengte in (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (height * height);
            Console.WriteLine("Je BMI is" + BMI);
            Console.ReadKey();
        }
    }
}
