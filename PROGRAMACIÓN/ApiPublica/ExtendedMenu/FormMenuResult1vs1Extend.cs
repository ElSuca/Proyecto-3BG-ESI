using CapaLoogica;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ApiPublica.ExtendedMenu
{
    public partial class FormMenuResult1vs1Extend : Form
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Competition { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Date { get; set; }
        public string Stadium { get; set; }

        public FormMenuResult1vs1Extend()
        {
            InitializeComponent();
            GetData();
            SetDefaults();
        }

        public void SetDefaults()
        {
            lbTeam1_.Text = Team1;
            lbTeam1.Text = Team1;
            lbTeam2.Text = Team2;
            lbTeam2_.Text = Team2;
            lbResult1.Text = Score1.ToString();
            lbResult2.Text = Score2.ToString();
            lbCompetition.Text = Competition;
            lbStartTime.Text = StartTime;
            lbDate.Text = Date;
            lbUbication.Text = Stadium;
        }
        public void GetData()
        {
            Team1 =  FormPincipalMenu.Team1;
            Team2 = FormPincipalMenu.Team2;
            Score1 = FormPincipalMenu.Score1;
            Score2 = FormPincipalMenu.Score2;
            Competition = FormPincipalMenu.Competition;
            StartTime = FormPincipalMenu.StartTime;
            EndTime = FormPincipalMenu.EndTime;
            Date = FormPincipalMenu.Date;
            Stadium = FormPincipalMenu.Stadium;


            DataTable tabla = new PlayerControler().GetUserNameByTeam(Team1);
            string[] Players = tabla.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string a = "a";

            FillTeam1Players(Team1);
            FillTeam2Players(Team2);
        }

        private void FillTeam1Players(string name)
        {
            ControlName[] listItem = new ControlName[1];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new ControlName();
                listItem[i].Name = name;

                if (panelNamesPlayersTeam1.Controls.Count < 0) panelNamesPlayersTeam1.Controls.Clear();
                else panelNamesPlayersTeam1.Controls.Add(listItem[i]);
            }
        }
        private void FillTeam2Players(string name)
        {
            ControlName[] listItem = new ControlName[1];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new ControlName();
                listItem[i].Name = name;

                if (panelNamesPlayersTeam2.Controls.Count < 0) panelNamesPlayersTeam2.Controls.Clear();
                else panelNamesPlayersTeam2.Controls.Add(listItem[i]);
            }
        }
        private void MenuResult1vs1Extend_Load(object sender, System.EventArgs e)
        {
            DataTable tabla = new PlayerControler().GetUserNameByTeam(Team1);
            string[] Players = tabla.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string a = "a";
            // FillTeam1Players(name);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNamesPlayersTeam1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
