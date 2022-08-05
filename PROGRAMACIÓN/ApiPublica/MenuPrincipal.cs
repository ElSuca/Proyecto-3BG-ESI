using ApiPublica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class MenuPrincipal : Form
    {
        int selection = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
            ApiPublicidad.AddManager f = new ApiPublicidad.AddManager();
            int selection = f.getBanner();
            SetAnuncio(selection);
        }
        private void BannerPic_Click(object sender, EventArgs e)
        {
            string link = SelectUrllink(selection);
            System.Diagnostics.Process.Start(link);
        }
        public void SetAnuncio(int Bannerselect)
        {    
            selection = Bannerselect;
            BannerPic.Image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Deberes S\\2022\\Proyecto\\Proyecto-3BG-ESI\\PROGRAMACIÓN\\Cache\\" + selection + ".jpg");
        }
        public string SelectUrllink(int n)
        {
            string banner = "";
            if (selection == 0) banner = "https://www.fifa.com/es";
            else if (selection == 1) banner = "https://cuk-it.com/recetas/tortas-fritas/";
            else if (selection == 2) banner = "https://as.com/baloncesto/nba/";
            return banner;
        }

        private void UserInformationMenuItem_Click(object sender, EventArgs e)
        {
            UserData u = new UserData();
            u.Show();
        }
    }
}
       

       
    
