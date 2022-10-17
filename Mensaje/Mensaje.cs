using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CifradoCesar;
using DescifradoCesar;

namespace DominioMensaje
{
    public class Mensaje
    {
        string texto;

        string Texto { get
            {
                return texto; 
            }
            set { texto = value; }
            }

        public Mensaje(string texto)
        {
            this.texto = texto;
        }

        public char[] cifradoCesar()
        {
            return AlgoritmoCifradoCesar.encriptarCesar(texto,5);
        }
    }
}
