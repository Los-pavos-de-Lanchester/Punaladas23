using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Encriptador;

namespace PresentacionWindows
{
    public partial class fSimple : Form
    {
        public fSimple()
        {
            InitializeComponent();
            foreach(string algoritmo in CEncriptador.ListaAlgoritmosS)
            {
                this.cbListaMetodos.Items.Add(algoritmo);
            }
            this.cbListaMetodos.SelectedIndex = 0;
            this.btEncriptar_Click(null, null);
        }
        //Proceso de ejecución
        private void btEncriptar_Click(object sender, EventArgs e)
        {
            //Crea el encriptador pasándole el Mensaje
            CEncriptador encriptador = new CEncriptador(tbTextoInicial.Text,tbClave.Text);
            //Establece el algoritmo de encriptado
            encriptador.AlgoritmoActualS = this.cbListaMetodos.Text;
            try
            {
                //Cifra/descifra, traduce a cadena y muestra el texto al usuario
                if (this.cbEncriptar.Checked) tbTextoFinal.Text = encriptador.cifrarString();
                else tbTextoFinal.Text = encriptador.desCifrarString();
            }
            catch (FormatException)//Clave no válida
            {
                MessageBox.Show("Clave no válida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejectar.\n\nMensaje: " + ex.Message);
            }
        }

        //Clic en el botón salir
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Actualización del algoritmo seleccionado
        private void cbListaMetodos_SelectedIndexChanged(object sender, EventArgs e)//Lo que sucede cuando se selecciona un algoritmo
        {
            //Muestra la descripcion del algoritmo
            this.tbDescripcion.Text = CEncriptador.ListaALgortimosDescripcion[cbListaMetodos.Text];
        }
        //Clic en encriptar
        private void cbEncriptar_Click(object sender, EventArgs e)
        {
            this.cbEncriptar.Checked = true;
            this.cbDesencriptar.Checked = false;
            this.btEjecutar.Text = this.cbEncriptar.Text;
        }
        //clic en desencriptar
        private void cbDesencriptar_Click(object sender, EventArgs e)
        {
            this.cbEncriptar.Checked = false;
            this.cbDesencriptar.Checked = true; ;
            this.btEjecutar.Text = this.cbDesencriptar.Text;
        }
        //Intercambia los valores de los textos al hacer clic
        private void button1_Click(object sender, EventArgs e)
        {
            string caja = this.tbTextoInicial.Text;
            this.tbTextoInicial.Text = this.tbTextoFinal.Text;
            this.tbTextoFinal.Text = caja;
            this.cbEncriptar.Checked=!this.cbEncriptar.Checked;
            this.cbDesencriptar.Checked=!this.cbDesencriptar.Checked;
        }

        private void tsmNuevo_Click(object sender, EventArgs e)
        {
            this.tbTextoInicial.Text = "";
            this.tbTextoFinal.Text = "";
            this.cbEncriptar_Click(null, null);
            this.cbListaMetodos.SelectedIndex = 0;
            this.tbClave.Text = "";
        }
    }
}
