using AlgoritmoEncriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio;

namespace CifradoVigenere
{
    public class Vigenere:Algoritmo
    {
        public Vigenere(string nombre, string descripcion) : base(nombre, descripcion)
        {
        }

        public override Mensaje desEncriptar(Mensaje mensaje, Mensaje clave)
        {
            return null;
        }

        //agoritmo de encriptacion
        private char[] encriptacion(Mensaje mensaje, Mensaje clave)
        {
            char[] texto = mensaje.textoC();
            char[] cifrado = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + clave.textoC()[i%(clave.textoC().Length)] - 2*Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
                }
                
            }

            return cifrado;
        }
        //Convierte la clave en el tipo requerido por la impelmentación (int)
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.textoS());
        }

        public override Mensaje encriptar(Mensaje mensaje, Mensaje clave)
        {
            return new Mensaje(encriptacion(mensaje,clave));
        }
    }
}
