using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionWindows.ControlesUsuario
{
    internal static class ControlUsuarioFactoria
    {
        public static IControlAlgoritmo getControlUsuario(string tipo)
        {
            switch (tipo)
            {
                case "Cesar": return new Cesar();
                case "Vigenere": return new Vigenere();
                default: throw new ArgumentException("Tipo incorrecto");
            }
        }
    }
}
