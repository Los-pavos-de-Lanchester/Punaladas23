using Encriptador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentacionWindows
{
    public partial class fPrincipal : Form
    {
        private int childFormNumber = 0;

        public fPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            this.nuevoEditor("Ventana " + childFormNumber++, "");
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        //al iniciarse la aplicacion
        private void fPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Creado por Los Pavos Hacen Gluglú\nGracias por usar la aplicación.\nPor favor, no hagas cosas malas ;)");
        }
        //Clic en vista simplificada
        private void tsmVistaSimplificada_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)
                if (MessageBox.Show("Se cerrarán las pestañas abiertas\n¿Quieres cambiar de vista?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Cancel) return;
            this.closeAllToolStripMenuItem.PerformClick();
            fSimple fSimple = new fSimple();
            fSimple.Show();
            //this.Hide();//oculta el formulario
        }
        //encriptación
        private void tsmEncriptar_Click(object sender, EventArgs e)
        {
            string texto = (this.ActiveMdiChild as fEditor).encriptar();
            if (texto == null) return;
            fEditor feditor = this.nuevoEditor(this.ActiveMdiChild.Text + "Cifrado", texto);//Crea a partir del activo
        }

        private void tsmDesencriptar_Click(object sender, EventArgs e)
        {

        }
        //crea contructores
        public fEditor nuevoEditor(string nombre,string texto)
        {
            this.tsmEncriptar.Enabled = true;
            this.tsmDesencriptar.Enabled=true;

            fEditor fEditor = new fEditor(nombre,texto);
            fEditor.MdiParent= this;
            fEditor.Show();
            return fEditor;
        }
    }
}