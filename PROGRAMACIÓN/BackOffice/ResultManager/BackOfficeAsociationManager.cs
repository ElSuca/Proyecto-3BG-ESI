using CapaLoogica;
using System;
using System.Windows.Forms;

namespace BackOffice.ResultManager
{
    public partial class BackOfficeAsociationManager : UserControl
    {
        private static BackOfficeAsociationManager _instance;
        public static BackOfficeAsociationManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOfficeAsociationManager();
                return _instance;
            }
        }
        public BackOfficeAsociationManager()
        {
            InitializeComponent();
            setInitial();
        }
        private void btnManagerMenu_Click(object sender, EventArgs e) => toggleMenus(1);
        private void btnFamilyMenu_Click(object sender, EventArgs e) => toggleMenus(2);
        private void btnAsociationMenu_Click(object sender, EventArgs e) => toggleMenus(3);

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            if (panelManagerMenu.Visible)
            {
                string date = $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}/" +
                    $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}/" +
                    $"{txtBirthdateYear.Text}";
                string Start = $"{comboBoxAsociationStartDateDay.Items[comboBoxAsociationStartDateDay.SelectedIndex].ToString()}";
                string Startdate = $"{comboBoxAsociationStartDateDay.Items[comboBoxAsociationStartDateDay.SelectedIndex].ToString()}/" +
                   $"{comboBoxAsociationStartDateMoth.Items[comboBoxAsociationStartDateMoth.SelectedIndex].ToString()}/" +
                   $"{txtStartAsociationDateYear.Text}";

                string Enddate = $"{comboBoxAsociationEndDateDay.Items[comboBoxAsociationEndDateDay.SelectedIndex].ToString()}/" +
                   $"{comboBoxAsociationEndDateMoth.Items[comboBoxAsociationEndDateMoth.SelectedIndex].ToString()}/" +
                   $"{txtAsociationEndDateYear.Text}";

                ManagerControler.Alta(txtManagerName.Text,
                    txtManagerLastName1.Text,
                    txtManagerLastName2.Text,
                    txtManagerStatus.Text, date,
                    txtManagerCity.Text,
                    TxtManagerState.Text,
                    txtManagerCountry.Text,
                    Int32.Parse(txtIdAsociation.Text),
                    Startdate,
                    Enddate
                    );
                MessageBox.Show("Jugador cargado");
            }
            else if (panelFamilyMenu.Visible)
            {
                FamilyControler.Alta(txtFamilyName.Text, txtFamilyRecurrency.Text, txtFamilyDomain.Text, txtFamilyType.Text);
                MessageBox.Show("Equipo cargado");
            }
            else if (panelAsociationMenu.Visible)
            {
                string StartDate = $"{comboBoxAsociationStartDateDay.Items[comboBoxAsociationStartDateDay.SelectedIndex].ToString()}/" +
                   $"{comboBoxAsociationStartDateMoth.Items[comboBoxAsociationStartDateMoth.SelectedIndex].ToString()}/" +
                   $"{txtStartAsociationDateYear.Text}";

                string EndDate = $"{comboBoxAsociationEndDateDay.Items[comboBoxAsociationEndDateDay.SelectedIndex].ToString()}/" +
                   $"{comboBoxAsociationEndDateMoth.Items[comboBoxAsociationEndDateMoth.SelectedIndex].ToString()}/" +
                   $"{txtAsociationEndDateYear.Text}";

                AsociationControler.Alta(txtAsociationName.Text,
                    txtAsociationStatus.Text,
                    txtAsociationCity.Text,
                    txtAsociationStreet.Text,
                    Int32.Parse(txtAsociationNumber.Text),
                    txtAsociationState.Text,
                    txtAsociationCountry.Text,
                    StartDate,
                    EndDate,
                     Int32.Parse(txtAsociationSportID.Text),
                    txtAsociationCategory.Text,
                    Int32.Parse(txtAsociationQuantity.Text)
                    );
                MessageBox.Show("Asociacion cargada");
            }
            reloadList();
        }

        private void reloadList()
        {
            if (panelManagerMenu.Visible) dataGrid1.DataSource = new ManagerControler().GetManagerDataTable();
            else if (panelFamilyMenu.Visible) dataGrid1.DataSource = new FamilyControler().GetFamilyDataTable();
            else if (panelAsociationMenu.Visible) dataGrid1.DataSource = new AsociationControler().GetAsociationDataTable();
        }

        private void toggleMenus(int menu)
        {
            panelManagerMenu.Visible = false;
            panelFamilyMenu.Visible = false;
            panelAsociationMenu.Visible = false;

            if (menu == 2) panelFamilyMenu.Visible = true;
            if (menu == 1) panelManagerMenu.Visible = true;
            if (menu == 3) panelAsociationMenu.Visible = true;
        }
        private void setInitial()
        {
            panelManagerMenu.Visible = false;
            panelFamilyMenu.Visible = false;
            panelAsociationMenu.Visible = false;
        }

        private void btnModifiy_Click_1(object sender, EventArgs e)
        {
            if (panelManagerMenu.Visible)
            {
                string date = $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}/" +
                    $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}/" +
                    $"{txtBirthdateYear.Text}";
                ManagerControler.Modificar(Int32.Parse(txtManagerID.Text), txtManagerName.Text, txtManagerLastName1.Text, txtManagerLastName2.Text, txtManagerStatus.Text, date, txtManagerCity.Text, TxtManagerState.Text, txtManagerCountry.Text);
                MessageBox.Show($"Jugador {txtManagerID.Text} cargado");
            }
            else if (panelFamilyMenu.Visible)
            {
                FamilyControler.Modificar(Int32.Parse(txtFamilyId.Text), txtFamilyName.Text, txtFamilyRecurrency.Text, txtFamilyDomain.Text, txtFamilyType.Text);
                MessageBox.Show($"Familia {txtFamilyId.Text} cargada");
            }
            else if (panelAsociationMenu.Visible)
            {
                AsociationControler.Modificar(Int32.Parse(txtAsociationId.Text),
                    txtAsociationName.Text,
                    txtAsociationStatus.Text,
                    txtAsociationCity.Text,
                    txtAsociationStreet.Text,
                    Int32.Parse(txtAsociationNumber.Text),
                    txtAsociationState.Text,
                    txtAsociationCountry.Text);
                MessageBox.Show($"Asociacion {txtAsociationId.Text} cargada");
            }
            reloadList();
        }

        private void btnList_Click_1(object sender, EventArgs e) => reloadList();

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (panelManagerMenu.Visible)
            {
                FamilyControler.Eliminar(Int32.Parse(txtManagerID.Text));
                MessageBox.Show($"Jugador {txtManagerID.Text} eliminado");
            }
            else if (panelFamilyMenu.Visible)
            {
                FamilyControler.Eliminar(Int32.Parse(txtFamilyId.Text));
                MessageBox.Show($"Familia {txtFamilyId.Text} eliminada");
            }
            else if (panelAsociationMenu.Visible)
            {
                AsociationControler.Eliminar(Int32.Parse(txtAsociationId.Text));
                MessageBox.Show($"Asociacion  {txtAsociationId.Text} eliminada");
            }
            reloadList();
        }

        private void BackOfficeAsociationManager_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterPreviousFamily_Click(object sender, EventArgs e)
        {
            FamilyControler.AltaParents(Int32.Parse(txtFamilyId.Text),Int32.Parse(txtChirldId.Text),txtPreviounsFamilyType.Text, txtPreviounsFamilyInfo.Text);
            MessageBox.Show($"Datos cargados");
            reloadList();
        }

        private void panelManagerMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
