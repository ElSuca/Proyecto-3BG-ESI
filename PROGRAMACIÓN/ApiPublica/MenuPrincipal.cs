using ApiPublica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class MenuPrincipal : Form
    {
        int selection;

        public MenuPrincipal()
        {
            InitializeComponent();
            Random random = new Random();
            selection = random.Next(3);
            SetAnuncio();
        }
        private void BannerPic_Click(object sender, EventArgs e)
        {   
            string link = new ApiPublicidad.AddManager().SelectUrllink(selection);
            System.Diagnostics.Process.Start(link);
        }
        public void SetAnuncio()
        {
            ApiPublicidad.AddManager f = new ApiPublicidad.AddManager();
            BannerPic.Image = Image.FromFile(f.GetBanner(selection));
        }
        private void UserInformationMenuItem_Click(object sender, EventArgs e) => new UserData().Show();
    }
}
       

       
    
