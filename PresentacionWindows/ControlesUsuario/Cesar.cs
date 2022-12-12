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
    public sealed partial class Cesar : IControlAlgoritmo
    {
        public Cesar()
        {
            InitializeComponent();
        }

        private void mtbClave_TextChanged(object sender, EventArgs e)
        {

        }

        public override string[] Clave
        {
            get { return new string[1] { this.mtbClave.Text }; }
        }

        public override string[] Args { get { return null; } }
    }
}
