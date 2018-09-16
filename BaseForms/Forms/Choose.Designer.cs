namespace BaseForms.Forms
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.label1 = new System.Windows.Forms.Label();
            this.gridChoose = new System.Windows.Forms.DataGridView();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.okButton1 = new BaseControls.Derived.OkButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar:";
            // 
            // gridChoose
            // 
            this.gridChoose.AllowUserToAddRows = false;
            this.gridChoose.AllowUserToDeleteRows = false;
            this.gridChoose.AllowUserToOrderColumns = true;
            this.gridChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChoose.Location = new System.Drawing.Point(2, 35);
            this.gridChoose.MultiSelect = false;
            this.gridChoose.Name = "gridChoose";
            this.gridChoose.ReadOnly = true;
            this.gridChoose.RowHeadersVisible = false;
            this.gridChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridChoose.Size = new System.Drawing.Size(389, 203);
            this.gridChoose.StandardTab = true;
            this.gridChoose.TabIndex = 0;
            this.gridChoose.DoubleClick += new System.EventHandler(this.gridChoose_DoubleClick);
            this.gridChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridChoose_KeyDown);
            this.gridChoose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridChoose_KeyPress);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(219, 247);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 2;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(110, 247);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 40);
            this.okButton1.TabIndex = 1;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(392, 296);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.gridChoose);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Choose";
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.Choose_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gridChoose, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridChoose;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton okButton1;
    }
}