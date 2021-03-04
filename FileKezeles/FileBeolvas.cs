using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileKezeles 
{
    class FileBeolvas
    { 
        // Osztályszintű mező
        static string File = "";
        
        // Konstruktor
        public FileBeolvas(string fileNev)
        {
            FileBeolvas.File = fileNev;
        }

        static public List<string[]> Feltoltes(char delimiter)
        {
            string elsoSor = "";
            List<string[]> lista = new List<string[]>();

            using (StreamReader sr = new StreamReader(FileBeolvas.File, Encoding.UTF8))  
            {
                elsoSor = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine().Trim();
                    string[] tomb = sor.Split(delimiter);
                    lista.Add(tomb);
                }
            }

            return lista;
        }
    }
}