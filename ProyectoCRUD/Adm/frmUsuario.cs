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
            int a=int.Parse(this.txtId.Text);
            if(a>0)
            {
                usuario.idLogin = a;
                usuario.nombreCompleto = this.txtNombreCompleto.Text;
                usuario.login = this.txtLogin.Text;
                usuario.clave = this.txtClave.Text;
                usuario.tipoUsuario = this.cmbTipoUsuario.Text;
                int x = Academico.usuariosDAO.actualizar(usuario);
                if (x > 0)
                {
                    MessageBox.Show("Usuario actualizado con éxito...");
                    encerar();
                    cargarGrid();
                }
                else
                {

                    MessageBox.Show("No se puede agregar el usuario...");
                }
            }
            else
            {
                usuario.nombreCompleto = this.txtNombreCompleto.Text;
                usuario.login = this.txtLogin.Text;
                usuario.clave = this.txtClave.Text;
                usuario.tipoUsuario = this.cmbTipoUsuario.Text;
                int x = Academico.usuariosDAO.guardar(usuario);
                if (x > 0)
                {
                    MessageBox.Show("Usuario guardado con éxito...");
                    cargarGrid();
                    encerar();
                }
                else
                {

                    MessageBox.Show("No se puede agregar el usuario...");
                }
            }
                
            
            
                
            
        }
        private void cargarGrid()
        {
            this.dgUsuario.DataSource = Academico.usuariosDAO.getDatos();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            encerar();
            seleccionar();
            eliminar();
            cargarGrid();
        }

        private void seleccionar()
        {
            DataGridViewButtonColumn btnSelec = new DataGridViewButtonColumn();
            btnSelec.Name = "Seleccionar";
            dgUsuario.Columns.Add(btnSelec);
        }
        private void eliminar()
        {
            DataGridViewButtonColumn btnSelec = new DataGridViewButtonColumn();
            btnSelec.Name = "Eliminar";
            dgUsuario.Columns.Add(btnSelec);
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
            if (e.ColumnIndex >= 0 && this.dgUsuario.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgUsuario.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\selec.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 5;
                this.dgUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;                                                   
            }

            if (e.ColumnIndex >= 0 && this.dgUsuario.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgUsuario.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\elim.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgUsuario.Rows[e.RowIndex].Height = icoAtomico.Height + 5;
                this.dgUsuario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void dgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgUsuario.Columns[e.ColumnIndex].Name == "Seleccionar")
            {

                txtId.Text = dgUsuario.CurrentRow.Cells[2].Value.ToString();
                txtNombreCompleto.Text= dgUsuario.CurrentRow.Cells[3].Value.ToString();
                txtLogin.Text= dgUsuario.CurrentRow.Cells[4].Value.ToString();
                txtClave.Text= dgUsuario.CurrentRow.Cells[5].Value.ToString();
                cmbTipoUsuario.Text = dgUsuario.CurrentRow.Cells[6].Value.ToString();

            }

            if (this.dgUsuario.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult opcion = MessageBox.Show("¿Desea eliminar al usuario?",
                "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    int x = Academico.usuariosDAO.borrar(dgUsuario.CurrentRow.Cells[2].Value.ToString());
                    encerar();
                    cargarGrid();
                }
            }
        }
    }
}
