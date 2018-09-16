namespace BaseForms.Forms
{
    partial class Scripts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scripts));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.ejecutarBtn = new BaseControls.Derived.OkButtonNoImage();
            this.txtConexion = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtScript = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(546, 698);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(131, 41);
            this.closeButton1.TabIndex = 1;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // ejecutarBtn
            // 
            this.ejecutarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ejecutarBtn.Location = new System.Drawing.Point(393, 698);
            this.ejecutarBtn.Name = "ejecutarBtn";
            this.ejecutarBtn.Size = new System.Drawing.Size(131, 41);
            this.ejecutarBtn.TabIndex = 3;
            this.ejecutarBtn.Text = "Ejecutar";
            this.ejecutarBtn.UseVisualStyleBackColor = true;
            this.ejecutarBtn.Click += new System.EventHandler(this.ejecutarBtn_Click);
            // 
            // txtConexion
            // 
            this.txtConexion.FormatoTexto = null;
            this.txtConexion.Location = new System.Drawing.Point(12, 36);
            this.txtConexion.Name = "txtConexion";
            this.txtConexion.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtConexion.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtConexion.Size = new System.Drawing.Size(1046, 28);
            this.txtConexion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conexión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Script:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 372);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(1046, 312);
            this.dgvResults.TabIndex = 8;
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(12, 97);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(1046, 269);
            this.txtScript.TabIndex = 9;
            // 
            // Scripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(1070, 753);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConexion);
            this.Controls.Add(this.ejecutarBtn);
            this.Controls.Add(this.closeButton1);
            this.KeyPreview = true;
            this.Name = "Scripts";
            this.Text = "Script";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scripts_KeyDown);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.ejecutarBtn, 0);
            this.Controls.SetChildIndex(this.txtConexion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgvResults, 0);
            this.Controls.SetChildIndex(this.txtScript, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButtonNoImage ejecutarBtn;
        private System.Windows.Forms.Label label1;
        public BaseControls.Derived.TextBasic txtConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtScript;
    }
}
