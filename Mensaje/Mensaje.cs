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
            this.cadena = aInt(cadena);
        }
        //Constructor a partir de cadena
        public Mensaje(string cadena)
        {
            this.cadena = aInt(cadena);
        }
        //Constructor a partir de enteros
        public Mensaje(int[] cadena)
        {
            this.cadena = cadena;
        }


        //Get como cadena
        public string cadenaS
        {
            get { return aString(this.cadena); }
        }
        //Get como char
        public char[] cadenaC
        {
            get { return aInt(this.cadena); }
        }
        //Get como int
        public int[] cadenaI
        {
            get { return this.cadena; }
        }
        //set Cadena
        public int[] Cadena {//Como sobrecargar?
            set { this.setCadena(value); }
        }

        #region métodos auxiliares par el set
        private void setCadena(int[] cadena)
        {
            this.cadena = cadena;
        }
        //set como char
        private void setCadena(char[] cadena)
        {
            this.cadena = aInt(cadena);
        }
        //set como string
        private void setCadena(string cadena)
        {
            this.cadena = aInt(cadena);
        } 
        #endregion


        //Conversores
        //convierte char a string
        public static string astring(char[] cadena)
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
        public static char[] aChar(string cadena)
        {
            char[] cadenaC = new char[cadena.Length];
            for (int i = 0; i < cadenaC.Length; i++)
            {
                cadenaC[i] = (char)cadena[i];
            }
            return cadenaC;
        }
        //COnvierte string a int
        public static int[] aInt(string cadena)
        {
            int[] cadenaI = new int[cadena.Length];
            for(int i = 0, n = cadena.Length; i < n; i++)
            {
                cadenaI[i] = Convert.ToInt16(cadena[i]);
            }
            return cadenaI;
        }
        //Convierte int a string
        public static string aString(int[] cadena)
        {
            string cadenaC = "";
            for (int i = 0, n = cadena.Length; i < n; i++)
            {
                cadenaC += Convert.ToChar(cadena[i]);
            }
            return cadenaC;
        }
        //Convierte char a int
        public static int[] aInt(char[] cadena)
        {
            return Mensaje.aInt(Mensaje.astring(cadena));
        }
        //onvierte int a char
        public static char[] aInt(int[] cadena)
        {
            return Mensaje.aChar(Mensaje.aString(cadena));
        }

        //Redefiniciones


        //El método toString devuelve una cadena con el mensaje
        public override string ToString()
        {
            return this.cadenaS;
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