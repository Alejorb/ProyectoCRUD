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
    }
}
