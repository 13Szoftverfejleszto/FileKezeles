using System;
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
            List<Hegy> lista = Hegy.ListaFeltoltes(FileBeolvas.Feltoltes(';'));

            Console.WriteLine(lista.Count);
        }
    }
}
