using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class fEditor : Form
    {
        private bool modificado;

        public string Texto
        {
            get { return this.rtEditor.Text; }
            set { this.rtEditor.Text = value; }
        }
        public fEditor(string nombre,string texto):this()
        {
            this.Texto = texto;
            this.Text = nombre;
        }
        public fEditor()
        {
            modificado = false;
            InitializeComponent();
        }

        private void fEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modificado)
            {
                
            }
            return;
        }
    }
}
