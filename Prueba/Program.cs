using CifradoRSA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;
using CifradoAES;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int p, q, e;
            p = 3;
            q = 5;
            e = 7;
            int[] mensaje = new int[14];
            for (int i =0; i<14;i++)
            {
                mensaje[i] = i;
            }
            int aux =  Rsa.calcularClave(p,q,e);
            Console.WriteLine("La clave es:");
            Console.WriteLine(aux);
            int[] sol = Rsa.encriptacion(mensaje,p,q,e);

            Console.WriteLine("La encriptación es:");

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(sol[i]);
            }

            Console.WriteLine("La desencriptación es:");

            sol = Rsa.desencriptacion(sol, p, q, e);

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(sol[i]);
            }

            Console.ReadLine();
            */

            /*
            Aes myAes = Aes.Create();
            foreach(byte b in myAes.Key)
            {
                Console.WriteLine(b);
            }
            //Console.WriteLine(myAes.Key);
            Console.ReadLine();
            */
            

            
            AES aes = new AES("","");

            ModeloDominio.Mensaje encriptado = aes.encriptarMensaje(new ModeloDominio.Mensaje("Hola"), null, null);

            Console.WriteLine(encriptado);

            ModeloDominio.Mensaje desencriptado = aes.desEncriptarMensaje(encriptado, null, null);

            Console.WriteLine(desencriptado);
            Console.ReadLine();
            
        }
    }
}
