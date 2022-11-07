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
            clave = invertirClave(clave);
            return clave;
            //return new Mensaje(encriptacion(mensaje, clave));
        }

        //agoritmo de encriptacion
        private char[] encriptacion(Mensaje mensaje, Mensaje clave)
        {
            char[] texto = mensaje.textoC();
            char[] cifrado = new char[texto.Length];
            Mensaje claveMinusculas = new Mensaje(clave.textoS().ToLower()); 
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (texto[i] <= Convert.ToInt16('z') && texto[i] >= Convert.ToInt16('a'))
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.textoC()[i % (clave.textoC().Length)] - 2 * Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
                    }
                    else
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.textoC()[i % (clave.textoC().Length)] - Convert.ToInt16('A') - Convert.ToInt16('a')) % 26 + Convert.ToInt16('A'));
                    }
                    
                }
                
            }

            return cifrado;
        }

        private char[] desencriptacion(Mensaje mensaje, Mensaje clave)
        {
            char[] texto = mensaje.textoC();
            char[] cifrado = new char[texto.Length];
            Mensaje claveMinusculasOriginal = new Mensaje(clave.textoS().ToLower());
            Mensaje claveMinusculas = invertirClave(claveMinusculasOriginal);
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (texto[i] <= Convert.ToInt16('z') && texto[i] >= Convert.ToInt16('a'))
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.textoC()[i % (clave.textoC().Length)] - 2 * Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
                    }
                    else
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.textoC()[i % (clave.textoC().Length)] - Convert.ToInt16('A') - Convert.ToInt16('a')) % 26 + Convert.ToInt16('A'));
                    }

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

       public Mensaje invertirClave(Mensaje clave)
        {
            char[] inverso = new char[clave.textoS().Length];
            for (int i = 0; i < inverso.Length; i++)
            {
                inverso[i] = Convert.ToChar((26 - Convert.ToInt16(clave.textoC()[i]) - Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
            }
            return new Mensaje(inverso);
        }
    }
}
