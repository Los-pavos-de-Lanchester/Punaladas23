using Encriptador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class fdialogoCriptografia : CommonDialog
    {

        public fdialogoCriptografia()
        {
            InitializeComponent();
        }
        public fdialogoCriptografia(Dictionary<string,string> algoritmos, string algoritmoElegido, string[] clave, string[] args):this()
        {
            
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
