using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using AlgoritmoEncriptacion;
using CifradoCesar;
using CifradoVigenere;

namespace ColeccionEncriptacion
{
    public sealed class ColeccionAlgoritmos : KeyedCollection<string, Algoritmo>
    {
        private static ColeccionAlgoritmos algoritmos;
        private ColeccionAlgoritmos()
        {
            this.Add(new Cesar("Cesar", "El cifrado César, también conocido como cifrado por desplazamiento, código de César o desplazamiento de César, es una de las técnicas de cifrado más simples y más usadas. Es un tipo de cifrado por sustitución en el que una letra en el texto original es reemplazada por otra letra que se encuentra un número fijo de posiciones más adelante en el alfabeto. Por ejemplo, con un desplazamiento de 3, la A sería sustituida por la D (situada 3 lugares a la derecha de la A), la B sería reemplazada por la E, etc. Este método debe su nombre a Julio César, que lo usaba para comunicarse con sus generales."));
            this.Add(new Vigenere("Vigenere", "El cifrado Vigenère es un cifrado basado en diferentes series de caracteres o letras del cifrado César formando estos caracteres una tabla, llamada tabla de Vigenère, que se usa como clave. El cifrado de Vigenère es un cifrado por sustitución simple polialfabético."));
        }
        protected override string GetKeyForItem(Algoritmo item)
        {
            return item.Nombre;
        }

        public static ColeccionAlgoritmos Algoritmos//Patrón singleton
        {
            get
            {
                if (ColeccionAlgoritmos.algoritmos == null) ColeccionAlgoritmos.algoritmos = new ColeccionAlgoritmos();
                return ColeccionAlgoritmos.algoritmos;
            }
        }
    }

}
