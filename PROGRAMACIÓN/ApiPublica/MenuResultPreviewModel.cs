using System;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class MenuResultPreviewModel : UserControl
    {
        private string _team1;
        private string _team2;
        private string _date;
        private int _score1;
        private int _score2;

        public string Team1
        {
            get { return _team1; }
            set { _team1 = value; lbTeam1.Text = value; }
        }
        public string Team2
        {
            get { return _team2; }
            set { _team2 = value; lbTeam2.Text = value; }
        }

        public int Score1
        {
            get { return _score1; }
            set { _score1 = value; lbResult1.Text = value.ToString(); }
        }

        public int Score2
        {
            get { return _score2; }
            set { _score2 = value; lbResult2.Text = value.ToString(); }
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; lbDate.Text = value; }
        }

        public MenuResultPreviewModel()
        {
            InitializeComponent();
        }

      

        private void lbAdCategory_Click(object sender, EventArgs e)
        {

        }

        private void MenuResultPreviewModel_Load(object sender, EventArgs e)
        {

        }
    }
}
