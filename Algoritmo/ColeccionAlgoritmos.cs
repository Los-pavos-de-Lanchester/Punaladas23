using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoEncriptacion
{
    public class ColeccionAlgoritmos : KeyedCollection<string, Algoritmo>
    {
        protected override string GetKeyForItem(Algoritmo item)
        {
            return item.Nombre;
        }
    }
}
