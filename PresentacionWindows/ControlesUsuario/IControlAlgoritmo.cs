using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows.ControlesUsuario
{
    public abstract class IControlAlgoritmo : UserControl
    {
        public virtual string[] Clave { get; }
        public virtual string[] Args { get; }
    }
}
