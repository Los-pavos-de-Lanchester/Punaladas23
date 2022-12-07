using Encriptador;
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

        public fEditor(string nombre,string texto):this()
        {
            this.Texto = texto;
            this.Text = nombre;
        }

        public string Texto
        {
            get { return this.rtbEditor.Text; }
            set { this.rtbEditor.Text = value; }
        }

        public string encriptar()
        {
            CEncriptador encriptador= new CEncriptador(this.Texto);//dialogo de crecion por implementar
            fdialogoCriptografia fdialogo = new fdialogoCriptografia(CEncriptador.ListaALgortimosDescripcion);
            encriptador.AlgoritmoActualS = "Cesar";//fdialogo.AlgoritmoElegido;
            encriptador.ClaveS = "3";//fdialogo.ClaveElegida;

            return encriptador.cifrarString();
        }
    }

}
