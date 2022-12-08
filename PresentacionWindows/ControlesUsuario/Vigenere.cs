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
    public partial class Vigenere : UserControl,IControlAlgoritmo
    {
        public Vigenere()
        {
            InitializeComponent();
        }
        public string[] Clave
        {
            get { return new string[1] { this.tbClave.Text }; }
        }
    }


}
