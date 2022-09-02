using ApiPublica;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLogica;
using CapaLoogica;
using CapDeDatos;

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
            dataGridView1.DataSource = new SportControler().GetSimpifiedEventData();
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
            Console.Write(e);
        }

        private void btnBusqueda_Click(object sender, EventArgs e) => dataGridView1.DataSource = new SportControler().GetEventData(txtBusqueda.Text);

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new SportControler().GetSimpifiedEventData();
        }
    }
}
       

       
    
