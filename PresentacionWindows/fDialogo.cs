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
    public partial class fDialogo : Form, IControlAlgoritmo
    {
        private DialogResult resultado;
        private Dictionary<string, string> algoritmos;
        private IControlAlgoritmo controlAlgoritmo;

        public DialogResult Resultado { get { return this.resultado; } }
        public fDialogo()
        {
            InitializeComponent();
            this.resultado = DialogResult.None;
        }

        public fDialogo(Dictionary<string,string> algoritmos):this()
        {
            foreach(string algoritmo in algoritmos.Keys)
            {
                this.cbAlgoritmos.Items.Add(algoritmo);
            }
        }

        public string Algoritmo
        {
            get { return this.cbAlgoritmos.Text; }
        }

        public string[] Clave
        {
            get { /*return this.controlAlgoritmo.Clave;*/return new string[1] { "3" }; }//prueba
        }

        private void cbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbDescripcion.Text = this.algoritmos[this.cbAlgoritmos.Text];
        }
    }
}
