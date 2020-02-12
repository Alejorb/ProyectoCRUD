using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class frmMenu : Form
    {
        private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Llamada al form para agregar nuevos registros
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //Abrir el formulario de Búsqueda
            frmBuscar frm1 = new frmBuscar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de Actualizar
            frmActualizar frm1 = new frmActualizar();
            frm1.MdiParent = this;
            frm1.Show();
        }
            
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
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
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de Borrar o Eliminar
            frmBorrar frm1 = new frmBorrar();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adm.frmUsuario frm1 = new Adm.frmUsuario();
            frm1.MdiParent = this;
            frm1.Show();
        }



        private void listadoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Informes.frmInformeEstudiantes frm1 = new Informes.frmInformeEstudiantes();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignaturas.frmAsignaturas frm1 = new Asignaturas.frmAsignaturas();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignaturas.frmInformeAsig frm1 = new Asignaturas.frmInformeAsig();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void informePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infPersonal.frmSeleccionarEstudiantes frm1 = new infPersonal.frmSeleccionarEstudiantes();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
