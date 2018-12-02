namespace BaseForms.Forms
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
			this.txtExpression = new BaseControls.Derived.TextBasic();
			this.cboOrderBy = new BaseControls.Derived.ComboBasic();
			this.gridResults = new System.Windows.Forms.DataGridView();
			this.closeButton1 = new BaseControls.Derived.CloseButton();
			this.okButton1 = new BaseControls.Derived.OkButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
			this.SuspendLayout();
			// 
			// txtExpression
			// 
			this.txtExpression.FormatoTexto = null;
			this.txtExpression.Location = new System.Drawing.Point(160, 24);
			this.txtExpression.Margin = new System.Windows.Forms.Padding(5);
			this.txtExpression.Name = "txtExpression";
			this.txtExpression.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtExpression.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtExpression.Size = new System.Drawing.Size(276, 28);
			this.txtExpression.TabIndex = 0;
			this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
			// 
			// cboOrderBy
			// 
			this.cboOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboOrderBy.Location = new System.Drawing.Point(160, 69);
			this.cboOrderBy.Margin = new System.Windows.Forms.Padding(5);
			this.cboOrderBy.Name = "cboOrderBy";
			this.cboOrderBy.Size = new System.Drawing.Size(274, 30);
			this.cboOrderBy.TabIndex = 1;
			this.cboOrderBy.SelectedIndexChanged += new System.EventHandler(this.cboOrderBy_SelectedIndexChanged);
			// 
			// gridResults
			// 
			this.gridResults.AllowUserToAddRows = false;
			this.gridResults.AllowUserToDeleteRows = false;
			this.gridResults.AllowUserToOrderColumns = true;
			this.gridResults.AllowUserToResizeRows = false;
			this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridResults.Location = new System.Drawing.Point(20, 169);
			this.gridResults.Margin = new System.Windows.Forms.Padding(5);
			this.gridResults.MultiSelect = false;
			this.gridResults.Name = "gridResults";
			this.gridResults.ReadOnly = true;
			this.gridResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridResults.Size = new System.Drawing.Size(823, 254);
			this.gridResults.StandardTab = true;
			this.gridResults.TabIndex = 2;
			this.gridResults.DoubleClick += new System.EventHandler(this.gridResults_DoubleClick);
			this.gridResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridResults_KeyDown);
			this.gridResults.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridResults_KeyPress_1);
			// 
			// closeButton1
			// 
			this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
			this.closeButton1.Location = new System.Drawing.Point(452, 454);
			this.closeButton1.Margin = new System.Windows.Forms.Padding(5);
			this.closeButton1.Name = "closeButton1";
			this.closeButton1.Size = new System.Drawing.Size(125, 68);
			this.closeButton1.TabIndex = 4;
			this.closeButton1.TabStop = false;
			this.closeButton1.UseVisualStyleBackColor = true;
			// 
			// okButton1
			// 
			this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
			this.okButton1.Location = new System.Drawing.Point(287, 454);
			this.okButton1.Margin = new System.Windows.Forms.Padding(5);
			this.okButton1.Name = "okButton1";
			this.okButton1.Size = new System.Drawing.Size(125, 68);
			this.okButton1.TabIndex = 3;
			this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Buscar:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 83);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ordenar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 142);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Resultados:";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(160, 117);
			this.lblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(0, 24);
			this.lblMessage.TabIndex = 8;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton1;
			this.ClientSize = new System.Drawing.Size(863, 545);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.okButton1);
			this.Controls.Add(this.closeButton1);
			this.Controls.Add(this.gridResults);
			this.Controls.Add(this.cboOrderBy);
			this.Controls.Add(this.txtExpression);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
			this.Name = "Search";
			this.Text = "Buscar";
			this.Load += new System.EventHandler(this.Search_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.txtExpression, 0);
			this.Controls.SetChildIndex(this.cboOrderBy, 0);
			this.Controls.SetChildIndex(this.gridResults, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.okButton1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.lblMessage, 0);
			((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.TextBasic txtExpression;
        private BaseControls.Derived.ComboBasic cboOrderBy;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton okButton1;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
    }
}