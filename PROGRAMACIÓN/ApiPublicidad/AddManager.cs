using System;
using System.IO;

namespace ApiPublicidad
{
    public class AddManager
    {
        
        public string GetBanner(int Banner)
        {
            string finalpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Olympus\Cache\" + Banner + ".jpg";
            string file = Banner + ".jpg";
            Moveplaceholders(finalpath,file);
            return finalpath;
        }

        public void Moveplaceholders(string finalpath,string file)
        {
           string basepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Olympus\Cache\";
            string startpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\Proyecto-3BG-ESI\PROGRAMACIÓN\Cache\" + file; 
            if (!Directory.Exists(basepath)) CreateDirectory();
            if(!File.Exists(finalpath)) File.Copy(startpath, finalpath);
        }

        private void CreateDirectory()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Olympus\Cache";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }
        public string SelectUrllink(int choice)
        {
            string banner = "";
            if (choice == 0) banner = "https://www.fifa.com/es";
            else if (choice == 1) banner = "https://cuk-it.com/recetas/tortas-fritas/";
            else if (choice == 2) banner = "https://as.com/baloncesto/nba/";
            return banner;
        }
    }
}
