using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public FormPincipalMenu()
        {
            InitializeComponent();
        }

        private void FillResults()
        {
            MenuResultPreviewModel[] listItem = new MenuResultPreviewModel[2];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new MenuResultPreviewModel();
                listItem[i].Team1 = Team1;
                listItem[i].Team2 = Team2;
                listItem[i].Score1 = Score1;
                listItem[i].Score2 = Score2;
                listItem[i].Date = Date;

                if (panelResult.Controls.Count > 0) panelResult.Controls.Clear();
                else panelResult.Controls.Add(listItem[i]);
            }
        }
        

        private void panelResult_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team1 = "t1";
            Team2 = "t2";
            Score1 = 1;
            Score2 = 2;
            Date = "10/5/2022 10:15";
            FillResults();
        }

        private void FormPincipalMenu_Load(object sender, EventArgs e)
        {
           // FillResults();
        }
    }
}
