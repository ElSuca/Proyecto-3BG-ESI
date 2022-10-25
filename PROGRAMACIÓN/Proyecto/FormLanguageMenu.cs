using CapaLoogica;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormLanguageMenu : Form
    {
        public FormLanguageMenu()
        {
            InitializeComponent();
            traduction(new AplicationControler().getLanguage());
        }
        private void languageMenu_Load(object sender, EventArgs e)
        {
            ComboBoxLanguage.SelectedItem = 0;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\..\\Config.txt";
            File.WriteAllText(path,"Language ="+ComboBoxLanguage.FindStringExact(ComboBoxLanguage.Text));

            using (StreamReader archivo = File.OpenText(path))
            {
                string linea = null;
                int i = 0;
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    if (++i == 2) break;
                }

                int selection = Int32.Parse(linea[10].ToString());
                new AplicationControler().setLanguage(selection);
            }
            traduction(new AplicationControler().getLanguage());
            new StarterMenu();
            new FormPincipal().Refresh();
        }
        private void traduction(int l)
        {
            if (l == 0) btnApply.Text = "Apply";
            else btnApply.Text = "Aplicar";
        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
