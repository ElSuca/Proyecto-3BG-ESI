using CapaLoogica;
using System;
using System.Data.SqlClient;
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
            reloadList();
            traduction(new AplicationControler().Language);
        }

        private void traduction(int l)
        {
            if(l == 0)
            {
                lbAdId.Text = "Ad Id";
                lbAdName.Text = "Ad name";
                lbAdCategory.Text = "Ad category";
                btnMoveBanner.Text = "Select picture";
                BtnAddAd.Text = "Register";
                btnAdModify.Text = "Modify";
                btnDelete.Text = "Delete";
                btnAddCategory.Text = "Register Category";
            }
            else
            {
                lbAdId.Text = "Id de publicidad";
                lbAdName.Text = "Nombre de publicidad";
                lbAdCategory.Text = "Categoria de anuncio";
                btnMoveBanner.Text = "Seleccionar imagen";
                BtnAddAd.Text = "Registrar";
                btnAdModify.Text = "Modify";
                btnDelete.Text = "Delete";
                btnAddCategory.Text = "Registrar Categoria";
            }
        }
        public string Finalpath;
        

        private void BtnAddAd_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Olympus\\Cache\\{category}\\";
                GetNextFileName(path + category, category);
                string finalpath = fixPathExtention(fixPath(Finalpath, category));
                AdControler.Alta(txtAdName.Text, comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString(), formatPath(finalpath));
                MoveFlies(AdControler.GetStartPath(), comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString());
                MessageBox.Show("Anuncio cargado");
                reloadList();
            }
            catch (ArgumentOutOfRangeException)
            {            
                MessageBox.Show("Please insert a category");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private string formatPath(string path)
        {
            
           var  p = path.Replace(@"\", "-");
            return p;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                AdControler.Delete(int.Parse(txtAdId.Text));
                MessageBox.Show("Ad " + txtAdId.Text + " deleted");
                reloadList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please insert a category");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void btnAdModify_Click(object sender, EventArgs e)
        {
            try
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a role for user");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a role for user");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This ad aldery exist");
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }

        private void reloadList()
        {
            try
            {
                dataGrid1.DataSource = new AdControler().GetAdDataTable();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Database disconeced");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }
        public void SetFinalPath(string path) => Finalpath = path;
        public string GetFinalPath() => Finalpath;

        private void MoveFlies(string startpath, string category)
        {
            string basepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Olympus\\Cache\\{category}\\";
            string Filename = fixPathExtention(this.Finalpath);
            if (!Directory.Exists(basepath)) CreateDirectory(category);
            try
            {
                File.Copy(startpath, Finalpath);
            }
            catch
            {
                Finalpath = basepath + Filename;
                File.Copy(startpath, Finalpath + ".jpg");
            }
            txtAdPath.Text = Finalpath;
        }
        private void GetNextFileName(string path, string category)
        {   
            string extension = ".jpg";
            string pathName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Olympus\\Cache\\{category}\\";
            string fileNameOnly = Path.Combine(pathName, Path.GetFileNameWithoutExtension(path));
            int i = 1;
            string filename = fileNameOnly + i + extension;
            while (File.Exists(fixPathExtention(filename)))
            {
                i += 1;
                filename = fileNameOnly + i + extension;
                path = filename;
            }
            Finalpath = filename;
        }
        private string fixPath(string path,string category)
        {
            if (path.Contains($"\\Olympus\\Cache\\{category}\\")) return path;
            else return $"\\Olympus\\Cache\\{category}\\" + path;
        }
        private string fixPathExtention(string fileName)
        {
            if (fileName.Contains(".jpg")) return fileName;
            else return fileName + ".jpg";
        }
        private void CreateDirectory(string category)
        {
            string path = @"C:\Users\" + Environment.UserName + @"\Desktop\Olympus\Cache\" + category;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }
        private void btnMoveBanner_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK) pictureBoxPreVisualization.Image = ResizeImage(new Bitmap(openFileDialog1.FileName), new Size(628, 89));
                txtAdPath.Text = openFileDialog1.FileName;
                openFileDialog1.ShowDialog();
                AdControler.setStartPath(openFileDialog1.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }
        public static Image ResizeImage(Image imgOriginal, Size size) => new Bitmap(imgOriginal, size);

        public void LoadConfigs() => LoadCategory();
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
                if(txtAddCategory.Text == "") throw new NullReferenceException();   
                else if (!ExistCategory(txtAddCategory.Text))
                {
                    using (StreamWriter file = new StreamWriter("..\\..\\AdManager\\CategoryConfig.txt", true))
                    {
                        file.WriteLine(txtAddCategory.Text);
                        file.Close();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
                LoadCategory();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The category already exists");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please insert a value in the text box");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxBtnRefresh_Click(object sender, EventArgs e) => reloadList();
    }
}
