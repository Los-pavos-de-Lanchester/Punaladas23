using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio;
using AlgoritmoEncriptacion;
using ColeccionEncriptacion;
using System.Collections.ObjectModel;

namespace Encriptador
{
    public class CEncriptador
    {
        //Lista de algoritmos disponibles común a todos
        private static ColeccionAlgoritmos coleccionAlgoritmos = ColeccionAlgoritmos.Algoritmos;

        //Mensaje suceptible de ser encriptado
        private Mensaje texto;
        //Mensaje que contiene la clave
        private Mensaje clave;

        //Comportamiento del encriptador (algoritmo empleado para el cifrado)
        private Algoritmo algoritmoActual;

        internal Mensaje Texto { get { return texto; } set { texto = value; } }

        internal Mensaje Clave { get { return clave; } set { texto = value; } }

        internal Algoritmo AlgoritmoActual { get { return algoritmoActual; } set { this.algoritmoActual = value; } }

        public string AlgoritmoActualS { get { return algoritmoActual.Nombre; } set { this.algoritmoActual = coleccionAlgoritmos[value]; } }

        public static List<string> ListaAlgoritmosS
        {
            get 
            {
                List<string> lista = new List<string>();
                foreach(Algoritmo i in CEncriptador.coleccionAlgoritmos)
                {
                    lista.Add(i.Nombre);
                }
                return lista;
            }
        }
        
        public static Dictionary<string,string> ListaALgortimosDescripcion
        {
            get
            {
                Dictionary<string,string> lista = new Dictionary<string,string>();
                foreach (Algoritmo i in CEncriptador.coleccionAlgoritmos)
                {
                    lista.Add(i.Nombre, i.Descripcion);
                }
                return lista;
            }
        }

        //Constructores
        public CEncriptador()
        {
            this.texto = null;
            this.clave = null;
            this.algoritmoActual = null;
        }
        public CEncriptador(string texto, string clave):this() {
            this.texto=new Mensaje(texto);
            this.clave = new Mensaje(clave);
        }
        internal CEncriptador(Mensaje texto,Mensaje clave):this() {
            this.texto = texto;
            this.clave = clave;
        }
        internal CEncriptador(Mensaje texto,Mensaje clave,Algoritmo algoritmoActual): this()
        {
            this.texto = texto;
            this.clave=clave;
            this.algoritmoActual = algoritmoActual;
        }

        //Devuelve el mensaje encriptado
        internal Mensaje cifrarMensaje()
        {
            return this.algoritmoActual.encriptarMensaje(this.texto,this.clave);
        }
        //Devuelve una cadena que contiene el texto cifrado
        public string cifrarString()
        {
            return this.cifrarMensaje().CadenaS;
        }


        //Devuelve el mensaje desencriptado
        internal Mensaje desCifrarMensaje()
        {
            return this.algoritmoActual.desEncriptarMensaje(this.texto, this.clave);
        }
        //Devuelve una cadena que contiene el texto descifrado
        public string desCifrarString()
        {
            return this.desCifrarMensaje().CadenaS;
        }

    }
}
