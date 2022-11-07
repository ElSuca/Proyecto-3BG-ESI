using System.Windows.Forms;

namespace ApiPublica
{
    public partial class ControlName : UserControl
    {
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
    }
}
