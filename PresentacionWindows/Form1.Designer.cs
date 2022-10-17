namespace PresentacionWindows
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTextoInicial = new System.Windows.Forms.TextBox();
            this.tbTextoFinal = new System.Windows.Forms.TextBox();
            this.btEncriptar = new System.Windows.Forms.Button();
            this.cbListaMetodos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbTextoInicial
            // 
            this.tbTextoInicial.Location = new System.Drawing.Point(139, 92);
            this.tbTextoInicial.Name = "tbTextoInicial";
            this.tbTextoInicial.Size = new System.Drawing.Size(101, 20);
            this.tbTextoInicial.TabIndex = 0;
            // 
            // tbTextoFinal
            // 
            this.tbTextoFinal.Location = new System.Drawing.Point(565, 91);
            this.tbTextoFinal.Name = "tbTextoFinal";
            this.tbTextoFinal.Size = new System.Drawing.Size(100, 20);
            this.tbTextoFinal.TabIndex = 1;
            // 
            // btEncriptar
            // 
            this.btEncriptar.Location = new System.Drawing.Point(348, 239);
            this.btEncriptar.Name = "btEncriptar";
            this.btEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btEncriptar.TabIndex = 2;
            this.btEncriptar.Text = "Encriptar";
            this.btEncriptar.UseVisualStyleBackColor = true;
            this.btEncriptar.Click += new System.EventHandler(this.btEncriptar_Click);
            // 
            // cbListaMetodos
            // 
            this.cbListaMetodos.FormattingEnabled = true;
            this.cbListaMetodos.Location = new System.Drawing.Point(348, 140);
            this.cbListaMetodos.Name = "cbListaMetodos";
            this.cbListaMetodos.Size = new System.Drawing.Size(121, 21);
            this.cbListaMetodos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbListaMetodos);
            this.Controls.Add(this.btEncriptar);
            this.Controls.Add(this.tbTextoFinal);
            this.Controls.Add(this.tbTextoInicial);
            this.Name = "Form1";
            this.Text = "Puñaladas23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextoInicial;
        private System.Windows.Forms.TextBox tbTextoFinal;
        private System.Windows.Forms.Button btEncriptar;
        private System.Windows.Forms.ComboBox cbListaMetodos;
    }
}

