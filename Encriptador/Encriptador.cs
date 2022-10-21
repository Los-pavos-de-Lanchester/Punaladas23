using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio;
using AlgoritmoEncriptacion;

namespace Encriptador
{
    public class CEncriptador
    {
        //Mensaje suceptible de ser encriptado
        Mensaje texto;
        //Mensaje que contiene la clave
        Mensaje clave;
        //Comportamiento del encriptador (algoritmo empleado para el cifrado)
        Algoritmo algoritmoActual;

        internal Mensaje Texto { get { return texto; } set { texto = value; } }

        public Algoritmo AlgoritmoActual { get { return algoritmoActual; } set { this.algoritmoActual = value; } }
        //Constructores
        public CEncriptador(string texto, string clave) {
            this.texto=new Mensaje(texto);
            this.clave = new Mensaje(clave);
        }
        internal CEncriptador(Mensaje texto,Mensaje clave) {
            this.texto = texto;
            this.clave = clave;
            this.algoritmoActual = null;
        }
        internal CEncriptador(Mensaje texto,Mensaje clave,Algoritmo algoritmoActual)
        {
            this.texto = texto;
            this.clave=clave;
            this.algoritmoActual = algoritmoActual;
        }

        //Devuelve el mensaje encriptado
        internal Mensaje cifrarMensaje()
        {
            return this.algoritmoActual.encriptar(this.texto,this.clave);
        }
        //Devuelve una cadena que contiene el texto cifrado
        public string cifrarString()
        {
            return this.cifrarMensaje().textoS();
        }


        //Devuelve el mensaje desencriptado
        internal Mensaje desCifrarMensaje()
        {
            return this.algoritmoActual.desEncriptar(this.texto, this.clave);
        }
        //Devuelve una cadena que contiene el texto descifrado
        public string desCifrarString()
        {
            return this.desCifrarMensaje().textoS();
        }

    }
}
