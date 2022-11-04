using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaLoogica;

namespace BackOffice.ResultManager
{
    public partial class BackOficeResultManager : UserControl
    {
      
        private static BackOficeResultManager _instance;

        public static BackOficeResultManager Instance
        {
            get
            {
                if (_instance == null) _instance = new BackOficeResultManager();
                return _instance;
            }
        }

        public BackOficeResultManager()
        {
            InitializeComponent();
            setInitial();
        }
        private void btnList_Click(object sender, EventArgs e) => reloadList();
        private void reloadList()
        {
            try
            {
                if (panelEventMenu.Visible) dataGrid1.DataSource = panelEventFamilyMenu.Visible ? new EventControler().GetEventFamilyDataTable() : new EventControler().GetEventDataTable();
                else if (panelJudgeMenu.Visible) dataGrid1.DataSource = new JudgeControler().GetJudgeDataTable();
                else if (panelStageMenu.Visible) dataGrid1.DataSource = new StageControler().GetStageDataTable();
                else if (panelActionMenu.Visible) dataGrid1.DataSource = new ActionControler().GetActionDataTable();
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

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelEventMenu.Visible)
                {
                    string StartDate = $"{txtEventStartDateYear.Text}-" +
                        $"{comboBoxEventStartDateMoth.Items[comboBoxEventStartDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxEventStartDateDay.Items[comboBoxEventStartDateMoth.SelectedIndex].ToString()}";

                    string EndDate = $"{txtEventEndDateYear.Text}-" +
                        $"{comboBoxEventStartDateMoth.Items[comboBoxEventEndDateMoth.SelectedIndex].ToString()}-" +
                        $"{comboBoxEventEndDateDay.Items[comboBoxEventEndDateMoth.SelectedIndex].ToString()}";

                    EventControler.Alta(txtEventName.Text, StartDate, EndDate, Int32.Parse(txtStageJudgeId.Text), Int32.Parse(txtTimeNumber.Text), txtTimeDescription.Text);
                    parsearEvento();
                    if (panelEventFamilyMenu.Visible) EventControler.AltaParents(Int32.Parse(txtParentId.Text), txtPreviounsFamilyType.Text, txtPreviounsFamilyInfo.Text, txtEventName.Text);
                    MessageBox.Show("Evento cargado");
                }
                else if (panelJudgeMenu.Visible)
                {
                    if (txtJudgeName.Text == "" || txtJudgeLastName1.Text == "" || txtJudgeLastName2.Text == "" || txtJudgeCity.Text == "" || txtJudgeState.Text == "" || txtJudgeCountry.Text == "") throw new MissingFieldException();
                    else
                    {
                        JudgeControler.Alta(txtJudgeName.Text, txtJudgeLastName1.Text, txtJudgeLastName2.Text, txtJudgeCity.Text, txtJudgeState.Text, txtJudgeCountry.Text);
                        MessageBox.Show("Juez cargado");
                    }
                }
                else if (panelStageMenu.Visible)
                {
                    StageControler.Alta(txtStageName.Text, txtStageCity.Text, txtStageStreet.Text, Int32.Parse(txtStageNum.Text), txtStageState.Text, txtStageCountry.Text);
                    MessageBox.Show("Estadio cargado");
                }
                else if (panelActionMenu.Visible)
                {
                    string Time = getTime();
                    ActionControler.Alta(Int32.Parse(txtIdTeam.Text), Int32.Parse(txtIdPlayer.Text), Int32.Parse(txtIdTime.Text), Int32.Parse(txtActionQuantity.Text), txtActionType.Text, txtActionContext.Text, Time, txtActionCategory.Text);
                    MessageBox.Show("Acción cargada");
                }
                else MessageBox.Show("Por favor, seleccione un menu");
                reloadList();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please enter a date");
            }
            catch (MissingFieldException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
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
                MessageBox.Show("This result aldery exist");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an unexpected error");
            }
        }
        private void parsearEvento()
        {
            if (string.IsNullOrEmpty(txtParentId.Text)) txtParentId.Text = "0";
            if (string.IsNullOrEmpty(txtPreviounsFamilyInfo.Text)) txtPreviounsFamilyInfo.Text = "...";
            if (string.IsNullOrEmpty(txtPreviounsFamilyType.Text)) txtPreviounsFamilyType.Text = "...";
        }


        private void btnEventMenu_Click(object sender, EventArgs e) => toggleMenus(1);
        private void btnJudgesMenu_Click(object sender, EventArgs e) => toggleMenus(2);
        private void btnStageMenu_Click(object sender, EventArgs e) => toggleMenus(3);
        private void btnActionMenu_Click(object sender, EventArgs e) => toggleMenus(4);

