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
            
            GetInfo();
        }
        private void BannerPic_Click(object sender, EventArgs e)
        {   
            ApiPublicidad.AddManager f = new ApiPublicidad.AddManager();
            string link = f.SelectUrllink(selection);
            System.Diagnostics.Process.Start(link);
         }
        public void SetAnuncio()
        {
            ApiPublicidad.AddManager f = new ApiPublicidad.AddManager();
            BannerPic.Image = Image.FromFile(f.GetBanner(selection));
        }
        
        public void GetInfo ()
        {
            GetSportInfo e = new GetSportInfo();
            dataGridView1.DataSource= e.ejecutarComando();
        }

        private void UserInformationMenuItem_Click(object sender, EventArgs e)
        {
            UserData u = new UserData();
            u.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Console.Write(e);
        }
    }
}
       

       
    
