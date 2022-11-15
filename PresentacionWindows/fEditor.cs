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
        public fEditor()
        {
            InitializeComponent();
        }

        public fEditor(string nombre,string texto):base()
        {
            this.Texto = texto;
            this.Text = nombre;
        }

        public string Texto
        {
            get { return this.rtbEditor.Text; }
            set { this.rtbEditor.Text = value; }
        }
    }
}
