using CapaLoogica;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
            try {
                if (panelManagerMenu.Visible)
                {
                    string date = $"{txtBirthdateYear.Text}-" +
                    $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}-" +
                    $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}";

                    string Startdate = $"{txtStartManagerAsociationDateYear.Text}-" +
                        $"{comboBoxStartManagerAsociationDateMoth.Items[comboBoxStartManagerAsociationDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxStartManagerAsociationDateDay.Items[comboBoxStartManagerAsociationDateDay.SelectedIndex].ToString()}";

                    string Enddate = $"{txtEndManagerAsociationDateYear.Text}-" +
                       $"{comboBoxEndManagerAsociationDateMoth.Items[comboBoxEndManagerAsociationDateMoth.SelectedIndex].ToString()}-" +
                       $"{comboBoxEndManagerAsociationDateDay.Items[comboBoxEndManagerAsociationDateDay.SelectedIndex].ToString()}";

                    ManagerControler.Alta(txtManagerName.Text,
                        txtManagerLastName1.Text,
                        txtManagerLastName2.Text,
                        txtManagerStatus.Text,
                        date,
                        TxtManagerState.Text,
                        txtManagerCountry.Text,
                        Int32.Parse(txtIdAsociation.Text),
                        Startdate,
                        Enddate
                        );

                    MessageBox.Show("Manager cargado");
                }
                else if (panelFamilyMenu.Visible)
                {
                    if (string.IsNullOrEmpty(txtFamilyId.Text))
                        FamilyControler.Alta(txtFamilyName.Text, txtFamilyRecurrency.Text, txtFamilyDomain.Text, txtFamilyType.Text);
                    if (panelEventFamilyMenu.Visible)

                        FamilyControler.AltaParents(Int32.Parse(txtFamilyId.Text), Int32.Parse(txtChirldId.Text), txtPreviounsFamilyType.Text, txtPreviounsFamilyInfo.Text);
                    MessageBox.Show("Equipo cargado");
                }
                else if (panelAsociationMenu.Visible)
                {
                    string StartDate = $"{txtStartAsociationDateYear.Text}-" +
                        $"{comboBoxAsociationStartDateMoth.Items[comboBoxAsociationStartDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxAsociationStartDateDay.Items[comboBoxAsociationStartDateDay.SelectedIndex].ToString()}";

                    string EndDate = $"{txtAsociationEndDateYear.Text}-" +
                         $"{comboBoxAsociationEndDateMoth.Items[comboBoxAsociationEndDateMoth.SelectedIndex].ToString()}-" +
                         $"{comboBoxAsociationEndDateDay.Items[comboBoxAsociationEndDateDay.SelectedIndex].ToString()}";

                    AsociationControler.Alta(
                        txtAsociationName.Text,
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This data aldery exist");
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
            try
            {
                if (panelManagerMenu.Visible)
                {
                    string date = $"{txtBirthdateYear.Text}-" +
                        $"{comboBoxBirthdateMoth.Items[comboBoxBirthdateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxBirthdateDay.Items[comboBoxBirthdateDay.SelectedIndex].ToString()}";
                    ManagerControler.Modificar(Int32.Parse(txtManagerID.Text), txtManagerName.Text, txtManagerLastName1.Text, txtManagerLastName2.Text, txtManagerStatus.Text, date, TxtManagerState.Text, txtManagerCountry.Text);
                    MessageBox.Show($"Jugador {txtManagerID.Text} cargado");
                }
                else if (panelFamilyMenu.Visible)
                {
                    FamilyControler.Modificar(Int32.Parse(txtFamilyId.Text), txtFamilyName.Text, txtFamilyRecurrency.Text, txtFamilyDomain.Text, txtFamilyType.Text);
                    MessageBox.Show($"Familia {txtFamilyId.Text} cargada");
                }
                else if (panelAsociationMenu.Visible)
                {
                    string StartDate = $"{txtStartAsociationDateYear.Text}-" +
                        $"{comboBoxAsociationStartDateMoth.Items[comboBoxAsociationStartDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxAsociationStartDateDay.Items[comboBoxAsociationStartDateDay.SelectedIndex].ToString()}";

                    string EndDate = $"{txtAsociationEndDateYear.Text}-" +
                         $"{comboBoxAsociationEndDateMoth.Items[comboBoxAsociationEndDateMoth.SelectedIndex].ToString()}-" +
                    $"{comboBoxAsociationEndDateDay.Items[comboBoxAsociationEndDateDay.SelectedIndex].ToString()}";



                    AsociationControler.Modificar(Int32.Parse(txtAsociationId.Text),
                        txtAsociationName.Text,
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
                    MessageBox.Show($"Asociacion {txtAsociationId.Text} cargada");
                }
                reloadList();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This data aldery exist");
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

        private void btnList_Click_1(object sender, EventArgs e) => reloadList();

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (panelManagerMenu.Visible)
                {
                    ManagerControler.Eliminar(Int32.Parse(txtManagerID.Text));
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
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This data no exist");
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
        private void lbPreviounsFamily_Click(object sender, EventArgs e) => panelEventFamilyMenu.Visible = panelEventFamilyMenu.Visible ? false : true;

        private void lbPreviounsFamily_MouseHover(object sender, EventArgs e) => lbPreviounsFamily.ForeColor = Color.Blue;

        private void lbPreviounsFamily_MouseLeave(object sender, EventArgs e) => lbPreviounsFamily.ForeColor = Color.White;
    }
}
