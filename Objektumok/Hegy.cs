using System;
using System.Collections.Generic;

namespace FileKezeles
{
    public class Hegy 
    {
        // Példányszintű property-k.
        public string HegycsucsNeve { get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        // Teljes konstruktor
        public Hegy(string hegycsucsNeve, string hegyseg, string magassag)
        {
            this.HegycsucsNeve = hegycsucsNeve;
            this.Hegyseg = hegyseg;
            this.Magassag = Int32.Parse(magassag);
        }

        static public List<Hegy> ListaFeltoltes(List<string[]> lista)
        {
            List<Hegy> listaH = new List<Hegy>();

            for (int i = 0; i < lista.Count; i++) 
            {
                Hegy hegy = new Hegy(lista[i][0], lista[i][1], lista[i][2]);
                listaH.Add(hegy);
            }

            return listaH;
        }
    }
}