using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileKezeles 
{
    class FileBeolvas
    {
        // Osztályszintű property
        static public List<Hegy> HegyLista = new List<Hegy>(); 

        // Példányszintű property
        public string FileNev { get; set; }
        
        // Konstruktor
        public FileBeolvas(string fileNev)
        {
            this.FileNev = fileNev;
        }

        public void Feltoltes(char delimiter)
        {
            string elsoSor = "";

            using (StreamReader sr = new StreamReader(this.FileNev, Encoding.UTF8))  
            {
                elsoSor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine().Trim();
                    string[] tomb = sor.Split(delimiter);
                    Hegy hegy = new Hegy(tomb[0], tomb[1], tomb[2]);
                    FileBeolvas.HegyLista.Add(hegy);
                }
            }
        }
    }
}