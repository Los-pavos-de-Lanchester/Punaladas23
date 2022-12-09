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
        private Mensaje[] clave;
        //Posibles argumentos adicioneales
        private Mensaje[] args;

        //Comportamiento del encriptador (algoritmo empleado para el cifrado)
        private Algoritmo algoritmoActual;

        internal Mensaje Texto { get { return texto; } set { texto = value; } }

        internal Mensaje[] Clave { get { return clave; } set { clave = value; } }

        internal Mensaje[] Args { get { return args; } set { args = value; } }

        internal Algoritmo AlgoritmoActual { get { return algoritmoActual; } set { this.algoritmoActual = value; } }

        public string AlgoritmoActualS { get { return algoritmoActual.Nombre; } set { this.algoritmoActual = coleccionAlgoritmos[value]; } }

        public string TextoS//apaño
        {
            get { return this.texto.ToString(); }
            set { this.Texto = new Mensaje(value); }
        }

        public string ClaveS//Solo devuelve el primero
        {
            get { return this.clave[0].ToString(); }
            set { this.Clave = new Mensaje[1]; this.Clave[0] = new Mensaje(value); }
        }

        public string[] ClavesS
        {
            /*get { return this.clave }*/
            set
            {
                Mensaje[] mensajes=new Mensaje[value.Length];
                for(int i = 0,n = value.Length;i<n;i++) { mensajes[i] = new Mensaje(value[i]); }
            }
        }

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
            this.args = null;
        }

        public CEncriptador(string texto):this()
        {
            this.texto = new Mensaje(texto);
        }
        public CEncriptador(string texto, string clave):this() {//optimizable llamada al constructor de abajpo?
            this.texto=new Mensaje(texto);
            this.clave = new Mensaje[1];
            this.clave[0] = new Mensaje(clave);
        }

        public CEncriptador(string texto, string[] clave) : this()
        {
            int n = clave.Length;
            this.texto = new Mensaje(texto);
            this.clave = new Mensaje[n];
            for(int i = 0; i< n; i++)this.clave[i] = new Mensaje(clave[i]);
        }

        internal CEncriptador(Mensaje texto) : this()
        {
            this.texto = texto;
        }
        internal CEncriptador(Mensaje texto,Mensaje clave):this()
        {//optimizable llamada al constructor de abajpo?
            this.texto = texto;
            this.clave = new Mensaje[1];
            this.clave[0] = clave;
        }

        internal CEncriptador(Mensaje texto, Mensaje[] clave) : this()
        {
            this.texto = texto;
            this.clave = clave;
        }

        internal CEncriptador(Mensaje texto,Mensaje clave,Algoritmo algoritmoActual): this(texto,clave)
        {
            this.algoritmoActual = algoritmoActual;
        }

        internal CEncriptador(Mensaje texto, Mensaje[] clave, Algoritmo algoritmoActual) : this(texto,clave)
        {
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
