using Encriptador;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class fdialogoCriptografia : CommonDialog
    {

        public fdialogoCriptografia():base()
        {
            InitializeComponent();
        }
        public fdialogoCriptografia(Dictionary<string,string> algoritmos):this()
        {
            foreach(string algoritmo in algoritmos.Keys)
            {
                
            }
        }

        public string AlgoritmoElegido
        {
            get { return this.comboBox1.Text; }
        }

        public string ClaveElegida
        {
            get {return null; }//por implementar
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }

        protected override bool RunDialog(IntPtr ptr)
        {
            return true;
        }

    }
}
