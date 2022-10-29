using CapaLogica;
using CapaLoogica;
using Proyecto;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class FormPincipalMenu : Form
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Date { get; set; }
        private int selection;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;

        public FormPincipalMenu()
        {
            InitializeComponent();  
            loadDafaults();
            selection = new Random().Next(3);
        }
        #region Fill Results
        private void FillResults2vs2(int n,string team1,string team2,int result1,int result2,string date)
        {
            MenuResultPreviewModel[] listItem = new MenuResultPreviewModel[n];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new MenuResultPreviewModel();
                listItem[i].Team1 = team1;
                listItem[i].Team2 = team2;
                listItem[i].Score1 = result1;
                listItem[i].Score2 = result2;
                listItem[i].Date = date;

                if (panelResult.Controls.Count < 0) panelResult.Controls.Clear();
                else
                {
                    panelResult.Controls.Add(listItem[i]);
                }

            }
        }
        #endregion
        private void loadDafaults()
        {


            FillResults2vs2(10, "n","P", 1, 0," 10 / 10 / 1010 10:10"); 
            this.Size = new Size(screenWidth, screenHeight);
            panelTopPage.Size = new Size(screenWidth, 53);
        }
        public void GetPanelMenuVisivility()
        {
            // setMenuDefaults();
            panelMenus.Controls.Clear();
            panelMenus.Visible = false;

           // checkPanelVisivility();
           // this.BringToFront();
        }
        private void setMenuDefaults()
        {
            if (panelMenus.Size == new Size(screenWidth, screenHeight-50))
            {
                panelMenus.Size = new Size(34, 31);
                panelMenus.Location = new Point(1389, 12);
            }
            else
            {
                panelMenus.Size = new Size(screenWidth, screenHeight-50);
                panelMenus.Location = new Point(0, (12)+50);
            }
        }

        private void checkPanelVisivility()
        {
            if (!IsAtFront(panelMenus))panelMenus.BringToFront();
            
        
        }
        private bool IsAtFront(Control control) => control.Parent.Controls.GetChildIndex(control) == 0;





        #region Low Mark

        private void lbBtnLanguge_MouseLeave(object sender, EventArgs e) => panelLowMark2.Visible = false;
        private void lbBtnLanguge_MouseHover(object sender, EventArgs e)
        {
            panelLowMark2.Size = new Size(lbBtnLanguge.Size.Width, 2);
            panelLowMark2.Location = new Point(lbBtnLanguge.Location.X, lbBtnLanguge.Location.Y + 12);
            panelLowMark2.Show();
            panelLowMark2.Visible = true;
        }

      

        private void lbBtnPersonalInformation_MouseLeave(object sender, EventArgs e) => panelLowMark2.Visible = false;
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panelLowMark.Size = new Size(pictureBoxBtnConfig.Size.Width, 2);
            panelLowMark.Location = new Point(pictureBoxBtnConfig.Location.X, pictureBoxBtnConfig.Location.Y + 52);
            panelLowMark.Show();
            panelLowMark.Visible = true;
            panelLowMark.BringToFront();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) => panelLowMark.Visible = false;
        private void lbBtnPersonalInformation_MouseHover(object sender, EventArgs e)
        {
            panelLowMark2.Size = new Size(137, 2);
            panelLowMark2.Location = new Point(lbBtnPersonalInformation.Location.X + 3, lbBtnPersonalInformation.Location.Y + 12);
            panelLowMark2.Show();
            panelLowMark2.Visible = true;
        }

        #endregion

        private void BannerPic_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(new ApiPublicidad.AddManager().SelectUrllink(selection));

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPremiunBlock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBtnConfig_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = panelConfig.Visible ? false : true;
            panelConfig.BringToFront();
        }

        private void lbBtnPersonalInformation_Click(object sender, EventArgs e)
        {
            setMenuDefaults();
            if (!panelMenus.Contains(UserDataMenu.Instance))
            {
                panelMenus.Controls.Add(UserDataMenu.Instance);
                UserDataMenu.Instance.Dock = DockStyle.Fill;
                UserDataMenu.Instance.BringToFront();
            }
            else UserDataMenu.Instance.BringToFront();
            checkPanelVisivility();
        }

        private void panelConfig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbBtnLanguge_Click(object sender, EventArgs e)
        {
            setMenuDefaults();
            if (!panelMenus.Contains(LanguageMenu.Instance))
            {
                panelMenus.Controls.Add(LanguageMenu.Instance);
                LanguageMenu.Instance.Dock = DockStyle.Fill;
                LanguageMenu.Instance.BringToFront();
            }
            else LanguageMenu.Instance.BringToFront();
            checkPanelVisivility();
        }

        private void lbDebuggButton_Click(object sender, EventArgs e) => panelDebugg.Visible = panelDebugg.Visible ? false : true;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSportListButtomMenu_MouseHover(object sender, EventArgs e)
        {
            panelSportList.Visible = true;
        }

        private void lbSportListButtomMenu_MouseLeave(object sender, EventArgs e)
        {

           /// panelSportList.Visible = false;

        }

        private void panelSportList_MouseHover(object sender, EventArgs e) => panelSportList.Visible = true;

        private void panelSportList_MouseLeave(object sender, EventArgs e) => panelSportList.Visible = false;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbButtonFootbal_Click(object sender, EventArgs e)
        {
            panelResult.Controls.Clear();
            new EventControler().GetEventBySport("Football");
        }
    }
}
