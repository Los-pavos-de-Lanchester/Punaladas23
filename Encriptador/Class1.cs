using CifradoCesar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DominioMensaje;
using CifradoCesar;

namespace Encriptador
{
    public class CEncriptador
    {
        Mensaje texto;

        Mensaje Texto { get { return texto; } set { texto = value; } }

        public CEncriptador(Mensaje texto) { this.texto = texto; }



        public char[] cifradoCesar()
        {
            return AlgoritmoCifradoCesar.encriptarCesar(texto.textoC(), 5);
        }

    }
}
