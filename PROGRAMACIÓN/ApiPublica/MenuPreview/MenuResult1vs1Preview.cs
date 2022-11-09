using ApiPublica.ExtendedMenu;
using System;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class MenuResult1vs1PreviewModel : UserControl
    {
        private string _team1;
        private string _team2;
        private string _competition;
        private string _startTime;
        private string _endTime;
        private string _date;
        private string _stadium;
        private int _score1;
        private int _score2;

        public string Team1
        {
            get { return _team1; }
            set { _team1 = value; lbTeam1.Text = value;}
        }
        public string Team2 
        {
            get { return _team2; }
            set { _team2 = value; lbTeam2.Text = value;}
        }
        public int Score1
        {
            get { return _score1; }
            set { _score1 = value; lbResult1.Text = value.ToString();}
        }
        public int Score2
        {
            get { return _score2; }
            set { _score2 = value; lbResult2.Text = value.ToString(); }
        }
        public string Competition
        {
            get { return _competition; }
            set { _competition = value;}
        }
        public string StartTime
        {
            get { return _startTime; }
            set { _startTime = value;}
        }
        public string EndTime
        {
            get { return _endTime; }
            set { _endTime = value;}
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; lbDate.Text = value; }
        }
        public string Stadium
        {
            get { return _stadium; }
            set { _stadium = value;}
        }

        public MenuResult1vs1PreviewModel()
        {
            InitializeComponent();
        }

        private void MenuResult1vs1PreviewModel_Click(object sender, EventArgs e)
        {
            new FormPincipalMenu().ShowFullInformation(_team1, _team2,_competition,_startTime,_endTime,_date,_stadium,_score1,_score2);
        }

        private void lbTeam2_Click(object sender, EventArgs e)
        {

        }
    }
}
