using CapaLoogica;
using System.Windows.Forms;

namespace ApiPublica.ExtendedMenu
{
    public partial class MenuResult1vs1Extend : UserControl
    {
        public MenuResult1vs1Extend()
        {
            InitializeComponent();
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

        private void panelNamesPlayersTeam2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNamesPlayersTeam1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuResult1vs1Extend_Load(object sender, System.EventArgs e)
        {
            SendRequest.GetPost("http://127.0.0.1:8888//autenticar", txtUserName.Text, txtPassword.Text);

            new PlayerControler()
            FillTeam1Players(name);
        }
    }
}
