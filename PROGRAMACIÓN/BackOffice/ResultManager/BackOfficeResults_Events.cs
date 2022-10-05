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

        public BackOfficeResults_Events() => InitializeComponent();
        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            EventControler.Alta(
                txtEventName.Text,
                txtDate.Text,
                txtPreEvent.Text
            );
            MessageBox.Show("Evento cargado");
        }
        private void reloadList() => dataGrid1.DataSource = new EventControler().GetEventDataTable();
        private void btnList_Click(object sender, EventArgs e) => reloadList();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            EventControler.Eliminar(int.Parse(txtEventId.Text));
            MessageBox.Show("Evento" + txtEventId.Text + " eliminado");
        }
    }
}
