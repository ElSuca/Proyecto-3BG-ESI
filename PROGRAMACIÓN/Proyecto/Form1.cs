using CapDeDatos;
using Proyecto.Backoffice;
using Proyecto.IniciosSeccion;
using System;
using System.Windows.Forms;
namespace Proyecto
{
    public partial class Form1 : Form
    {
        public static int Choice = new SafeSystemBuffer().GetMenu1Choice();
        public static bool start = false;
        public Form1()
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
            else if (Choice == 1) ; //OpenLoggingMenu();
            else if (Choice == 2) new BackofficeManager().Show();
            else if (Choice == 3) OpenRegisterMenu();
            else if (Choice == 4) new FormLanguageMenu().Show();
        }

      
        public void OpenRegisterMenu()
        {
          /*  if (!MainPanel.Contains(RegisterMenu.Instance))
            {
                MainPanel.Controls.Add(RegisterMenu.Instance);
                RegisterMenu.Instance.Dock = DockStyle.Fill;
                RegisterMenu.Instance.BringToFront();
            }
            else  RegisterMenu.Instance.BringToFront(); 
        }
        public void OpenLoggingMenu()
        {
            if (!MainPanel.Contains(LoggingMenu.Instance))
            {
                MainPanel.Controls.Add(LoggingMenu.Instance);
                LoggingMenu.Instance.Dock = DockStyle.Fill;
                LoggingMenu.Instance.BringToFront();
            }
            else  LoggingMenu.Instance.BringToFront(); */
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
       

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
