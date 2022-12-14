using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmoEncriptacion;
using ModeloDominio;

namespace CifradoCesar
{
    public sealed class Cesar: Algoritmo
    {

        public Cesar(string nombre, string descripcion) : base(nombre, descripcion) { }

        //Los cuatro siguientes métodos abstraen el algoritmo de la clase Mensaje
        public override Mensaje encriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(this.encriptacion(mensaje, this.codificarClave(clave[0])));
        }
        public override Mensaje desEncriptarMensaje(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            return new Mensaje(this.encriptacion(mensaje, -this.codificarClave(clave[0])));
        }
        public override void encriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaI=this.encriptarMensaje(mensaje, clave).CadenaI;
        }
        public override void desEncriptar(Mensaje mensaje, Mensaje[] clave, Mensaje[] args = null)
        {
            mensaje.CadenaI=this.desEncriptarMensaje(mensaje, clave).CadenaI;
        }

        //agoritmo de encriptacion
        private char[] encriptacion(Mensaje mensaje, int clave)
        {
            char[] texto = mensaje.CadenaC;
            char[] cifrado = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    if (texto[i]<= Convert.ToInt16('z') && texto[i] >= Convert.ToInt16('a')) {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) - Convert.ToInt16('a') + clave) % 26 + Convert.ToInt16('a'));
                    }
                    else
                    {
                        cifrado[i] = Convert.ToChar((Convert.ToInt16(texto[i]) - Convert.ToInt16('A') + clave) % 26 + Convert.ToInt16('A'));
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

    }
}
