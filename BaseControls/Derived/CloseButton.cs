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
    public partial class CloseButton : Button
    {
        public CloseButton()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            var FrmCurrentParentForm = FindForm();
            if (FrmCurrentParentForm == null) return;
            FrmCurrentParentForm.Close();
        }      
    }
}
