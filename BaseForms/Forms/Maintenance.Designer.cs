namespace BaseForms.Forms
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(504, 28);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(38, 32);
            this.closeButton1.TabIndex = 1;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(467, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 32);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(543, 417);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.closeButton1);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public BaseControls.Derived.CloseButton closeButton1;
        public System.Windows.Forms.Button btnFind;
    }
}