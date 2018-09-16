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
    public partial class ComboBasic : ComboBox  
    {
        public ComboBasic()
        {
            InitializeComponent();
        }

        private void ComboBasic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)(Keys.Enter)) return;
            e.Handled = true;
            SendKeys.Send("{TAB}");
        }

        //private void ComboBasic_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode != (Keys.Enter)) return;
        //    e.Handled = true;
        //    SendKeys.Send("{TAB}");
        //}
    }
}
