using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiPublica
{
    public partial class MenuResultPreviewModel : UserControl
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Date { get; set; }

        public MenuResultPreviewModel()
        {
            InitializeComponent();
            setData();
        }

        private void setData()
        {
            lbTeam1.Text = Team1;
            lbTeam2.Text = Team2;
            lbResult1.Text = Score1.ToString();
            lbResult2.Text = Score2.ToString();
            lbDate.Text = Date;
        }

        private void lbAdCategory_Click(object sender, EventArgs e)
        {

        }

        private void MenuResultPreviewModel_Load(object sender, EventArgs e)
        {

        }
    }
}
