using CapDeDatos;
using System;
using System.IO;

namespace CapaLoogica
{
    public class AplicationControler
    {
        public void setLanguage(int l) => SafeSystemBuffer.Language = l;
        public string getResponse() => SafeSystemBuffer.Response;

        public int getLanguage()
        {
            int selection;
            using (StreamReader archivo = File.OpenText("..\\..\\..\\Config.txt"))
            {
                string linea = null;
                int i = 0;
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    if (++i == 2) break;
                }
                selection = Int32.Parse(linea[11].ToString());
            }
            return selection;
        }
    }
}
