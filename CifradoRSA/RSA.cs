using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmoEncriptacion;
using ModeloDominio;

namespace CifradoRSA
{
    public class Rsa : Algoritmo
    {

        public Rsa(string nombre, string descripcion) : base(nombre, descripcion) { }

        //Los cuatro siguientes métodos abstraen el algoritmo de la clase Mensaje
        public override Mensaje encriptarMensaje(Mensaje mensaje, Mensaje clave)
        {
            return new Mensaje(this.encriptacion(mensaje.CadenaI, clave.CadenaI[0], clave.CadenaI[1], clave.CadenaI[2]));
        }
        public override Mensaje desEncriptarMensaje(Mensaje mensaje, Mensaje clave)
        {
            return null;
        }
        public override void encriptar(Mensaje mensaje, Mensaje clave)
        {
            mensaje.CadenaI = this.encriptarMensaje(mensaje, clave).CadenaI;
        }
        public override void desEncriptar(Mensaje mensaje, Mensaje clave)
        {
            mensaje.CadenaI = this.desEncriptarMensaje(mensaje, clave).CadenaI;
        }

        //agoritmo de encriptacion
        private int[] encriptacion(int[] mensaje, int p, int q, int e)
        {
            int[] cifrado = new int[mensaje.Length];
            int n = p * q;
            int d = calcularClave(p,q,e);
            foreach (int i in mensaje)
            {
                cifrado[i] = (i^d)%n;
            }
            
            return cifrado;
        }

        private int calcularClave(int p,int q,int e)
        {

        }

        //Convierte la clave en el tipo requerido por la impelmentación (int)
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.CadenaS);
        }
    }

}
