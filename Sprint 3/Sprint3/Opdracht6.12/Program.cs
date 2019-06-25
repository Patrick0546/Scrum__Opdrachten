using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef uw jaargetal in met de laatste 2 getalen van het jaar");
            int jaargetal = Int32.Parse(Console.ReadLine());

            Console.WriteLine("geef een datum op(in cijfers met / tussen de getallen)");
            string datum = Convert.ToString(Console.ReadLine());

            IsSchrikkeljaar();
            IsSchrikkeljaar(jaargetal);
            IsSchrikkeljaar(datum);
            Console.ReadKey();


        }
        public static void IsSchrikkeljaar()
        {
            bool t = true;
            DateTime moment = DateTime.Now;
            int jaar = moment.Year;
            if (jaar % 400 == 0 || jaar % 100 != 0 && jaar % 4 == 0)
            {
                t = true;
            }
            else
            {
                t = false;
            }

            if (t == true)
            {
                Console.WriteLine(jaar);
                Console.WriteLine("het is nu een schrikkeljaar");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(jaar);
                Console.WriteLine("het is nu geen schrikkeljaar");
                Console.ReadLine();

            }
        }
        public static void IsSchrikkeljaar(int jaargetal)
        {

            bool u = true;
            int jaar = 0;

            if (jaargetal > 50)
            {
                jaar = 1900 + jaargetal;
            }
            else
            {
                jaar = 2000 + jaargetal;
            }

            if (jaar % 400 == 0 || jaar % 100 != 0 && jaar % 4 == 0)
            {
                u = true;
            }
            else
            {
                u = false;
            }

            if (u == true)
            {
                Console.WriteLine(jaar);
                Console.WriteLine("het is nu een schrikkeljaar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(jaar);
                Console.WriteLine("het is nu geen schrikkeljaar");
                Console.ReadLine();
            }
        }
        public static void IsSchrikkeljaar(string datum)
        {

            DateTime _date = DateTime.Parse(datum);
            String day = _date.ToString("dd-MMM-yyyy");

            int result = DateTime.Parse(day).Year;
            bool y = true;
            if (result % 400 == 0 || result % 100 != 0 && result % 4 == 0)
            {
                y = true;
            }
            else
            {
                y = false;
            }

            if (y == true)
            {
                Console.WriteLine(result);
                Console.WriteLine("het is nu een schrikkeljaar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(result);
                Console.WriteLine("het is nu geen schrikkeljaar");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }

}
