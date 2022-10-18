using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Mensaje
    {
        char[] texto;

        public Mensaje(char[] texto)
        {
            this.texto = texto;
        }
        public Mensaje(string texto)
        {
            this.texto = stringAChar(texto);
        }


        public string textoS()
        {
            return charAstring(this.texto);
        }

        public char[] textoC()
        {
            return this.texto;
        }


        //convierte char a string
        public static string charAstring(char[] cadena)
        {
            string cadenaS = "";
            foreach (char c in cadena)
            {
                if (c == '\0') cadenaS += " ";//EL espacio llega como \0
                else cadenaS += c;
            }
            return cadenaS;
        }
        //convierte string a char
        public static char[] stringAChar(string cadena)
        {
            char[] cadenaC = new char[cadena.Length];
            for (int i = 0; i < cadenaC.Length; i++)
            {
                cadenaC[i] = (char)cadena[i];
            }
            return cadenaC;
        }

    }
}