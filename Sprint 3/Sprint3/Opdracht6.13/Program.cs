using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Opdracht6._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een dierengeluid");
            Console.WriteLine("1 = Dolfijn");
            Console.WriteLine("2 = Hond");
            Console.WriteLine("3 = Kip");
            Console.WriteLine("4 = Beer");
            Console.WriteLine("5 = Ezel");
            Console.WriteLine("6 = Paard");
            Console.WriteLine("7 = Geit");
            Console.WriteLine("8 = Varken");
            Console.WriteLine("9 = Schaap");
            Console.WriteLine("10 = Walvis");
            int input = Convert.ToInt16(Console.ReadLine());


            PlayAnimalSound(input);
        }

        static void PlayAnimalSound(int input)
        {

            if (input == 1)
            {
                SoundPlayer Dolfijn = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/dolphin.wav");
                Dolfijn.Play();
            }
            if (input == 2)
            {
                SoundPlayer Hond = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/dog_bark6.wav");
                Hond.Play();
            }
            if (input == 3)
            {
                SoundPlayer Kip = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/chicken.wav");
                Kip.Play();
            }
            if (input == 4)
            {
                SoundPlayer Beer = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/bear_growl_y.wav%22");
                Beer.Play();
            }
            if (input == 5)
            {
                SoundPlayer Ezel = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/donkey_x.wav");
                Ezel.Play();
            }
            if (input == 6)
            {
                SoundPlayer Paard = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/horse.wav");
                Paard.Play();
            }
            if (input == 7)
            {
                SoundPlayer Geit = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/goat.wav");
                Geit.Play();
            }
            if (input == 8)
            {
                SoundPlayer Varken = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/pig.wav");
                Varken.Play();
            }
            if (input == 9)
            {
                SoundPlayer Schaap = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/sheep.wav");
                Schaap.Play();
            }
            if (input == 10)
            {
                SoundPlayer Walvis = new SoundPlayer("http://www.wavsource.com/snds_2018-06-03_5106726768923853/animals/whale.wav");
                Walvis.Play();
            }

        }
    }
}
