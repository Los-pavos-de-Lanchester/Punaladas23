using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DominioMensaje;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEncriptar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje(tbTextoInicial.Text);
            tbTextoFinal.Text = mensaje.cifradoCesar().ToString();//No funcion el to string
        }
    }
}
