using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opdracht6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime NuTijd = DateTime.Now; //Tijd van nu
                string Tijd = NuTijd.ToString("HH : mm : ss");
                Tijd = Figgle.FiggleFonts.Moscow.Render(" " + Tijd + " ");//Doormiddel van de package de tijd laten zien
                Console.WriteLine(Tijd.Replace("#", "*")); //# veranderen naar *
                Thread.Sleep(1000);//1 seconde wachten op de volgende seconde
                Console.Clear();
                Geluid(NuTijd);//functie hieronder aanroepen
            }
        }
        static void Geluid(DateTime NuTijd)
        {
            int seconds = NuTijd.Second;//Seconden en minuten aaroepen van de daytime
            int minutes = NuTijd.Minute;
            if (seconds == 0 && minutes == 0)//Wanneer Seconden en minuten 0 zijn speel het geluid af
            {
                SoundPlayer Koekkklok = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/sfx/cuckoo_clock2_x.wav");
                Koekkklok.Play();

            }
        }
    }
}