namespace PresentacionWindows
{
    partial class fSimple
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
            this.btEjecutar = new System.Windows.Forms.Button();
            this.cbListaMetodos = new System.Windows.Forms.ComboBox();
            this.laTextoInicial = new System.Windows.Forms.Label();
            this.laTextoFinal = new System.Windows.Forms.Label();
            this.laListaAlgoritmos = new System.Windows.Forms.Label();
            this.laDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.laClave = new System.Windows.Forms.Label();
            this.cbEncriptar = new System.Windows.Forms.CheckBox();
            this.cbDesencriptar = new System.Windows.Forms.CheckBox();
            this.btIntercambiarTexto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbrirArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuardarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTextoInicial
            // 
            this.tbTextoInicial.Location = new System.Drawing.Point(12, 89);
            this.tbTextoInicial.Multiline = true;
            this.tbTextoInicial.Name = "tbTextoInicial";
            this.tbTextoInicial.Size = new System.Drawing.Size(300, 150);
            this.tbTextoInicial.TabIndex = 0;
            this.tbTextoInicial.Text = "ALEA JACTA EST";
            // 
            // tbTextoFinal
            // 
            this.tbTextoFinal.Location = new System.Drawing.Point(506, 89);
            this.tbTextoFinal.Multiline = true;
            this.tbTextoFinal.Name = "tbTextoFinal";
            this.tbTextoFinal.ReadOnly = true;
            this.tbTextoFinal.Size = new System.Drawing.Size(300, 150);
            this.tbTextoFinal.TabIndex = 1;
            // 
            // btEjecutar
            // 
            this.btEjecutar.Location = new System.Drawing.Point(367, 206);
            this.btEjecutar.Name = "btEjecutar";
            this.btEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btEjecutar.TabIndex = 2;
            this.btEjecutar.Text = "Encriptar";
            this.btEjecutar.UseVisualStyleBackColor = true;
            this.btEjecutar.Click += new System.EventHandler(this.btEncriptar_Click);
            // 
            // cbListaMetodos
            // 
            this.cbListaMetodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaMetodos.FormattingEnabled = true;
            this.cbListaMetodos.Location = new System.Drawing.Point(346, 108);
            this.cbListaMetodos.Name = "cbListaMetodos";
            this.cbListaMetodos.Size = new System.Drawing.Size(121, 21);
            this.cbListaMetodos.TabIndex = 3;
            this.cbListaMetodos.SelectedIndexChanged += new System.EventHandler(this.cbListaMetodos_SelectedIndexChanged);
            // 
            // laTextoInicial
            // 
            this.laTextoInicial.AutoSize = true;
            this.laTextoInicial.Location = new System.Drawing.Point(12, 73);
            this.laTextoInicial.Name = "laTextoInicial";
            this.laTextoInicial.Size = new System.Drawing.Size(63, 13);
            this.laTextoInicial.TabIndex = 4;
            this.laTextoInicial.Text = "Texto inicial";
            // 
            // laTextoFinal
            // 
            this.laTextoFinal.AutoSize = true;
            this.laTextoFinal.Location = new System.Drawing.Point(503, 73);
            this.laTextoFinal.Name = "laTextoFinal";
            this.laTextoFinal.Size = new System.Drawing.Size(56, 13);
            this.laTextoFinal.TabIndex = 5;
            this.laTextoFinal.Text = "Texto final";
            // 
            // laListaAlgoritmos
            // 
            this.laListaAlgoritmos.AutoSize = true;
            this.laListaAlgoritmos.Location = new System.Drawing.Point(345, 92);
            this.laListaAlgoritmos.Name = "laListaAlgoritmos";
            this.laListaAlgoritmos.Size = new System.Drawing.Size(82, 13);
            this.laListaAlgoritmos.TabIndex = 6;
            this.laListaAlgoritmos.Text = "Lista algoritmos:";
            // 
            // laDescripcion
            // 
            this.laDescripcion.AutoSize = true;
            this.laDescripcion.Location = new System.Drawing.Point(9, 258);
            this.laDescripcion.Name = "laDescripcion";
            this.laDescripcion.Size = new System.Drawing.Size(66, 13);
            this.laDescripcion.TabIndex = 7;
            this.laDescripcion.Text = "Descripción:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(12, 275);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(300, 163);
            this.tbDescripcion.TabIndex = 9;
            this.tbDescripcion.TabStop = false;
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(344, 157);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(123, 20);
            this.tbClave.TabIndex = 10;
            this.tbClave.Text = "5";
            // 
            // laClave
            // 
            this.laClave.AutoSize = true;
            this.laClave.Location = new System.Drawing.Point(343, 141);
            this.laClave.Name = "laClave";
            this.laClave.Size = new System.Drawing.Size(37, 13);
            this.laClave.TabIndex = 11;
            this.laClave.Text = "Clave:";
            // 
            // cbEncriptar
            // 
            this.cbEncriptar.AutoCheck = false;
            this.cbEncriptar.AutoSize = true;
            this.cbEncriptar.Checked = true;
            this.cbEncriptar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEncriptar.Location = new System.Drawing.Point(329, 183);
            this.cbEncriptar.Name = "cbEncriptar";
            this.cbEncriptar.Size = new System.Drawing.Size(68, 17);
            this.cbEncriptar.TabIndex = 12;
            this.cbEncriptar.Text = "Encriptar";
            this.cbEncriptar.UseVisualStyleBackColor = true;
            this.cbEncriptar.Click += new System.EventHandler(this.cbEncriptar_Click);
            // 
            // cbDesencriptar
            // 
            this.cbDesencriptar.AutoCheck = false;
            this.cbDesencriptar.AutoSize = true;
            this.cbDesencriptar.Location = new System.Drawing.Point(414, 183);
            this.cbDesencriptar.Name = "cbDesencriptar";
            this.cbDesencriptar.Size = new System.Drawing.Size(86, 17);
            this.cbDesencriptar.TabIndex = 13;
            this.cbDesencriptar.Text = "Desencriptar";
            this.cbDesencriptar.UseVisualStyleBackColor = true;
            this.cbDesencriptar.Click += new System.EventHandler(this.cbDesencriptar_Click);
            // 
            // btIntercambiarTexto
            // 
            this.btIntercambiarTexto.Location = new System.Drawing.Point(367, 63);
            this.btIntercambiarTexto.Name = "btIntercambiarTexto";
            this.btIntercambiarTexto.Size = new System.Drawing.Size(75, 23);
            this.btIntercambiarTexto.TabIndex = 14;
            this.btIntercambiarTexto.Text = "<=====>";
            this.btIntercambiarTexto.UseVisualStyleBackColor = true;
            this.btIntercambiarTexto.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.tsmAbrirArchivo,
            this.tsmGuardarArchivo,
            this.tsmSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(158, 22);
            this.tsmNuevo.Text = "Nuevo";
            this.tsmNuevo.Click += new System.EventHandler(this.tsmNuevo_Click);
            // 
            // tsmAbrirArchivo
            // 
            this.tsmAbrirArchivo.Name = "tsmAbrirArchivo";
            this.tsmAbrirArchivo.Size = new System.Drawing.Size(158, 22);
            this.tsmAbrirArchivo.Text = "Abrir archivo";
            // 
            // tsmGuardarArchivo
            // 
            this.tsmGuardarArchivo.Name = "tsmGuardarArchivo";
            this.tsmGuardarArchivo.Size = new System.Drawing.Size(158, 22);
            this.tsmGuardarArchivo.Text = "Guardar archivo";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(158, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // fSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.btIntercambiarTexto);
            this.Controls.Add(this.cbDesencriptar);
            this.Controls.Add(this.cbEncriptar);
            this.Controls.Add(this.laClave);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.laDescripcion);
            this.Controls.Add(this.laListaAlgoritmos);
            this.Controls.Add(this.laTextoFinal);
            this.Controls.Add(this.laTextoInicial);
            this.Controls.Add(this.cbListaMetodos);
            this.Controls.Add(this.btEjecutar);
            this.Controls.Add(this.tbTextoFinal);
            this.Controls.Add(this.tbTextoInicial);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fSimple";
            this.Text = "Puñaladas23";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextoInicial;
        private System.Windows.Forms.TextBox tbTextoFinal;
        private System.Windows.Forms.Button btEjecutar;
        private System.Windows.Forms.ComboBox cbListaMetodos;
        private System.Windows.Forms.Label laTextoInicial;
        private System.Windows.Forms.Label laTextoFinal;
        private System.Windows.Forms.Label laListaAlgoritmos;
        private System.Windows.Forms.Label laDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label laClave;
        private System.Windows.Forms.CheckBox cbEncriptar;
        private System.Windows.Forms.CheckBox cbDesencriptar;
        private System.Windows.Forms.Button btIntercambiarTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrirArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmGuardarArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
    }
}

