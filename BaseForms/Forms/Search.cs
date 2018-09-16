using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Search : Basic
    {
        public string SelectedKey;
        public string TableOrderList { get; set; }
        public string KeyToReturn { get; set; }
        public DataTable MainTableList { get; set; }

        /// <summary>
        /// form usado para mostrar un listado de ciertos campos de una tabla
        /// para hacer una buisqueda
        /// </summary>
        /// <param name="searchTable">dt con la lista sin filtrar</param>
        /// <param name="order">como se ordena la busqueda, llena el combo</param>
        /// <param name="keyToReturn">campo que retorna el form</param>
        public Search(DataTable searchTable, string order, string keyToReturn)
        {
            InitializeComponent();
            TableOrderList = order;
            MainTableList = searchTable;
            KeyToReturn = keyToReturn;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadOrderList();
            gridResults.DataSource = MainTableList;
            //ColumnSizesArray[] = 
            //gridResults.ClearSelection();
        }

        private void SelectData()
        {
            var queryStringFilter = cboOrderBy.Text + " like '%" + txtExpression.Text.Trim() + "%'";
            var fileteredRows = MainTableList.Select(queryStringFilter);
            //// con LINQ solo filtra campos de texto
            //var results = from myRows in _mainTableList.AsEnumerable()
            //              where myRows.Field<string>(cboOrderBy.Text).Contains(txtExpression.Text.Trim())
            //              select myRows;
            //var tableResults = results.CopyToDataTable();
            //gridResults.DataSource = tableResults;
            if (fileteredRows.Count() > 0) 
            {
                gridResults.DataSource = fileteredRows.CopyToDataTable();
                for (int i = 0; i < gridResults.Columns.Count; i++)
			    {
                    //gridResults.Columns[i].Width = ColumnSizesArray[i];
                    gridResults.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			    }
            }
            else 
            {
                gridResults.DataSource = null;
            }
            //gridResults.ClearSelection();
        }

        private void LoadOrderList()
        {
            var Separators = new[] { ',' };
            var KeysList = TableOrderList.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            if (KeysList.Length <= 0) return;
            cboOrderBy.Items.Clear();
            foreach (var T in KeysList)
            {
                cboOrderBy.Items.Add(T.Trim());
            }
            cboOrderBy.SelectedIndex = 0;
        }

        private void gridResults_DoubleClick(object sender, EventArgs e)
        {
            okButton1.PerformClick();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (gridResults.SelectedRows.Count > 0)
            {
                if (gridResults.CurrentRow.Selected)
                {
                    //SelectedKey = (int)dataGridViewResults.CurrentRow.Cells["Pos"].Value;
                    
                    SelectedKey = Convert.ToString(gridResults.CurrentRow.Cells[KeyToReturn].Value);
                }
            }
        }

        private void cboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectData();
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {
            SelectData();
        }

        private void gridResults_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void gridResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Set event as handled.  
                e.Handled = true;
            } 
        }
        
    }
}
