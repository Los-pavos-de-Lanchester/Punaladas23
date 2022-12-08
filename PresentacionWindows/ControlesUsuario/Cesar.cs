using PresentacionWindows.ControlesUsuario;
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
    public partial class Cesar : UserControl, IControlAlgoritmo
    {
        public Cesar()
        {
            InitializeComponent();
        }

        private void tbClave_TextChanged(object sender, EventArgs e)
        {

        }

        public string[] Clave
        {
            get { return new string[1] { this.tbClave.Text }; }
        }
    }
}
