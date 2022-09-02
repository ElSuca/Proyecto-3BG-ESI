using CapaLoogica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BackOffice.ResultManager
{
    public partial class BackOfficeResults_Events : UserControl
    {
        private static BackOfficeResults_Events _instance;

        public static BackOfficeResults_Events Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeResults_Events();
                return _instance;
            }
        }

        public BackOfficeResults_Events()
        {
            InitializeComponent();
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {

        }
        private void reloadList()
        {
            DataTable tabla = new DataTable();
            MySqlCommand command = new MySqlCommand();
            command.Connection = new AplicationControler().ConectDatabase();
            command.CommandText = "SELECT * FROM User LEFT JOIN phones ON User.Id = phones.Id_User ";
            tabla.Load(command.ExecuteReader());
            new AplicationControler().ConectDatabase().Close();
            dataGrid1.DataSource = tabla;
        }

        private void btnList_Click(object sender, EventArgs e) => reloadList();

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