        public void toggleMenus(int menu)
        { 
            panelEventMenu.Visible = menu == 1 ? true : false;
            panelJudgeMenu.Visible = menu == 2 ? true : false;
            panelStageMenu.Visible = menu == 3 ? true : false;
            panelActionMenu.Visible = menu == 4 ? true : false;
        }
       
        private void setInitial()
        {
            panelEventMenu.Visible = false;
            panelJudgeMenu.Visible = false;
            panelStageMenu.Visible = false;
            panelActionMenu.Visible = false;
        }
        private void btnModifiy_Click(object sender, EventArgs e)
        {
            try
            {

                if (panelEventMenu.Visible)
                {
                    EventControler.Modificar(Int32.Parse(txtEventID.Text), txtEventName.Text, txtEventStartDateYear.Text, txtEventEndDateYear.Text, Int32.Parse(txtStageNum.Text), Int32.Parse(txtTimeNumber.Text), txtTimeDescription.Text);
                    MessageBox.Show("Evento" + txtEventID.Text + "modificado");
                }
                else if (panelJudgeMenu.Visible)
                {
                    JudgeControler.Modificar(Int32.Parse(txtJudgeId.Text), txtJudgeName.Text, txtJudgeLastName1.Text, txtJudgeLastName2.Text, txtJudgeCity.Text, txtJudgeState.Text, txtJudgeCountry.Text);
                    MessageBox.Show("Juez" + txtJudgeId.Text + "modificado");
                }
                else if (panelStageMenu.Visible)
                {
                    StageControler.Modificar(Int32.Parse(txtStageId.Text), txtStageName.Text, txtStageCity.Text, txtStageStreet.Text, Int32.Parse(txtStageNum.Text), txtStageState.Text, txtStageCountry.Text);
                    MessageBox.Show("Estadio" + txtStageId.Text + "modificado");
                }
                else if (panelActionMenu.Visible)
                {
                    string Time = getTime();
                    ActionControler.Modificar(Int32.Parse(txtActionId.Text), Int32.Parse(txtIdTeam.Text), Int32.Parse(txtIdPlayer.Text), Int32.Parse(txtIdTime.Text), Int32.Parse(txtActionQuantity.Text), txtActionType.Text, txtActionContext.Text, Time, txtActionCategory.Text);
                    MessageBox.Show("Accion" + txtActionId.Text + "modificada");
                }
                else MessageBox.Show("Por favor, seleccione un menu");
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
        private string getTime()
        {
            string Date = $"{txtActionDateYear.Text}-" +
                  $"{comboBoxActionDateMoth.Items[comboBoxActionDateMoth.SelectedIndex].ToString()}-" +
                  $"{comboBoxActionDateDay.Items[comboBoxActionDateMoth.SelectedIndex].ToString()}";
            string Hour = $"{comboBoxActionHour.Items[comboBoxActionHour.SelectedIndex].ToString()}:" +
             $"{comboBoxActionMinute.Items[comboBoxActionMinute.SelectedIndex].ToString()}";

            return $"{Date} {Hour}:0";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelEventMenu.Visible)
                {
                    EventControler.Eliminar(Int32.Parse(txtEventID.Text));
                    MessageBox.Show($"Evento {txtEventID.Text} Eliminado");
                }
                else if (panelJudgeMenu.Visible)
                {
                    JudgeControler.Eliminar(Int32.Parse(txtJudgeId.Text));
                    MessageBox.Show($"Juez {txtJudgeId.Text} Eliminado");
                }
                else if (panelStageMenu.Visible)
                {
                    StageControler.Eliminar(Int32.Parse(txtStageId.Text));
                    MessageBox.Show($"Estadio {txtStageId.Text} Eliminado");
                }
                else if (panelActionMenu.Visible)
                {
                    StageControler.Eliminar(Int32.Parse(txtActionId.Text));
                    MessageBox.Show($"Accion {txtActionId.Text} Eliminada");
                }
                else MessageBox.Show("Por favor, seleccione un menu");
                reloadList();
            }
            catch (FormatException)
            {
                MessageBox.Show("There was an error, please check that the information is correct");
            }
            catch (SqlException)
            {
                MessageBox.Show("This user no exist");
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

        private void lbPreviounsFamily_MouseHover_1(object sender, EventArgs e) => lbPreviounsFamily.ForeColor = Color.Blue;
        private void lbPreviounsFamily_MouseLeave(object sender, EventArgs e) => lbPreviounsFamily.ForeColor = Color.White;

       
    }
}
