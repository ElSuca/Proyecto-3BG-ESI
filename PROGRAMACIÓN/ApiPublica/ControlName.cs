using System.Windows.Forms;

namespace ApiPublica
{
    public partial class ControlName : UserControl
    {
        private static ControlName _instance;

        public static ControlName Instance
        {
            get {
                if (_instance == null) _instance = new ControlName();
                return _instance;
             }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }

        public ControlName()
        {
            InitializeComponent();
        }

        private void lbName_Click(object sender, System.EventArgs e)
        {

        }
    }
}
