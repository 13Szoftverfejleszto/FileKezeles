using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileKezeles 
{
    class FileBeolvas
    { 
        public string File { get; set; }   
        
        public FileBeolvas(string fileNev)
        {
            this.File = fileNev;
        }

        public List<string[]> Feltoltes(char delimiter)
        {
            string elsoSor = "";
            List<string[]> lista = new List<string[]>();

            using (StreamReader sr = new StreamReader(this.File, Encoding.UTF8))  
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