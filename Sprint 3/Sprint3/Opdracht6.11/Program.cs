using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._11
{
    class NumberManipulator
    {
        public void getValues(out int x, out int y, out double plus, out double min, out double keer, out double gedeeld, out double Uitkomst)
        {
            Console.WriteLine("geef het eerste cijfer: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("geef het tweede cijfer: ");
            y = Convert.ToInt32(Console.ReadLine());

            plus = x + y;
            min = x - y;
            keer = x * y;
            gedeeld = x / y;
            Uitkomst = x % y;

        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();


            int x, y;
            double min, plus, keer, gedeeld, Uitkomst;



            n.getValues(out x, out y, out plus, out min, out keer, out gedeeld, out Uitkomst);

            Console.WriteLine("" + x + " plus " + y + " is : {0}", plus);
            Console.WriteLine("" + x + " min " + y + " is : {0}", min);
            Console.WriteLine("" + x + " keer " + y + " is : {0}", keer);
            Console.WriteLine("" + x + " gedeeld door " + y + " is : {0}", gedeeld);
            Console.WriteLine("" + x + " module door " + y + " is : {0}", Uitkomst);
            Console.ReadLine();
        }
    }
}