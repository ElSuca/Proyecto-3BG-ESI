using CapaLoogica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class BackOfficeAdManager : UserControl
    {
        private static BackOfficeAdManager _instance;

        public static BackOfficeAdManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeAdManager();
                return _instance;
            }
        }

        public BackOfficeAdManager() => InitializeComponent();

        private void BtnAddAd_Click(object sender, EventArgs e)
        {
            AdControler.Alta(
                txtAdName.Text,
                txtAdCategory.Text,
                txtAdPath.Text
                );
            MessageBox.Show("Anuncio cargado");
            reloadList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            reloadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdControler.Delete(int.Parse(txtAdId.Text));
            MessageBox.Show("Anuncio " + txtAdId.Text + " eliminado");
            reloadList();
        }

        private void btnAdModify_Click(object sender, EventArgs e)
        {
            AdControler.Modify(
                 txtAdName.Text,
                 Int32.Parse(txtAdId.Text),
                 txtAdCategory.Text,
                 txtAdPath.Text
                 );
            MessageBox.Show("Anuncio " + txtAdId.Text + " modificado");
            reloadList();
        }

        private void reloadList()
        {
            DataTable tabla = new DataTable();
            MySqlCommand command = new MySqlCommand();
            command.Connection = new AplicationControler().ConectDatabase();
            command.CommandText = "SELECT * FROM Ad";
            tabla.Load(command.ExecuteReader());
            new AplicationControler().ConectDatabase().Close();
            dataGrid1.DataSource = tabla;
        }
        private string startpath;
        public void setPath(string path) => startpath = path;
        private void btnInsertBanner_Click(object sender, EventArgs e)
        {
            new FileBrowser().Show();
            MoveFlies(startpath);
        }

        private void MoveFlies(string source)
        {
            CreateDirectory();
            File.Copy(source, "C:\\Olympus\\Cahe\\"+new AdControler().GetAdId(txtAdName.Text)+txtAdCategory);

        }
        private void CreateDirectory()
        {
           if (!Directory.Exists("C:\\Olympus\\Cahe")) Directory.CreateDirectory("C:\\Olympus\\Cahe");
        }
        private void txtAdCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
