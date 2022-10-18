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

        public override Mensaje encriptar(Mensaje mensaje)
        {
            return null;
        }

    }
}
