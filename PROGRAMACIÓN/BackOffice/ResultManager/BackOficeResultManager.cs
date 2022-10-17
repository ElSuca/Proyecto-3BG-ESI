using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            if(panelEventMenu.Visible) dataGrid1.DataSource = new EventControler().GetEventDataTable();    
                else if(panelJudgeMenu.Visible) dataGrid1.DataSource = new JudgeControler().GetJudgeDataTable();
            else if (panelStageMenu.Visible) dataGrid1.DataSource = new StageControler().GetStageDataTable();
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible)
            {
                var StartDate = $"{txtEventStartDateYear.Text}-" +
                    $"{comboBoxEventStartDateMoth.Items[comboBoxEventStartDateMoth.SelectedIndex].ToString()}-" +
                    $"{comboBoxEventStartDateDay.Items[comboBoxEventStartDateMoth.SelectedIndex].ToString()}";

                var EndDate = $"{txtEventEndDateYear.Text}-" +
                    $"{comboBoxEventStartDateMoth.Items[comboBoxEventEndDateMoth.SelectedIndex].ToString()}-" +
                    $"{comboBoxEventEndDateDay.Items[comboBoxEventEndDateMoth.SelectedIndex].ToString()}";

                EventControler.Alta(txtEventName.Text, StartDate, EndDate, Int32.Parse(txtStageJudgeId.Text));
                MessageBox.Show("Evento cargado");
            }
            else if (panelJudgeMenu.Visible)
            {
                JudgeControler.Alta(txtJudgeName.Text, txtJudgeLastName1.Text, txtJudgeLastName2.Text, txtJudgeCity.Text, txtJudgeState.Text, txtJudgeCountry.Text);
                MessageBox.Show("Juez cargado");
            }
            else if (panelStageMenu.Visible)
            {
                StageControler.Alta(txtStageCity.Text,txtStageStreet.Text,Int32.Parse(txtStageNum.Text), txtStageState.Text,txtStageCountry.Text);
                MessageBox.Show("Estadio cargado");
            }
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }

        private void btnEventMenu_Click(object sender, EventArgs e) => toggleMenus(1);
        private void btnJudgesMenu_Click(object sender, EventArgs e) => toggleMenus(2);
        private void btnStageMenu_Click(object sender, EventArgs e) => toggleMenus(3);

        public void toggleMenus(int menu)
        {
            panelEventMenu.Visible = false;
            panelJudgeMenu.Visible = false;
            panelStageMenu.Visible = false;
            if (menu == 1) panelEventMenu.Visible = true;
            if (menu == 2) panelJudgeMenu.Visible = true;
            if (menu == 3) panelStageMenu.Visible = true;
        }
       
        private void setInitial()
        {
            panelEventMenu.Visible = false;
            panelJudgeMenu.Visible = false;
            panelStageMenu.Visible = false;
        }
        private void btnModifiy_Click(object sender, EventArgs e)
        {
            if (panelEventMenu.Visible)
            {
                EventControler.Modificar(Int32.Parse(txtEventID.Text),txtEventName.Text, txtEventStartDateYear.Text, txtEventEndDateYear.Text, Int32.Parse(txtStageNum.Text));
                MessageBox.Show("Evento"+ txtEventID.Text + "modificado");
            }
            else if (panelJudgeMenu.Visible)
            {
                JudgeControler.Modificar(Int32.Parse(txtJudgeId.Text), txtJudgeName.Text, txtJudgeLastName1.Text, txtJudgeLastName2.Text, txtJudgeCity.Text, txtJudgeState.Text, txtJudgeCountry.Text);
                MessageBox.Show("Juez" + txtJudgeId.Text + "modificado");
            }
            else if (panelStageMenu.Visible)
            {
                StageControler.Modificar(Int32.Parse(txtStageId.Text), txtStageCity.Text, txtStageStreet.Text, Int32.Parse(txtStageNum.Text), txtJudgeState.Text, txtStageCountry.Text);
                MessageBox.Show("Estadio" + txtStageId.Text + "modificado");
            }
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            else MessageBox.Show("Por favor, seleccione un menu");
            reloadList();
        }

        private void btnRegisterPreviousFamily_Click(object sender, EventArgs e)
        {
            EventControler.AltaParents(Int32.Parse(txtEventID.Text), Int32.Parse(txtChirldId.Text), txtPreviounsFamilyType.Text, txtPreviounsFamilyInfo.Text);
            MessageBox.Show($"Datos cargados");
            reloadList();
        }
    }
}
