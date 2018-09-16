namespace BaseForms.Forms
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.txtPara = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.adjuntarBtn = new BaseControls.Derived.OkButtonNoImage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new BaseControls.Derived.TextBasic();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArchivo = new BaseControls.Derived.TextBasic();
            this.txtMensaje = new BaseControls.Derived.TextBasic();
            this.lblEnviando = new System.Windows.Forms.Label();
            this.ckbIsHtml = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(259, 399);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(75, 40);
            this.okButton1.TabIndex = 1;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(376, 399);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 40);
            this.closeButton1.TabIndex = 2;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // txtPara
            // 
            this.txtPara.FormatoTexto = null;
            this.txtPara.Location = new System.Drawing.Point(119, 60);
            this.txtPara.Name = "txtPara";
            this.txtPara.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPara.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPara.Size = new System.Drawing.Size(445, 28);
            this.txtPara.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para:";
            // 
            // adjuntarBtn
            // 
            this.adjuntarBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adjuntarBtn.Location = new System.Drawing.Point(570, 125);
            this.adjuntarBtn.Name = "adjuntarBtn";
            this.adjuntarBtn.Size = new System.Drawing.Size(111, 37);
            this.adjuntarBtn.TabIndex = 5;
            this.adjuntarBtn.Text = "Adjuntar...";
            this.adjuntarBtn.UseVisualStyleBackColor = true;
            this.adjuntarBtn.Click += new System.EventHandler(this.adjuntarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.FormatoTexto = null;
            this.txtAsunto.Location = new System.Drawing.Point(119, 94);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAsunto.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtAsunto.Size = new System.Drawing.Size(445, 28);
            this.txtAsunto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Archivo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.FormatoTexto = null;
            this.txtArchivo.Location = new System.Drawing.Point(119, 129);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtArchivo.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(445, 28);
            this.txtArchivo.TabIndex = 8;
            // 
            // txtMensaje
            // 
            this.txtMensaje.FormatoTexto = null;
            this.txtMensaje.Location = new System.Drawing.Point(119, 163);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMensaje.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtMensaje.Size = new System.Drawing.Size(445, 215);
            this.txtMensaje.TabIndex = 10;
            // 
            // lblEnviando
            // 
            this.lblEnviando.AutoSize = true;
            this.lblEnviando.Location = new System.Drawing.Point(115, 381);
            this.lblEnviando.Name = "lblEnviando";
            this.lblEnviando.Size = new System.Drawing.Size(105, 24);
            this.lblEnviando.TabIndex = 11;
            this.lblEnviando.Text = "Enviando...";
            // 
            // ckbIsHtml
            // 
            this.ckbIsHtml.AutoSize = true;
            this.ckbIsHtml.Location = new System.Drawing.Point(570, 350);
            this.ckbIsHtml.Name = "ckbIsHtml";
            this.ckbIsHtml.Size = new System.Drawing.Size(70, 28);
            this.ckbIsHtml.TabIndex = 12;
            this.ckbIsHtml.Text = "Html";
            this.ckbIsHtml.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.AcceptButton = this.okButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(710, 472);
            this.Controls.Add(this.ckbIsHtml);
            this.Controls.Add(this.lblEnviando);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.adjuntarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.okButton1);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.txtPara, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.adjuntarBtn, 0);
            this.Controls.SetChildIndex(this.txtAsunto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtArchivo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMensaje, 0);
            this.Controls.SetChildIndex(this.lblEnviando, 0);
            this.Controls.SetChildIndex(this.ckbIsHtml, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.TextBasic txtPara;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.OkButtonNoImage adjuntarBtn;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.TextBasic txtAsunto;
        private System.Windows.Forms.Label label3;
        private BaseControls.Derived.TextBasic txtArchivo;
        private BaseControls.Derived.TextBasic txtMensaje;
        private System.Windows.Forms.Label lblEnviando;
        private System.Windows.Forms.CheckBox ckbIsHtml;
    }
}
