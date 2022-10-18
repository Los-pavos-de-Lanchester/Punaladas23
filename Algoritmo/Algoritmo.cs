using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ModeloDominio;

namespace AlgoritmoEncriptacion
{
    public interface Algoritmo
    {
        Mensaje encriptar(Mensaje mensaje);
    }
}
