using System;

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

    }
}