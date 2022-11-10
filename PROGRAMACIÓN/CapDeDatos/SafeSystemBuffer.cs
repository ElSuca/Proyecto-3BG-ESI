namespace CapDeDatos
{
    public class SafeSystemBuffer
    {
        public static string startPath { get; set; }
        public static int Language { get; set; }
        public static string Response { get; set; }

        public SafeSystemBuffer() => SetDefaultLanguage();

        public void SetDefaultLanguage()
        {
            if (Language > 1 && Language < 0) Language = 0;
        }
    }
}
