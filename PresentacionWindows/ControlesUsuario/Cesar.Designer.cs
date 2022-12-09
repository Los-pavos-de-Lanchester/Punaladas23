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
            this.lClave = new System.Windows.Forms.Label();
            this.mtbClave = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
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
            // mtbClave
            // 
            this.mtbClave.AsciiOnly = true;
            this.mtbClave.Location = new System.Drawing.Point(84, 30);
            this.mtbClave.Name = "mtbClave";
            this.mtbClave.Size = new System.Drawing.Size(100, 20);
            this.mtbClave.TabIndex = 2;
            // 
            // Cesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbClave);
            this.Controls.Add(this.lClave);
            this.Name = "Cesar";
            this.Size = new System.Drawing.Size(268, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.MaskedTextBox mtbClave;
    }
}
