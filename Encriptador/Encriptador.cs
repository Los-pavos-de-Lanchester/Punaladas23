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
        //Comportamiento del encriptador (algoritmo empleado para el cifrado)
        Algoritmo algoritmoActual;

        public Mensaje Texto { get { return texto; } set { texto = value; } }

        public Algoritmo AlgoritmoActual { get { return algoritmoActual; } set { this.algoritmoActual = value; } }
        //Constructores
        public CEncriptador(Mensaje texto) { this.texto = texto; this.algoritmoActual = null; }
        public CEncriptador(Mensaje texto,Algoritmo algoritmoActual) { this.texto = texto; this.algoritmoActual = algoritmoActual; }

        //Devuelve el mensaje encriptado
        public Mensaje cifrar()
        {
            return this.algoritmoActual.encriptar(this.texto);
        }

    }
}
