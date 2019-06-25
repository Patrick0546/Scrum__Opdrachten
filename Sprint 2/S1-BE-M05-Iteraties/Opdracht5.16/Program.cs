using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
static class StringHelper
{
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
namespace Opdracht5_16
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Voer een tekst in");
            string invoer = Convert.ToString(Console.ReadLine());
            Console.WriteLine(StringHelper.ReverseString(invoer));

            Console.ReadKey();
        }
    }
}
