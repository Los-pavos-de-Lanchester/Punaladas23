using Encriptador;
using System;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class fdialogoCriptografia : CommonDialog
    {
        public fdialogoCriptografia(/*Dictionary<string,string> algoritmos, out string algoritmoElegido, out string[] clave, out string[] args*/)
        {
            InitializeComponent();
        }

        public override void Reset()
        {
            foreach (string algoritmo in CEncriptador.ListaAlgoritmosS)
            {
                this.comboBox1.Items.Add(algoritmo);
            }

        }

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            return true;
        }
    }
}
