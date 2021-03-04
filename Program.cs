using System;
using System.Collections.Generic;

namespace FileKezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            FileBeolvas fileHegy = new FileBeolvas("hegyekMo.txt"); 
            List<Hegy> hegyLista = Hegy.ListaFeltoltes(fileHegy.Feltoltes(';'));

            Console.WriteLine($"3. feladat: Hegycsúcsok száma: {hegyLista.Count} db");

            double atlagMagassag = (double) Hegy.osszMagassag / hegyLista.Count;
            Console.WriteLine($"4. feladat: A hegycsúcsok átlagos magassága: {atlagMagassag:F2} m");

            Hegy legmagasabb = Hegy.LegmagasabbHegy;
            Console.WriteLine($"5. feladat: A legmagasabb hegycsúcs adatai: ");
            Console.WriteLine($"\tNév: {legmagasabb.HegycsucsNeve}");
            Console.WriteLine($"\tHegység: {legmagasabb.Hegyseg}");
            Console.WriteLine($"\tMagasság: {legmagasabb.Magassag} m");

            Console.Write("6. feladat: Kérek egy magasságot: ");
            int bekertMagassag = Int32.Parse(Console.ReadLine());
            bool vanE = false;

            foreach (Hegy elem in hegyLista)
            {
                if (elem.Hegyseg == "Börzsöny" && elem.Magassag > bekertMagassag)
                {
                    vanE = true;
                    break;
                }
            }

            if (vanE)
            {
                Console.WriteLine($"\tVan {bekertMagassag}m-nél magasabb hegycsúcs a Börzsönyben.");
            }
            else
            {
                Console.WriteLine($"\tNincs {bekertMagassag}m-nél magasabb hegycsúcs a Börzsönyben.");

            }

            Console.WriteLine($"7. feladat: 3000 lábnál magasabb hegycsúcsok száma: {Hegy.haromEzerLab}");

            Console.WriteLine("8. feladat: Hegység statisztika");
            Dictionary<string, int> statisztika = Hegy.statisztika;
            foreach(KeyValuePair<string, int> elem in statisztika)
            {
                Console.WriteLine($"\t{elem.Key} - {elem.Value} db");
            }

            Console.WriteLine("9. feladat: bukk-videk.txt");

            string kiir = "Hegycsúcs neve;Magasság láb";

            foreach (Hegy elem in hegyLista)
            {
                if (elem.Hegyseg == "Bükk-vidék")
                {
                    kiir += $"\n{elem.HegycsucsNeve};";
                    double lMagassag = elem.Magassag * 3.280839895;
                    
                    string magas = lMagassag.ToString("F1").Replace(",",".").Replace(".0","");
                    kiir += magas;
                }
            }

            FilebaKiir bukkText = new FilebaKiir("bukk-videk.txt");
            bukkText.Kiiras(kiir);
        }
    }
}
