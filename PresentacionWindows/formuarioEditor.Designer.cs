namespace PresentacionWindows
{
    partial class fEditor
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
            this.rtEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtEditor
            // 
            this.rtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtEditor.Location = new System.Drawing.Point(0, 0);
            this.rtEditor.Name = "rtEditor";
            this.rtEditor.Size = new System.Drawing.Size(800, 450);
            this.rtEditor.TabIndex = 0;
            this.rtEditor.Text = "";
            // 
            // fEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtEditor);
            this.Name = "fEditor";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEditor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtEditor;
    }
}