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


        public string Finalpath;

        private void BtnAddAd_Click(object sender, EventArgs e)
        {
            string p = "";
            AdControler.Alta(
                txtAdName.Text,
                txtAdCategory.Text,
               p
                );
            MoveFlies(AdControler.GetStartPath());
            MessageBox.Show("Anuncio cargado");
            reloadList();
        }

        private void btnList_Click(object sender, EventArgs e) => reloadList();

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
                 GetFinalPath()
                 );
            MessageBox.Show("Anuncio " + txtAdId.Text + " modificado");
            reloadList();
        }

        private void reloadList() => dataGrid1.DataSource = new AdControler().GetAdDataTable();
        public void SetFinalPath(string path) => Finalpath = path;
        public string GetFinalPath() => Finalpath;

        private void MoveFlies(string startpath)
        {
           


            string basepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Olympus\Cache\";
            string finalpath = basepath+ new AdControler().GetAdId(txtAdName.Text) + txtAdCategory.Text + ".jpg";
            
            if (!Directory.Exists(basepath)) CreateDirectory();
            File.Copy(startpath, finalpath);
            txtAdPath.Text = finalpath;

        }
        private void CreateDirectory()
        { 
            string path = @"C:\Users\" + Environment.UserName + @"\Desktop\Olympus\Cache";
           if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }
        private void txtAdCategory_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnMoveBanner_Click(object sender, EventArgs e) => MoveFlies(txtPathBanner.Text);
        private void btnMoveBanner_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            AdControler.setStartPath(openFileDialog1.FileName); 
        }

    }
}
