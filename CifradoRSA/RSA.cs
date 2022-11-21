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
            //return new Mensaje(this.encriptacion(mensaje.CadenaI, clave.CadenaI[0], clave.CadenaI[1], clave.CadenaI[2]));
            return null;
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
        public static int[] encriptacion(int[] mensaje, int p, int q, int e)
        {
            int[] cifrado = new int[mensaje.Length];
            int n = p * q;
            int d = calcularClave(p,q,e);

            for (int i=0;i<mensaje.Length;i++)
            {
                int aux = (int)(Math.Pow(mensaje[i],d))%n;
                cifrado[i] = aux;
            }
            
            return cifrado;
        }

        public static int calcularClave(int p,int q,int e)
        {
            int z = (p - 1) * (q - 1);
            int j = calcularCongruencia(z,e);
            return j;
        }

        private static int calcularCongruencia(int z, int k)
        {
            int x = 1;
            while (true)
            {
                if ((1 + x * z)%k == 0)
                {
                    return (1 + x * z) / k;
                }
                x++;
                
            }
        }

        //Convierte la clave en el tipo requerido por la impelmentación (int)
        private int codificarClave(Mensaje clave)
        {
            return Convert.ToInt32(clave.CadenaS);
        }
    }

}
