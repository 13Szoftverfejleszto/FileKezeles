using System.IO;
using System.Text;

namespace FileKezeles
{
    class FilebaKiir
    {
        public string File { get; set; }

        public FilebaKiir(string file)
        {
            this.File = file;
        }

        public void Kiiras(string kiir)
        {
            using (StreamWriter sw = new StreamWriter(this.File, false, Encoding.UTF8))
            {
                sw.Write(kiir);
            }
        } 
    }
}