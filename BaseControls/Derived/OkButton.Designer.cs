namespace BaseControls.Derived
{
    partial class OkButton
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkButton));
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.Size = new System.Drawing.Size(75, 40);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
