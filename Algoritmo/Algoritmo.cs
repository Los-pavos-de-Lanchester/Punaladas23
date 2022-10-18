using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ModeloDominio;

namespace AlgoritmoEncriptacion
{
    public abstract class Algoritmo
    {
        string nombre;
        string descripcion;

        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }

        protected Algoritmo(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public abstract Mensaje encriptar(Mensaje mensaje);

        public override string ToString()
        {
            return "Algoritmo " + this.nombre;
        }
    }
}
