using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Choose : Basic
    {
        public int SelectedKey { get; set; }
        public string StringSelectedKey { get; set; }
        public string KeyToReturn { get; set; }
        public DataTable MainTableList { get; set; }
        private bool KeyIsString = false;

        public Choose(DataTable searchTable, string keyToReturn, bool keyIsString = false)
        {
            InitializeComponent();
            MainTableList = searchTable;
            KeyToReturn = keyToReturn;
            KeyIsString = keyIsString;
        }

        private void Choose_Load(object sender, EventArgs e)
        {
            gridChoose.DataSource = MainTableList;
        }

        private void gridChoose_DoubleClick(object sender, EventArgs e)
        {
            okButton1.PerformClick();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (gridChoose.CurrentRow != null)
            {
                if (KeyIsString)
                {
                    StringSelectedKey = (string)gridChoose.CurrentRow.Cells[KeyToReturn].Value;
                }
                else
                {
                    SelectedKey = Convert.ToInt16(gridChoose.CurrentRow.Cells[KeyToReturn].Value);
                }
            }
        }

        private void gridChoose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void gridChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Set event as handled.  
                e.Handled = true;
            } 
        }
    }
}
