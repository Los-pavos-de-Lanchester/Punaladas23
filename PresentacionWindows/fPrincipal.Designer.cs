﻿namespace PresentacionWindows
{
    partial class fPrincipal
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
            this.laTextoAEncriptado = new System.Windows.Forms.Label();
            this.laTExtoEncriptado = new System.Windows.Forms.Label();
            this.laListaAlgoritmos = new System.Windows.Forms.Label();
            this.laDescripcion = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
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
            // btEncriptar
            // 
            this.btEncriptar.Location = new System.Drawing.Point(371, 216);
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
            this.cbListaMetodos.SelectedIndexChanged += new System.EventHandler(this.cbListaMetodos_SelectedIndexChanged);
            // 
            // laTextoAEncriptado
            // 
            this.laTextoAEncriptado.AutoSize = true;
            this.laTextoAEncriptado.Location = new System.Drawing.Point(139, 73);
            this.laTextoAEncriptado.Name = "laTextoAEncriptado";
            this.laTextoAEncriptado.Size = new System.Drawing.Size(87, 13);
            this.laTextoAEncriptado.TabIndex = 4;
            this.laTextoAEncriptado.Text = "Texto a encriptar";
            // 
            // laTExtoEncriptado
            // 
            this.laTExtoEncriptado.AutoSize = true;
            this.laTExtoEncriptado.Location = new System.Drawing.Point(565, 73);
            this.laTExtoEncriptado.Name = "laTExtoEncriptado";
            this.laTExtoEncriptado.Size = new System.Drawing.Size(87, 13);
            this.laTExtoEncriptado.TabIndex = 5;
            this.laTExtoEncriptado.Text = "Texto encriptado";
            // 
            // laListaAlgoritmos
            // 
            this.laListaAlgoritmos.AutoSize = true;
            this.laListaAlgoritmos.Location = new System.Drawing.Point(348, 121);
            this.laListaAlgoritmos.Name = "laListaAlgoritmos";
            this.laListaAlgoritmos.Size = new System.Drawing.Size(79, 13);
            this.laListaAlgoritmos.TabIndex = 6;
            this.laListaAlgoritmos.Text = "Lista algoritmos";
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
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(731, 415);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(12, 275);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(300, 163);
            this.tbDescripcion.TabIndex = 9;
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.laDescripcion);
            this.Controls.Add(this.laListaAlgoritmos);
            this.Controls.Add(this.laTExtoEncriptado);
            this.Controls.Add(this.laTextoAEncriptado);
            this.Controls.Add(this.cbListaMetodos);
            this.Controls.Add(this.btEncriptar);
            this.Controls.Add(this.tbTextoFinal);
            this.Controls.Add(this.tbTextoInicial);
            this.Name = "fPrincipal";
            this.Text = "Puñaladas23";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextoInicial;
        private System.Windows.Forms.TextBox tbTextoFinal;
        private System.Windows.Forms.Button btEncriptar;
        private System.Windows.Forms.ComboBox cbListaMetodos;
        private System.Windows.Forms.Label laTextoAEncriptado;
        private System.Windows.Forms.Label laTExtoEncriptado;
        private System.Windows.Forms.Label laListaAlgoritmos;
        private System.Windows.Forms.Label laDescripcion;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}
