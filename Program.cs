using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace FileKezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string beolvasFile = @"D:\JavaScript\Online_Tanitas\SOB\13SZFT\Asztali alkalmazasok\FileKezeles\hegyekMo.txt";
            string elsoSor = "";
            List<Hegy> hegyLista = new List<Hegy>();

            using (StreamReader sr = new StreamReader(beolvasFile, Encoding.UTF8))
            {
                elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    // Trim() eltávolítja a sor végeiről a whitespace: \t,\n,' ', " "
                    string sor = sr.ReadLine().Trim();
                    string[] tomb = sor.Split(';');
                    string hegycsucsNeve = tomb[0];
                    string hegyseg = tomb[1];
                    int magassag = Int32.Parse(tomb[2]);
                    Hegy hegy = new Hegy(hegycsucsNeve, hegyseg, magassag);
                    hegyLista.Add(hegy);
                }
            }

            Console.WriteLine(elsoSor);
        }
    }
}
