namespace CapDeDatos
{
    public class SafeSystemBuffer
    {
        public static int Menu1Choice;
        public static string startPath;
        public static int Language;
        public static string Response ;
        public static string ApiAutentificationPath { get; set; }

        public SafeSystemBuffer()
        {
            SetDefaultLanguage();
        }

        public void SetDefaultLanguage()
        {
            if (Language > 1 && Language < 0) Language = 0;
        }

        public int GetMenu1Choice() => Menu1Choice;


        public void SetMenu1Choice(int a) => Menu1Choice = a;
        public void SetStartAdPath(string p) => startPath = p;

        public int GetLanguage() => Language;
        public void SetLanguage(int l) => Language = l;

        public string GetResponse() => Response;
        public void SetResponse (string l) => Response = l;
    }
}
