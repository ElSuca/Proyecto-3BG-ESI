using System;
using System.Windows.Forms;
using CapaLoogica;

namespace Proyecto
{
    public partial class LanguageMenu : UserControl
    {
        private static LanguageMenu _instance;

        public static LanguageMenu Instance
        {
            get
            {
                if (_instance == null) _instance = new LanguageMenu();
                return _instance;
            }
        }
        public LanguageMenu()
        {
            InitializeComponent();
            traduction(new AplicationControler().getLanguage());
        }
        private void LanguageMenu_Load(object sender, EventArgs e)
        {
            ComboBoxLanguage.SelectedItem = 0;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            new AplicationControler().setLanguage(ComboBoxLanguage.FindStringExact(ComboBoxLanguage.Text));
            traduction(new AplicationControler().getLanguage());
        }
        private void traduction(int l)
        {
            if (l == 0) btnApply.Text = "Aply";
            else btnApply.Text = "Aplicar";
        }
    }
}
