namespace PresentacionWindows
{
    partial class fDialogo
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.lAlgoritmo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(364, 290);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(102, 290);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // cbAlgoritmos
            // 
            this.cbAlgoritmos.FormattingEnabled = true;
            this.cbAlgoritmos.Location = new System.Drawing.Point(45, 50);
            this.cbAlgoritmos.Name = "cbAlgoritmos";
            this.cbAlgoritmos.Size = new System.Drawing.Size(121, 21);
            this.cbAlgoritmos.TabIndex = 2;
            this.cbAlgoritmos.SelectedIndexChanged += new System.EventHandler(this.cbAlgoritmos_SelectedIndexChanged);
            // 
            // lAlgoritmo
            // 
            this.lAlgoritmo.AutoSize = true;
            this.lAlgoritmo.Location = new System.Drawing.Point(42, 34);
            this.lAlgoritmo.Name = "lAlgoritmo";
            this.lAlgoritmo.Size = new System.Drawing.Size(53, 13);
            this.lAlgoritmo.TabIndex = 3;
            this.lAlgoritmo.Text = "Algoritmo:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(45, 142);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(210, 103);
            this.tbDescripcion.TabIndex = 4;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(42, 117);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción:";
            // 
            // fDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 358);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lAlgoritmo);
            this.Controls.Add(this.cbAlgoritmos);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Name = "fDialogo";
            this.Text = "Dialogo encriptacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ComboBox cbAlgoritmos;
        private System.Windows.Forms.Label lAlgoritmo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lDescripcion;
    }
}