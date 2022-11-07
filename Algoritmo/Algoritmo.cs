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

        public abstract Mensaje encriptarMensaje(Mensaje mensaje, Mensaje clave);
        public abstract Mensaje desEncriptarMensaje(Mensaje mensaje, Mensaje clave);
        public abstract void encriptar(Mensaje mensaje, Mensaje clave);
        public abstract void desEncriptar(Mensaje mensaje, Mensaje clave);

        public override string ToString()
        {
            return "Algoritmo " + this.nombre;
        }
    }
}
