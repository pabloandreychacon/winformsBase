using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Mdi : Form
    {
        const bool Promptonexit = true;
        public bool PromptOnExit = Promptonexit;
        [Category("Control Data"), Description("Control Application: Modulo actual"), DefaultValue("GENER")]
        public string Modulo { get; set; }

        public Mdi()
        {
            InitializeComponent();
        }

        private void Mdi_Load(object sender, EventArgs e)
        {            
            PromptOnExit = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\LunaSoftwareDevelopment\Control\", "PromptOnExit", "false"), CultureInfo.CurrentCulture);
        }

        private void Mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Mdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptOnExit) return;
            if (MessageBox.Show("Desea salir de la aplicación?", "Salir",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
