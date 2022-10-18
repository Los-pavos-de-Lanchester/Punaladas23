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
        Mensaje texto;
        Algoritmo algoritmoActual;

        public Mensaje Texto { get { return texto; } set { texto = value; } }

        public Algoritmo AlgoritmoActual { get { return algoritmoActual; } set { this.algoritmoActual = value; } }

        public CEncriptador(Mensaje texto) { this.texto = texto; algoritmoActual = null; }


        public Mensaje cifrar()
        {
            return this.algoritmoActual.encriptar(this.texto);
        }

    }
}
