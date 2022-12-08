namespace PresentacionWindows.ControlesUsuario
{
    partial class Vigenere
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(47, 43);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(37, 13);
            this.lClave.TabIndex = 0;
            this.lClave.Text = "Clave:";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(131, 43);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 1;
            this.tbClave.UseSystemPasswordChar = true;
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lClave);
            this.Name = "Vigenere";
            this.Size = new System.Drawing.Size(292, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.TextBox tbClave;
    }
}
