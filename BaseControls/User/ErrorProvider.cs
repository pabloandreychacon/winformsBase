using System.ComponentModel;
using System.Windows.Forms;

namespace BaseControls.User
{
    public partial class ErrorContainer : UserControl
    {
        public ErrorContainer()
        {
            InitializeComponent();
        }

        [Category("Control Data")]
        public System.Windows.Forms.Control Control { get; set; }

        [Category("Control Data")]
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                if (Control != null)
                {
                    errorProvider1.SetError(Control, Message);
                }
            }
        }
    }
}
