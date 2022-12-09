using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows.ControlesUsuario
{
    public partial class Vigenere : IControlAlgoritmo
    {
        public Vigenere()
        {
            InitializeComponent();
        }
        public override string[] Clave
        {
            get { return new string[1] { this.tbClave.Text }; }
        }

        public override string[] Args { get { return null; } }
    }

}
