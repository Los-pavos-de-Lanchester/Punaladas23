using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Mensaje : IEquatable<Mensaje>
    {
        //Almacena el cadena como un vector de tipo char
        int[] cadena;
        //Constructor a partir de char
        public Mensaje(char[] cadena)
        {
            this.cadena = charAInt(cadena);
        }
        //Constructor a partir de cadena
        public Mensaje(string cadena)
        {
            this.cadena = stringAInt(cadena);
        }
        //Constructor a partir de enteros
        public Mensaje(int[] cadena)
        {
            this.cadena = cadena;
        }


        //Get como cadena
        public string cadenaS()
        {
            return intAString(this.cadena);
        }
        //Get como char
        public char[] cadenaC()
        {
            return charAInt(this.cadena);
        }
        //Get como int
        public int[] cadenaI()
        {
            return this.cadena;
        }


        //set como int
        public void Cadena(int[] cadena)
        {
            this.cadena = cadena;
        }
        //set como char
        public void Cadena(char[] cadena)
        {
            this.cadena = charAInt(cadena);
        }        
        //set como string
        public void Cadena(string cadena)
        {
            this.cadena = stringAInt(cadena);
        }

        //Conversores
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
        //COnvierte string a int
        public static int[] stringAInt(string cadena)
        {
            int[] cadenaI = new int[cadena.Length];
            for(int i = 0, n = cadena.Length; i < n; i++)
            {
                cadenaI[i] = Convert.ToInt16(cadena[i]);
            }
            return cadenaI;
        }
        //Convierte int a string
        public static string intAString(int[] cadena)
        {
            string cadenaC = "";
            for (int i = 0, n = cadena.Length; i < n; i++)
            {
                cadenaC += Convert.ToChar(cadena[i]);
            }
            return cadenaC;
        }
        //Convierte char a int
        public static int[] charAInt(char[] cadena)
        {
            return Mensaje.stringAInt(Mensaje.charAstring(cadena));
        }
        //onvierte int a char
        public static char[] charAInt(int[] cadena)
        {
            return Mensaje.stringAChar(Mensaje.intAString(cadena));
        }

        //Redefiniciones


        //El método toString devuelve una cadena con el mensaje
        public override string ToString()
        {
            return this.cadenaS();
        }
        //Dos mensajes son iguales si el cadena es idéntico
        public bool Equals(Mensaje other)
        {
            if (other == null) return false;//Si nulo falso
            if(cadena.Length != other.cadena.Length) return false;//Si la longitud es diferente directamente falso
            for(int i=0,n=this.cadena.Length; i < n; i++)
            {
                if (this.cadena[i] != other.cadena[i]) return false;//Si uno falso falso
            }
            return true;//Si llega aquí cierto
        }
    }
}