using CifradoRSA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            int[] sol = Rsa.encriptacion(mensaje,p,q,e);

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(sol[i]);
            }
            Console.WriteLine(sol.ToString());
            Console.ReadLine();
        }
    }
}
