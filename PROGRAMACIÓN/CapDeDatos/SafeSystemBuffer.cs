using System;

namespace CapDeDatos
{
    public class SafeSystemBuffer
    {
        public static string startPath { get; set; }
        public static int Language { get; set; }
        public static string Response { get; set; }
        public static string[] ResponseArray { get; set; }
        public int PageNumber { get; set; }
        public int SportId { get; set; }
        public int Id { get; set; }

        public int IdPlayer { get; set; }
        public int PageNumberPlayer { get; set; }
        public string SearchBarContent { get; set; }


        public int IdMain { get; set; }
        public int PageNumberMain { get; set; }
        public int SportMain { get; set; }

        public SafeSystemBuffer() => SetDefaultLanguage();

        public void SetDefaultLanguage()
        {
            if (Language > 1 && Language < 0) Language = 0;
        }
    }
}
