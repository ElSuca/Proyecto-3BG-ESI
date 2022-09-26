using CapaLoogica;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormLanguageMenu : Form
    {
        public FormLanguageMenu()
        {
            InitializeComponent();
            Traduction(new AplicationControler().getLanguage());
        }
        private void LanguageMenu_Load(object sender, EventArgs e)
        {
            ComboBoxLanguage.SelectedItem = 0;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            new AplicationControler().setLanguage(ComboBoxLanguage.FindStringExact(ComboBoxLanguage.Text));
            Traduction(new AplicationControler().getLanguage());
            new StarterMenu();
            new Form1().Refresh();
         

        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Traduction(int l)
        {
            if (l == 0) btnApply.Text = "Apply";
            else btnApply.Text = "Aplicar";
        }
    }
}
