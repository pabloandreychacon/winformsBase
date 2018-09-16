using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseControls.Derived
{
    public partial class ExitButton : Button
    {
        public ExitButton()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Application.Exit();
        }
    }
}
