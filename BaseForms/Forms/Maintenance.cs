using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Maintenance : Basic
    {
        public bool newRecord = false;

        [Category("Control Data")]
        [Description("Tipo de valor")]
        public string OrderKeys { get; set; }
        public string Sizes { get; set; }

        //[Category("Control Data")]
        //[Description("Tipo de valor")]
        //public DataTable SearchTable { get; set; }

        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control item in Controls)
            {
                if (item is BindingNavigator)
                {
                    item.TabStop = true;
                    break;
                }
            }
            SelectMainData();
            BindControls();
        }

        public virtual void BindControls()
        {
            // en el hijo
        }

        public virtual void SelectMainData()
        {
            // en el hijo
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // en el hijo
        }

        public virtual void PopulateFields()
        {
            // en el hijo
        }

        public virtual void Add(string descrip, string codigo)
        {
            // en el hijo
        }

        public virtual void EnableEdition(bool enable)
        {
            btnFind.Enabled = enable;
        }

        public virtual bool ValidateFields()
        {
            // valida en el hijo
            return true;
        }
        
    }
}
