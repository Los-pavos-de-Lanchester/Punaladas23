using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    public class AlgoritmoCifradoCesar
    {
        public static char[] encriptarCesar(string mensaje, int corr)
        {
            char[] cifrado = new char[mensaje.Length];
            for (int i = 0; i < mensaje.Length; i++)
            {
                if (mensaje[i] != ' ')
                {
                    cifrado[i] = Convert.ToChar((Convert.ToInt16(mensaje[i]) + corr) % 26 + Convert.ToInt16('a'));
                }
            }

            return cifrado;
        }
    }
}
