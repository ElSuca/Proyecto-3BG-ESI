namespace ApiPublicidad
{
    public class AddManager
    {
        
        public string GetBanner(int Banner)
        {
            return @"C:\Users\alumno\Desktop\Proyecto-3BG-ESI-Apis\PROGRAMACIÓN\Cache\" + Banner + ".jpg";
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
