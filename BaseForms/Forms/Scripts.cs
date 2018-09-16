using BaseHelpers.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseForms.Forms
{
    public partial class Scripts : BaseForms.Forms.Basic
    {
        public Scripts()
        {
            InitializeComponent();
        }

        private void ejecutarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtScript.Text);
                //using (var connection = new SqlConnection(pConnection))
                //{
                var connection = new SqlConnection(txtConexion.Text);
                //using (var cmd = new SqlCommand(pSql, connection))
                //{
                var cmd = new SqlCommand(txtScript.Text, connection);
                connection.Open();
                //using (var results = cmd.ExecuteReader())
                //{
                //    return results;
                //}
                var reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    //Console.WriteLine("\t{0}\t{1}", reader.GetName(0),
                    //    reader.GetName(1));
                    bindingSource1.DataSource = reader;
                    dgvResults.DataSource = bindingSource1;
                    while (reader.Read())
                    {
                        //Console.WriteLine("\t{0}\t{1}", reader.GetInt32(0),
                        //    reader.GetString(1));
                        Debug.WriteLine(reader.GetValue(1));
                    }
                    reader.NextResult();
                }

                //if (reader.HasRows) 
                //{
                //    bindingSource1.DataSource = reader;
                //    dgvResults.DataSource = bindingSource1;
                //    //var dt = new DataTable();
                //    //dt.Load(results);
                //    //dgvResults.AutoGenerateColumns = true;
                //    //dgvResults.DataSource = dt;
                //    //dgvResults.Refresh();
                //}
                //reader.NextResult();
                //while (reader.Read())
                //{
                //    Debug.WriteLine(reader.GetValue(1));
                //    //MessageBox.Show("From third SQL - " + sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                //}
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("There was an error in executing the SQL. " + "Error Message:" + ex.Message);
                MessageBox.Show(ex.Message, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void Scripts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ejecutarBtn.PerformClick();
            }
        }
    }
}
