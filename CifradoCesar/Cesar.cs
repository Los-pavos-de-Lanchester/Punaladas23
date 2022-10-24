﻿using System;
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

        public Cesar(string nombre, string descripcion) : base(nombre, descripcion) { }

        //Los dos siguientes métodos abstraen el algoritmo de la clase Mensaje
        public override Mensaje encriptar(Mensaje mensaje,Mensaje clave)
        {
            return new Mensaje(this.encriptacion(mensaje, this.codificarClave(clave)));
        }
        public override Mensaje desEncriptar(Mensaje mensaje,Mensaje clave)
        {
            return new Mensaje(this.encriptacion(mensaje, -this.codificarClave(clave)));//Por implementar
        }

        //agoritmo de encriptacion
        private char[] encriptacion(Mensaje mensaje, int clave)
        {
            char[] texto = mensaje.textoC();
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

        //private void fuerzaBruta(Mensaje mensaje)
        //{

        //}

        //Convierte la clave en el tipo requerido por la impelmentación (int)
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.textoS());
        }
    }
}
