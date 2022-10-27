using System;
using System.IO;
using System.Windows.Forms;
using ApiPublica;
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
        private void languageMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {        
        }
        private void traduction(int l)
        {
            if (l == 0)
            {       
                checkBoxEnglish.Text = "English";
                checkBoxSpanish.Text = "Spanish";
            }
            else
            {             
                checkBoxEnglish.Text = "Ingles";
                checkBoxSpanish.Text = "Español";
            }
        }

        private void changelanguage(int lang)
        {
            string path = "..\\..\\..\\Config.txt";
            File.WriteAllText(path, $"Language = {lang}");

            using (StreamReader archivo = File.OpenText(path))
            {
                string linea = null;
                int i = 0;
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    if (++i == 2) break;
                }

                int selection = Int32.Parse(linea[11].ToString());
                new AplicationControler().setLanguage(selection);
            }
            traduction(new AplicationControler().getLanguage());
        }


        private void LanguageMenu_Load_1(object sender, EventArgs e)
        {

        }
        private void lbBack_Click(object sender, EventArgs e)
        {
            new FormPincipalMenu().GetPanelMenuVisivility();
        }

        private void checkBoxSpanish_CheckStateChanged(object sender, EventArgs e)
        {
            changelanguage(1);
            checkBoxEnglish.Checked = false;
        }

        private void checkBoxEnglish_CheckedChanged(object sender, EventArgs e)
        {
            changelanguage(0);
            checkBoxSpanish.Checked = false;
        }

        private void checkBoxSpanish_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

