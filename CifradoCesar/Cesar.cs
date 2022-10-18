using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmoEncriptacion;
using ModeloDominio;

namespace CifradoCesar
{
    public class Cesar: Algoritmo
    {
        int corr;

        public Cesar(string nombre,string descripcion,int corr=5):base(nombre,descripcion)
        {
            this.corr = corr;
        }

        public override Mensaje encriptar(Mensaje mensaje)
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

    }
}
