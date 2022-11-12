using CapaLoogica;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApiPublica.ExtendedMenu
{
    public partial class FormMenuResult1vs1Extend : Form
    {
        public int IdTeam1 { get; set; }
        public int IdTeam2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Competition { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Date { get; set; }
        public string Stadium { get; set; }
        public string Manager1 { get; set; }
        public string Manager2 { get; set; }

        public FormMenuResult1vs1Extend()
        {
            InitializeComponent();
            GetData();
            SetDefaults();
            Traduction(new AplicationControler().Language);
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
            lbEndTime.Text = EndTime;
            lbDate.Text = Date;
            lbUbication.Text = Stadium;
            lbManagerTeam1.Text = Manager1;
            lbManagerTeam2.Text = Manager2;
        }
        public void GetData()
        {
            IdTeam1 = FormPincipalMenu.IdTeam1;
            IdTeam2 = FormPincipalMenu.IdTeam2;
            Team1 = FormPincipalMenu.Team1;
            Team2 = FormPincipalMenu.Team2;
            Score1 = FormPincipalMenu.Score1;
            Score2 = FormPincipalMenu.Score2;
            Competition = FormPincipalMenu.Competition;
            StartTime = FormPincipalMenu.StartTime;
            EndTime = FormPincipalMenu.EndTime;
            Date = FormPincipalMenu.Date;
            Stadium = FormPincipalMenu.Stadium;
            Manager1 = new ManagerControler().GetNameByTeam(IdTeam1);
            Manager2 = new ManagerControler().GetNameByTeam(IdTeam2);

            dataGridTeam1.DataSource =  new PlayerControler().GetUserNameByTeam(IdTeam1);
            dataGridTeam2.DataSource = new PlayerControler().GetUserNameByTeam(IdTeam2);          
        }

        private void MenuResult1vs1Extend_Load(object sender, System.EventArgs e)
        {
          //  DataTable tabla = new PlayerControler().GetUserNameByTeam(Team1);
           // string[] Players = tabla.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            string a = "a";
            // FillTeam1Players(name);
        }
        private void Traduction(int l)
        {
            if (l == 0)
            {
                lbMachInfo.Text = "Match Info";
                lbMachInfo.Location = new Point(72, 11);
                lbStartTimeInf.Text = "Start";
                lbEndTimeInf.Text = "End";
                lbCompetitioninf.Text = "Competition";
                lbUbicationInf.Text = "Stadium";
                lbDateInf.Text = "Date";
            }
            else
            {
                lbMachInfo.Text = "Información del partido";
                lbMachInfo.Location = new Point(5, 11);
                lbStartTimeInf.Text = "Inicio";
                lbEndTimeInf.Text = "Final";
                lbCompetitioninf.Text = "Competición";
                lbUbicationInf.Text = "Estadio";
                lbDateInf.Text = "Fecha";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNamesPlayersTeam1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonaaa_Click(object sender, System.EventArgs e)
        {
            //FillTeam1Players("a");
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

    }
}
                