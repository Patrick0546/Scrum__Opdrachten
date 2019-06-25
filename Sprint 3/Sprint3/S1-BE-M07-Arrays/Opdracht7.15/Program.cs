using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7._15
{
    class Program
    {

        static void Main(string[] args)
        {
            Goedecode();
        }

        private static void Goedecode()
        {
            Console.WriteLine("Geef uw 11 cijferige code in");//Code ingeven
            string Code = Convert.ToString(Console.ReadLine());

            string[] TekensDieNietMogen = { "i", "o", "I", "O" };//Tekens die niet mogen in een string
            int[] Nummers = { 1, 0 };//Nummers die niet mogen in een int
            bool GOFO = true;//Boolean voor het aangeven van juist of onjuist

            foreach (var item in TekensDieNietMogen)
            {
                if (Code.Contains(item) || (Code.Length != 11))//Wanneer er een teken in staat of de code niet 11 lang is
                {
                    Console.WriteLine("De ingevulde code is onjuist!");
                    GOFO = false;//Bool naar false
                    break;
                }
            }
            foreach (var item2 in Nummers)
            {
                if (Code.Contains(item2.ToString()) || (Code.Length != 11))// Wanneer er een cijfer in staat of de code niet 11 lang is
                {
                    Console.WriteLine("De ingevulde code is onjuist!");
                    GOFO = false;//bool naar false
                    break;
                }
            }
            if (GOFO == true)//Wanneer de bool op true blijft staan doe dit
            {
                Console.WriteLine("De ingevulde code is juist!");
            }
            Console.ReadKey();
        }
    }
}
