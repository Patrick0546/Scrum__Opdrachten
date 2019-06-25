using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul je eerste cijfer in...");//De cijfers invoeren
            int EersteCijfer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul je tweede cijfer in...");
            int TweedeCijfer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul je derde cijfer in...");
            int DerdeCijfer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul je vierde cijfer in...");
            int VierdeCijfer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul je vijfde cijfer in...");
            int VijfdeCijfer = Convert.ToInt32(Console.ReadLine());

            Int32[] value;
            value = new Int32[5];

            value[0] = EersteCijfer;//De cijfers door middel van een array
            value[1] = TweedeCijfer;
            value[2] = DerdeCijfer;
            value[3] = VierdeCijfer;
            value[4] = VijfdeCijfer;

            Console.WriteLine("------------------------------------------------------");//De cijfers op volgorde laten zien
            Console.WriteLine("Het eerste cijfer is: " + value[0]);
            Console.WriteLine("Het tweede cijfer is: " + value[1]);
            Console.WriteLine("Het derde  cijfer is: " + value[2]);
            Console.WriteLine("Het vierde cijfer is: " + value[3]);
            Console.WriteLine("Het vijfde cijfer is: " + value[4]);
            Console.ReadKey();
        }
    }
}