using CapaLogica;
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
        private void FillResults(int n)
        {
            MenuResultPreviewModel[] listItem = new MenuResultPreviewModel[n];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new MenuResultPreviewModel();
                listItem[i].Team1 = Team1;
                listItem[i].Team2 = Team2;
                listItem[i].Score1 = Score1;
                listItem[i].Score2 = Score2;
                listItem[i].Date = Date;

                if (panelResult.Controls.Count < 0) panelResult.Controls.Clear();
                else
                {
                    panelResult.Controls.Add(listItem[i]);
                }

            }
        }
        private void FillResultsPremiun(int n)
        {
            MenuResultPreviewModel[] listItem = new MenuResultPreviewModel[n];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new MenuResultPreviewModel();
                listItem[i].Team1 = Team1;
                listItem[i].Team2 = Team2;
                listItem[i].Score1 = Score1;
                listItem[i].Score2 = Score2;
                listItem[i].Date = Date;

                if (panelResultPremiun.Controls.Count < 0) panelResultPremiun.Controls.Clear();
                else
                {
                    panelResultPremiun.Controls.Add(listItem[i]);
                }

            }
        }
        #endregion
        private void loadDafaults()
        {


            FillResults(10);
            FillResultsPremiun(10);
            Team1 = "Nacional";
            Team2 = "Peñarol";
            Score1 = 1;
            Score2 = 0;
            Date = "22/10/2022 10:20";



            
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
            if (panelMenus.Size == new Size(screenWidth, screenHeight))
            {
                panelMenus.Size = new Size(34, 31);
                panelMenus.Location = new Point(1389, 12);
            }
            else
            {
                panelMenus.Size = new Size(screenWidth, screenHeight);
                panelMenus.Location = new Point(0, 12);
            }
        }
        private void FormPincipalMenu_Load(object sender, EventArgs e) => panelPremiunBlock.Visible = new UserControler().GetStaticRole == "Premiun" ? false : true;
        #region click
        private void btnsendinfo_Click(object sender, EventArgs e)
        {
            Team1 = txtTeam1.Text;
            Team2 = txtTeam2.Text;
            Score1 = Int32.Parse(txtScore1.Text);
            Score2 = Int32.Parse(txtScore2.Text);
            Date = txtDate.Text;
            FillResults(Int32.Parse(txtNumberItems.Text));
            FillResultsPremiun(Int32.Parse(txtNumberItems.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelResult.Controls.Clear();
            panelResultPremiun.Controls.Clear();
        }

        private void lbDebuggButton_Click(object sender, EventArgs e) => panelDebugg.Visible = panelDebugg.Visible ? false : true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = panelConfig.Visible ? false : true;
            if (panelMenus.Visible) panelMenus.Visible = false;
            checkPanelVisivility();
        }

        private void lbBtnLanguge_Click(object sender, EventArgs e)
        {
            setMenuDefaults();
            panelMenus.Visible = panelMenus.Visible ? false : true;
            if (!panelMenus.Contains(LanguageMenu.Instance))
            {
                panelMenus.Controls.Add(LanguageMenu.Instance);
                LanguageMenu.Instance.Dock = DockStyle.Fill;
                LanguageMenu.Instance.BringToFront();
            }
            else LanguageMenu.Instance.BringToFront();
            checkPanelVisivility();
        }

        private void lbBtnPersonalInformation_Click(object sender, EventArgs e)
        {
            setMenuDefaults();
            panelMenus.Visible = panelMenus.Visible ? false : true;

            if (!panelMenus.Contains(UserDataMenu.Instance))
            {
                panelMenus.Controls.Add(UserDataMenu.Instance);
                UserDataMenu.Instance.Dock = DockStyle.Fill;
                UserDataMenu.Instance.BringToFront();
            }
            else UserDataMenu.Instance.BringToFront();

            checkPanelVisivility();
        }
        #endregion
        private void checkPanelVisivility()
        {
            if (!IsAtFront(panelMenus))
            {
                panelMenus.BringToFront();
            }
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
    }
}
