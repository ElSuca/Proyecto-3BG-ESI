using CapDeDatos;
using System;
using System.IO;

namespace CapaLoogica
{
    public class AplicationControler
    {
        public void setLanguage(int l) => new SafeSystemBuffer().SetLanguage(l);
        //public int getLanguage() => new SafeSystemBuffer().GetLanguage();

        public string getResponse() => new SafeSystemBuffer().GetResponse();
        public string getApiAuPath() => SafeSystemBuffer.ApiAutentificationPath;

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
                selection = Int32.Parse(linea[10].ToString());
            }
            return selection;
        }
    }
}
