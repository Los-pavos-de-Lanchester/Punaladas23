using AlgoritmoEncriptacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModeloDominio;
using System.Diagnostics.CodeAnalysis;

namespace CifradoVigenere
{
    public sealed class Vigenere:Algoritmo//revisar caabeceras encriptacion. Código repetido
    {
        public Vigenere(string nombre, string descripcion) : base(nombre, descripcion)
        {
        }

        public override Mensaje encriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(encriptacion(mensaje, clave[0]));
        }

        public override Mensaje desEncriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(encriptacion(mensaje, invertirClave(clave[0])));
        }

        public override void encriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaC = this.encriptacion(mensaje, clave[0]);
        }
        public override void desEncriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaC=this.desencriptacion(mensaje, clave[0]);
        }

        //agoritmo de encriptacion
        private char[] encriptacion(Mensaje mensaje, Mensaje clave)
        {
            char[] texto = mensaje.CadenaC;
            char[] cifrado = new char[texto.Length];
            Mensaje claveMinusculas = new Mensaje(clave.CadenaS.ToLower()); 
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (texto[i] <= Convert.ToInt16('z') && texto[i] >= Convert.ToInt16('a'))
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.CadenaC[i % (clave.CadenaC.Length)] - 2 * Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
                    }
                    else
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.CadenaC[i % (clave.CadenaC.Length)] - Convert.ToInt16('A') - Convert.ToInt16('a')) % 26 + Convert.ToInt16('A'));
                    }
                    
                }
                
            }

            return cifrado;
        }

        private char[] desencriptacion(Mensaje mensaje, Mensaje clave)
        {
            char[] texto = mensaje.CadenaC;
            char[] cifrado = new char[texto.Length];
            Mensaje claveMinusculasOriginal = new Mensaje(clave.CadenaS.ToLower());
            Mensaje claveMinusculas = invertirClave(claveMinusculasOriginal);
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (texto[i] <= Convert.ToInt16('z') && texto[i] >= Convert.ToInt16('a'))
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.CadenaC[i % (clave.CadenaC.Length)] - 2 * Convert.ToInt16('a')) % 26 + Convert.ToInt16('a'));
                    }
                    else
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) + claveMinusculas.CadenaC[i % (clave.CadenaC.Length)] - Convert.ToInt16('A') - Convert.ToInt16('a')) % 26 + Convert.ToInt16('A'));
                    }

                }

            }

            return cifrado;
        }
        //Convierte la clave en el tipo requerido por la impelmentación (int)
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.CadenaS);
        }

       public Mensaje invertirClave(Mensaje clave)
        {
            char[] inverso = new char[clave.CadenaS.Length];
            for (int i = 0; i < inverso.Length; i++)
            {
                int letra = Convert.ToInt16(clave.CadenaC[i]) - Convert.ToInt16('a');
                letra = 26 - letra;
                letra = letra + Convert.ToInt16('a');
                inverso[i] = Convert.ToChar(letra);
            }
            return new Mensaje(inverso);
        }

    }
}
