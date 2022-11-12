using CapaLoogica;
using System;
using System.Data.SqlClient;
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

        public BackOfficeSportManager()
        {
            InitializeComponent();
            reloadList();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSportName.Text == "" || txtTypeRegister.Text == "") throw new ArgumentNullException();
                SportControler.Alta(txtSportName.Text, txtTypeRegister.Text);
                MessageBox.Show("Deporte Cargado");
                reloadList();
            } 
            catch (ArgumentNullException)
            {
                MessageBox.Show("here was an error, please check that the text box are fill");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                SportControler.Modify(Int32.Parse(txtSportID.Text), txtSportName.Text, txtTypeRegister.Text);
                MessageBox.Show($"Deporte {txtSportID.Text} Modificado");
                reloadList();
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SportControler.Delete(Int32.Parse(txtSportID.Text));
                MessageBox.Show($"Deporte {txtSportID.Text} eliminado");
                reloadList();
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user aldery exist");
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

        private void btnList_Click(object sender, EventArgs e)
        {
        }
        private void reloadList()
        {
            try
            {
                dgrid1.DataSource = new SportControler().GetSportDataTable();
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

        private void pictureBoxBtnRefresh_Click(object sender, EventArgs e) => reloadList();
    }
}
