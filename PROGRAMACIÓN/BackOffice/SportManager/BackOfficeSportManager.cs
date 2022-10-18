using CapaLoogica;
using System;
using System.Windows.Forms;

namespace BackOffice.SportManager
{
    public partial class BackOfficeSportManager : UserControl
    {
        private static BackOfficeSportManager _instance;

        public static BackOfficeSportManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeSportManager();
                return _instance;
            }
        }

        public BackOfficeSportManager() => InitializeComponent();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SportControler.Alta(txtSportName.Text, txtTypeRegister.Text);
            MessageBox.Show("Deporte Cargado");
            reloadList();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            SportControler.Modify(Int32.Parse(txtSportID.Text),txtSportName.Text, txtTypeRegister.Text);
            MessageBox.Show($"Deporte {txtSportID.Text} Modificado");
            reloadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SportControler.Delete(Int32.Parse(txtSportID.Text));
            MessageBox.Show($"Deporte {txtSportID.Text} eliminado");
            reloadList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            reloadList();
        }
        private void reloadList() => dgrid1.DataSource = new SportControler().GetSportDataTable();
    }
}
