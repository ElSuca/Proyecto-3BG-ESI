using CapDeDatos;
using Proyecto.Backoffice;
using Proyecto.IniciosSeccion;
using System;
using System.Windows.Forms;
namespace Proyecto
{
    public partial class FormPincipal : Form
    {
        public static bool start = false;
        public FormPincipal()
        { 
            InitializeComponent();
            if (!start)
            {
                loadMenu(0);
                start = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void setSelection(int choice)
        {
            loadMenu(choice);
        }
        private void loadMenu(int Choice)
        {
            if (Choice == 0) OpenMainMenu();
            else if (Choice == 2) new BackofficeManager().Show();
            else if (Choice == 4) new FormLanguageMenu().Show();
        }
        public void OpenMainMenu()
        {
            if (!MainPanel.Contains(StarterMenu.Instance))
            {
                MainPanel.Controls.Add(StarterMenu.Instance);
                StarterMenu.Instance.Dock = DockStyle.Fill;
                StarterMenu.Instance.BringToFront();
            }
            else  StarterMenu.Instance.BringToFront(); 
        }
        public void OpenLanguageMenu()
        {
            if (!MainPanel.Contains(LanguageMenu.Instance))
            {
                MainPanel.Controls.Add(LanguageMenu.Instance);
                LanguageMenu.Instance.Dock = DockStyle.Fill;
                LanguageMenu.Instance.BringToFront();
            }
            else LanguageMenu.Instance.BringToFront();
        } 
        public void CloseApp()
        {
            this.Close();
        }
        public void GetAppVisivility(bool n)
        {
            this.Visible = n;
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
