using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmoEncriptacion;
using ModeloDominio;

namespace CifradoCesar
{
    public class AlgoritmoCesar: Algoritmo
    {
        int corr;

        public AlgoritmoCesar(int corr=5)
        {
            this.corr = corr;
        }

        public Mensaje encriptar(Mensaje mensaje)
        {
            char[] texto = mensaje.textoC();
            char[] cifrado = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + corr) % 26 + Convert.ToInt16('a'));
                }
            }

            return new Mensaje(cifrado);
        }

        public override string ToString()
        {
            return "Cesar";
        }
    }
}
