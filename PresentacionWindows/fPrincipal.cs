using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ModeloDominio;
using Encriptador;
using CifradoCesar;
using AlgoritmoEncriptacion;
using CifradoVigenere;

namespace PresentacionWindows
{
    public partial class fPrincipal : Form
    {
        ColeccionAlgoritmos coleccionAlgoritmos;
        public fPrincipal()
        {
            coleccionAlgoritmos = new ColeccionAlgoritmos();
            this.coleccionAlgoritmos.Add(new Cesar("Cesar", "El cifrado César, también conocido como cifrado por desplazamiento, código de César o desplazamiento de César, es una de las técnicas de cifrado más simples y más usadas. Es un tipo de cifrado por sustitución en el que una letra en el texto original es reemplazada por otra letra que se encuentra un número fijo de posiciones más adelante en el alfabeto. Por ejemplo, con un desplazamiento de 3, la A sería sustituida por la D (situada 3 lugares a la derecha de la A), la B sería reemplazada por la E, etc. Este método debe su nombre a Julio César, que lo usaba para comunicarse con sus generales."));
            this.coleccionAlgoritmos.Add(new Vigenere("Vigenere", "El cifrado Vigenère es un cifrado basado en diferentes series de caracteres o letras del cifrado César formando estos caracteres una tabla, llamada tabla de Vigenère, que se usa como clave. El cifrado de Vigenère es un cifrado por sustitución simple polialfabético."));
            InitializeComponent();
            foreach(Algoritmo algoritmo in coleccionAlgoritmos)
            {
                this.cbListaMetodos.Items.Add(algoritmo.Nombre);
            }
            this.cbListaMetodos.SelectedIndex = 0;
            this.btEncriptar_Click(null, null);
        }

        private void btEncriptar_Click(object sender, EventArgs e)
        {
            //Almacena el texto en un Mensaje
            Mensaje mensaje = new Mensaje(tbTextoInicial.Text);
            //Crea el encriptador pasándole el Mensaje
            CEncriptador encriptador = new CEncriptador(mensaje);
            //Establece el algoritmo de encriptado
            encriptador.AlgoritmoActual = coleccionAlgoritmos[0];
            //Cifra, traduce a cadena y muestra el texto al usuario
            tbTextoFinal.Text = encriptador.cifrar().textoS();
        }

        private void Form1_Load(object sender, EventArgs e)//Se muestra al ejecutar el programa
        {
            MessageBox.Show("Creado por Los Pavos Hacen Gluglú\nGracias por usar la aplicación.\nPor favor, no hagas cosas malas ;)");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbListaMetodos_SelectedIndexChanged(object sender, EventArgs e)//Lo que sucede cuando se selecciona un algoritmo
        {
            //Muestra la descripcion del algoritmo
            this.tbDescripcion.Text = this.coleccionAlgoritmos[cbListaMetodos.Text].Descripcion;
        }
    }
}
