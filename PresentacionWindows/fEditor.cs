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

        public string encriptar(bool encriptacion)
        {
            CEncriptador encriptador= new CEncriptador(this.Texto);//dialogo de crecion por implementar
            fDialogo fdialogo = new fDialogo(CEncriptador.ListaALgortimosDescripcion);
            fdialogo.ShowDialog();//modal
            if (fdialogo.Resultado != DialogResult.OK) return null;//Si no se realiza

            encriptador.AlgoritmoActualS = fdialogo.Algoritmo;
            encriptador.ClavesS = fdialogo.Clave;
            if(encriptacion) return encriptador.cifrarString();
            return  encriptador.desCifrarString();
        }
    }

}
