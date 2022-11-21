namespace PresentacionWindows
{
    public partial class Cesar
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
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(85, 30);
            this.tbClave.Name = "tbClave";
            this.tbClave.PasswordChar = '*';
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 0;
            this.tbClave.UseSystemPasswordChar = true;
            this.tbClave.TextChanged += new System.EventHandler(this.tbClave_TextChanged);
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(29, 30);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(37, 13);
            this.lClave.TabIndex = 1;
            this.lClave.Text = "Clave:";
            // 
            // Cesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lClave);
            this.Controls.Add(this.tbClave);
            this.Name = "Cesar";
            this.Size = new System.Drawing.Size(268, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lClave;
    }
}
