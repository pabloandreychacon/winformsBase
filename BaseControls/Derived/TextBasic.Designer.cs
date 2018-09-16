namespace BaseControls.Derived
{
    partial class TextBasic
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
            this.SuspendLayout();
            // 
            // TextBasic
            // 
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBasic_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBasic_KeyPress);
            this.Leave += new System.EventHandler(this.TextBasic_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TextBasic_Validating);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
