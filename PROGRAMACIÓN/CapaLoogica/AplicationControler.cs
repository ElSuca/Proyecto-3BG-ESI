using CapDeDatos;

namespace CapaLoogica
{
    public class AplicationControler
    {
        public void setLanguage(int l) => new SafeSystemBuffer().SetLanguage(l);
        public int getLanguage() => new SafeSystemBuffer().GetLanguage();

        public string getResponse() => new SafeSystemBuffer().GetResponse();
        public string getApiAuPath() => SafeSystemBuffer.ApiAutentificationPath;
    }
}
