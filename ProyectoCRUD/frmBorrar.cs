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
    public partial class frmBorrar : Form
    {
        public frmBorrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmBorrar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    this.txtApellido.Text = fila["apellidos"].ToString();
                    this.txtNombre.Text = fila["nombres"].ToString();
                    this.txtGenero.Text = fila["genero"].ToString();
                    this.txtFechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    break;
                }
            }
            else
            {
                MessageBox.Show("No exixte el estudiante... ");
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion=MessageBox.Show("¿Desea eliminar al estudiante?",
                "¡ADVERTENCIA!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (opcion==DialogResult.Yes)
            {
                int x= Academico.EstudianteDAO.borrar(this.cmbMatricula.SelectedValue.ToString());
                this.txtApellido.Clear();
                this.txtNombre.Clear();
                this.txtGenero.Clear();
                this.txtFechaNacimiento.Clear();
                this.txtCorreo.Clear();
                DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
                this.cmbMatricula.DataSource = dt;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
