namespace BaseForms.Forms
{
    partial class Basic
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basic));
			this.errorContainer1 = new BaseControls.User.ErrorContainer();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblInfoMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// errorContainer1
			// 
			this.errorContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.errorContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.errorContainer1.Control = null;
			this.errorContainer1.Location = new System.Drawing.Point(-1, 95);
			this.errorContainer1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.errorContainer1.Message = null;
			this.errorContainer1.Name = "errorContainer1";
			this.errorContainer1.Size = new System.Drawing.Size(14, 14);
			this.errorContainer1.TabIndex = 0;
			this.errorContainer1.TabStop = false;
			this.errorContainer1.Visible = false;
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblInfoMessage.AutoSize = true;
			this.lblInfoMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblInfoMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoMessage.ForeColor = System.Drawing.Color.Green;
			this.lblInfoMessage.Location = new System.Drawing.Point(59, 400);
			this.lblInfoMessage.Name = "lblInfoMessage";
			this.lblInfoMessage.Size = new System.Drawing.Size(2, 31);
			this.lblInfoMessage.TabIndex = 1;
			// 
			// Basic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(686, 472);
			this.Controls.Add(this.lblInfoMessage);
			this.Controls.Add(this.errorContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Basic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Base";
			this.Load += new System.EventHandler(this.Base_Load);
			this.DoubleClick += new System.EventHandler(this.Base_DoubleClick);
			this.MouseHover += new System.EventHandler(this.Basic_MouseHover);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public BaseControls.User.ErrorContainer errorContainer1;
        public System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.Label lblInfoMessage;
	}
}