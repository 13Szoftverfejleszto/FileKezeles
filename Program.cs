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

            string beolvasFile = "hegyekMo.txt";
            FileBeolvas fileHegy = new FileBeolvas(beolvasFile); 

            fileHegy.Feltoltes(';');
            Console.WriteLine(FileBeolvas.HegyLista.Count);
        }
    }
}
