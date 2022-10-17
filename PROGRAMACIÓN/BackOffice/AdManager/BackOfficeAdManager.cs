using CapaLoogica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        public BackOfficeAdManager()
        {
            InitializeComponent();
            LoadConfigs();
        }

        public string Finalpath;

        private void BtnAddAd_Click(object sender, EventArgs e)
        {
            string p = "";
            AdControler.Alta(
               txtAdName.Text,
               comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString(),
               p
                );
            MoveFlies(AdControler.GetStartPath(), comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString());
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
                 txtAddCategory.Text,
                 GetFinalPath()
                 );
            MessageBox.Show("Anuncio " + txtAdId.Text + " modificado");
            reloadList();
        }

        private void reloadList() => dataGrid1.DataSource = new AdControler().GetAdDataTable();
        public void SetFinalPath(string path) => Finalpath = path;
        public string GetFinalPath() => Finalpath;

        private void MoveFlies(string startpath, string category)
        {
            string basepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Olympus\\Cache\\{category}\\";
            string finalpath = basepath + new AdControler().GetAdId(txtAdName.Text) + txtAddCategory.Text + ".jpg";

            if (!Directory.Exists(basepath)) CreateDirectory(category);
            File.Copy(startpath, finalpath);
            txtAdPath.Text = finalpath;
        }
        private void CreateDirectory(string category)
        {
            string path = @"C:\Users\" + Environment.UserName + @"\Desktop\Olympus\Cache\" + category;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }


        private void btnMoveBanner_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) pictureBoxPreVisualization.Image = ResizeImage(new Bitmap(openFileDialog1.FileName), new Size(628, 89));
            txtAdPath.Text = openFileDialog1.FileName;
            openFileDialog1.ShowDialog();
            AdControler.setStartPath(openFileDialog1.FileName);
        }
        public static Image ResizeImage(Image imgOriginal, Size size) => new Bitmap(imgOriginal, size);

        public void LoadConfigs()
        {
            LoadCategory();
        }
        public void LoadCategory()
        {
            using (StreamReader archivo = File.OpenText("..\\..\\AdManager\\CategoryConfig.txt"))
            {
                int a = File.ReadLines("..\\..\\AdManager\\CategoryConfig.txt").Count();
                string linea = null;
                int i = 0;
                comboBoxCategory.Items.Clear();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    comboBoxCategory.Items.Add(linea);

                    if (++i == a) break;
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ExistCategory(txtAddCategory.Text))
                {
                    using (StreamWriter file = new StreamWriter("..\\..\\AdManager\\CategoryConfig.txt", true))
                    {
                        file.WriteLine(txtAddCategory.Text);
                        file.Close();
                    }
                }
                else
                {
                    throw new Exception("Categoria repetida");
                }
                LoadCategory();
            }
            catch(Exception ex)
            {
                if(ex.Message == "Categoria repetida") MessageBox.Show("La categoria ya existe");
                else MessageBox.Show(ex.ToString());
            }
        }

        private bool ExistCategory(string Category)
        {
            string Ruta = "..\\..\\AdManager\\CategoryConfig.txt";
            using (StreamReader archivo = File.OpenText(Ruta))
            {

                int a = File.ReadLines(Ruta).Count();
                int i = 0;

                while (!archivo.EndOfStream)
                {
                    string contenido = File.ReadAllText(Ruta);

                    if (contenido.Contains(Category)) return true;
                    if (++i == a+1) return false;
                }
                return false;
            }
            return true;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
