using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Adm
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //botón Guardar
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(this.txtNombreCompleto.Text.Length==0)
            {
                MessageBox.Show("Por favor ingrese el nombre completo...");
                this.txtNombreCompleto.Focus();
                return;
            }
            if (this.txtLogin.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el login...");
                this.txtLogin.Focus();
                return;
            }
            if (this.txtClave.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la clave...");
                this.txtClave.Focus();
                return;
            }

            Academico.usuarios usuario = new Academico.usuarios(); //Creando instancia
            usuario.nombreCompleto = this.txtNombreCompleto.Text;
            usuario.login = this.txtLogin.Text;
            usuario.clave = this.txtClave.Text;
            usuario.tipoUsuario = this.cmbTipoUsuario.Text;
            int x = Academico.usuariosDAO.guardar(usuario);
            if(x>0)
            {
                MessageBox.Show("Usuario guardado con éxito...");
                cargarGrid();
            }
            else
            {
                MessageBox.Show("No se puede agregar el usuario...");
            }
        }
        private void cargarGrid()
        {
            this.dgUsuario.DataSource = Academico.usuariosDAO.getDatos();
            DataGridViewButtonColumn btnSelec = new DataGridViewButtonColumn();
            btnSelec.Name = "Seleccionar";
            dgUsuario.Columns.Add(btnSelec);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            encerar();
            cargarGrid();
        }
        private void encerar()
        {
            this.txtId.Text = "0";
            this.txtNombreCompleto.Text = String.Empty;
            this.txtLogin.Text = String.Empty;
            this.txtClave.Text = String.Empty;
            this.cmbTipoUsuario.Text = "Secretaria";
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgUsuario.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex > 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewImageCell celBoton = this.dgUsuario.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewImageCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + "@\\si");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 5;
                this.dgUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
                e.Handled = true;
            }

        }
    }
}
