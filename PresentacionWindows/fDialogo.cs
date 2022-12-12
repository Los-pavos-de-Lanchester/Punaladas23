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
    public partial class fDialogo : Form
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
            this.algoritmos= algoritmos;
            foreach(string algoritmo in this.algoritmos.Keys)
            {
                this.cbAlgoritmos.Items.Add(algoritmo);
            }
            this.cbAlgoritmos.SelectedIndex = 0;
        }

        public string Algoritmo
        {
            get { return this.cbAlgoritmos.Text; }
        }

        public string[] Clave
        {
            get {return this.controlAlgoritmo.Clave;}//prueba
        }

        private void cbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)//Cuando se cambia el algoritmo
        {
            this.tbDescripcion.Text = this.algoritmos[this.cbAlgoritmos.Text];
            this.controlAlgoritmo = ControlUsuarioFactoria.getControlUsuario(this.cbAlgoritmos.Text);
            this.controlAlgoritmo.Location = new Point(200, 20);
            this.Controls.RemoveAt(this.Controls.Count-1);
            this.Controls.Add(controlAlgoritmo);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.resultado=DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.resultado = DialogResult.Cancel;
            this.Close();
        }
    }
}
