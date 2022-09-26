using ApiPublica;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaLoogica;

namespace Proyecto
{
    public partial class MenuPrincipal : Form
    {
     
        int selection;
        public MenuPrincipal()
        {
            InitializeComponent(); 
            selection = new Random().Next(3);
            GetInfo();
            SearchEventMenuToggle(false);
        }
        private void BannerPic_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(new ApiPublicidad.AddManager().SelectUrllink(selection));

        public void SetAnuncio() => BannerPic.Image = Image.FromFile(new ApiPublicidad.AddManager().GetBanner(selection));

        public void GetInfo() => dataGridView1.DataSource = new SportControler().GetSimpifiedEventData();

        private void UserInformationMenuItem_Click(object sender, EventArgs e) => new UserData().Show();

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) => Console.Write(e);

        private void btnBusqueda_Click(object sender, EventArgs e) => dataGridView1.DataSource = new SportControler().GetEventData(txtBusquedaEvento.Text);

        private void MenuPrincipal_Load(object sender, EventArgs e){}

        private void btnBack_Click(object sender, EventArgs e) => dataGridView1.DataSource = new SportControler().GetSimpifiedEventData();

        private void btnBusquedaJugador_Click(object sender, EventArgs e) => dataGridView1.DataSource = new SportControler().GetPlayerData(txtBusquedaJugador.Text);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool n = !panelMenuSearch.Visible ? true: false;
            SearchEventMenuToggle(n);
        }
        private void SearchEventMenuToggle(bool n)
        {
            panelMenuSearch.Visible = n;
            lbCategory.Visible = n;
            lbName.Visible = n;
            txtBusquedaEvento.Visible = n;
            txtCategory.Visible = n;
        }

        private void btnSearchCategory_Click(object sender, EventArgs e) => new SportControler().GetPlayerData(txtBusquedaJugador.Text);
    }
}
       

       
    