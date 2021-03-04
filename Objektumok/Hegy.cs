using System;
using System.Collections.Generic;

namespace FileKezeles
{
    public class Hegy 
    {
        // Osztályszintű mezők
        static public int osszMagassag = 0;
        static public int legMagasabb = 0;
        static public Hegy LegmagasabbHegy = new Hegy();
        static double labMagassag = 3000 / 3.280839895;
        static public int haromEzerLab = 0;
        static public Dictionary<string, int> statisztika = new Dictionary<string, int>();

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
            Hegy.osszMagassag += this.Magassag;

            this.LegmagasabbHegySzamol();
            this.HaromEzerLabSzamolas(); 
            this.StatiszkaGyartas();         
        }

        public Hegy()
        {

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

        public void LegmagasabbHegySzamol()
        {
            if (this.Magassag > Hegy.legMagasabb) 
            {
                Hegy.legMagasabb = this.Magassag;
                Hegy.LegmagasabbHegy = this;
            }
        }

        public void HaromEzerLabSzamolas()
        {
            if (this.Magassag > Hegy.labMagassag)
            {
                Hegy.haromEzerLab++;
            }
        }

        public void StatiszkaGyartas()
        {
            bool vanE = true;

            foreach (KeyValuePair<string, int> elem in statisztika)
            {
                if (this.Hegyseg == elem.Key) 
                {
                    vanE = false;
                    int adat = elem.Value;
                    statisztika.Remove(elem.Key);
                    statisztika.Add(this.Hegyseg, ++adat);
                    break;
                }
            }

            if (vanE)
            {
                statisztika.Add(this.Hegyseg, 1);
            }
        }
    }
}