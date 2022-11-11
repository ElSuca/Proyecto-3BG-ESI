using ApiPublica.ExtendedMenu;
using ApiResult;
using Apis;
using CapaLogica;
using CapaLoogica;
using Proyecto;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class FormPincipalMenu : Form
    {
        public static int IdTeam1 { get; set; }
        public static int IdTeam2 { get; set; }
        public static string Team1 { get; set; }
        public static string Team2 { get; set; }
        public static int Score1 { get; set; }
        public static int Score2 { get; set; }
        public static string Date { get; set; }
        public static string Competition { get; set; }
        public static string StartTime { get; set; }
        public static string EndTime { get; set; }
        public static string Stadium { get; set; }

        private int selection;
        private int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        private int screenWidth = Screen.PrimaryScreen.Bounds.Width;

        public FormPincipalMenu()
        {
            InitializeComponent();  
            loadDafaults();
            selection = new Random().Next(3);
            SetAdBanner("trotafritas");
        }
        #region Fill Results
        private void FillResults1vs1(int idTeam1,int idTeam2,string team1,string team2,int result1,int result2,string date,string competition,string startTime,string endTime,string stadium)
        {
            MenuResult1vs1PreviewModel[] listItem = new MenuResult1vs1PreviewModel[1];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new MenuResult1vs1PreviewModel();
                listItem[i].IdTeam1 = idTeam1;
                listItem[i].IdTeam2 = idTeam2;
                listItem[i].Team1 = team1;
                listItem[i].Team2 = team2;
                listItem[i].Score1 = result1;
                listItem[i].Score2 = result2;
                listItem[i].Date = date;
                listItem[i].Competition = competition;
                listItem[i].StartTime = startTime;
                listItem[i].EndTime = endTime;
                listItem[i].Stadium = stadium;

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
            BannerPic.Visible = new UserControler().GetStaticRole == "Premiun" ? false : true;

            FillResults1vs1(1,2,"n","P", 1, 0,"10/10/1010","a","10:10","12:30","a"); 
            this.Size = new Size(1280, 1024);
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
                checkPanelVisivility();
            }
            else
            {
                panelMenus.Size = new Size(screenWidth, screenHeight-50);
                panelMenus.Location = new Point(0, (12)+50);
                checkPanelVisivility();
            }
        }

        private void checkPanelVisivility()
        {
            if (!IsAtFront(panelMenus)) panelMenus.BringToFront();
        }
        private bool IsAtFront(Control control) => control.Parent.Controls.GetChildIndex(control) == 0;


        public void SetAdBanner(string category)
        {
   //         controlApiPub();

            SendRequestPublicidad.GetPost("http://127.0.0.1:7777//Ad", category);
            BannerPic.Image  = new Bitmap(formatPath(new AplicationControler().getResponse()));
        }
        private string formatPath(string path) => path.Replace("-", @"\");
        private void controlApiPub()
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = @"..\..\..\..\PROGRAMACIÓN\ApiPublicidad\bin\Debug\ApiPublicidad.exe";
            startinfo.CreateNoWindow = true;
            startinfo.UseShellExecute = true;
            if (!isRunning("ApiAutentificacion")) Process.Start(startinfo).Start();
            else Process.Start(startinfo).Kill();
        }
        private void controlApiRes()
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = @"..\..\..\..\PROGRAMACIÓN\APIResult\NewAPIResult\bin\Debug\NewAPIResult.exe";
            startinfo.CreateNoWindow = true;
            startinfo.UseShellExecute = true;
            if (!isRunning("NewAPIResult")) Process.Start(startinfo).Start();
            else Process.Start(startinfo).Kill();
        }
        public static bool isRunning(string ProcessName)
        {
            Process[] processes = Process.GetProcessesByName(ProcessName);
            if (processes.Length == 0) return false;
            else return true;
        }

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

        public void ShowFullInformation(int idTeam1,int idTeam2, string team1, string team2, string competition, string startTime, string endTime, string date, string stadium, int score1, int score2)
        {
            IdTeam1 = idTeam1;
            IdTeam2 = idTeam2;
            Team1 = team1;
            Team2 = team2;
            Competition = competition;
            StartTime = startTime;
            EndTime = endTime;
            Date = date;
            Stadium = stadium;
            Score1 = score1;
            Score2 = score2;
            new FormMenuResult1vs1Extend().Show();
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
            controlApiRes();
            SendRequestResult.GetPost("http://localhost:1111//api//EventId//GetEventIdByDate", 1, new SportControler().GetId("Football"));

            panelResult.Controls.Clear();
            FillResults1vs1(Int32.Parse(txtTeam1id.Text), Int32.Parse(txtTeam2id.Text), new TeamControler().GetName(Int32.Parse(txtTeam1id.Text)), new TeamControler().GetName(Int32.Parse(txtTeam2id.Text)), Int32.Parse(txtScore1.Text), Int32.Parse(txtScore2.Text), txtDate.Text, txtCompetition.Text, txtStartTime.Text, txtEndTime.Text, txtStadium.Text);
            new EventControler().GetEventBySport("Football");
        }

        private void btnClear_Click(object sender, EventArgs e) => panelResult.Controls.Clear();

        private void btnsendinfo_Click(object sender, EventArgs e) => FillResults1vs1(Int32.Parse(txtTeam1id.Text), Int32.Parse(txtTeam2id.Text), new TeamControler().GetName(Int32.Parse(txtTeam1id.Text)), new TeamControler().GetName(Int32.Parse(txtTeam2id.Text)), Int32.Parse(txtScore1.Text), Int32.Parse(txtScore2.Text), txtDate.Text, txtCompetition.Text, txtStartTime.Text, txtEndTime.Text, txtStadium.Text);

        private void button1_Click(object sender, EventArgs e)
        {
            new UserControler().SetFamilySubscription("a",new UserControler().GetId(new UserControler().GetStaticUsername));
        }

        private void lbButtonBasketball_Click(object sender, EventArgs e)
        {

        }

        private void lbButtonTenis_Click(object sender, EventArgs e)
        {

        }
    }
}
