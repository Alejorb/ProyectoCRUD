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
    public partial class frmSeleccionarEstudiantes : Form
    {
        public frmSeleccionarEstudiantes()
        {
            InitializeComponent();
        }

        private void frmSeleccionarEstudiantes_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
            this.reportViewer1.RefreshReport();
        }

        private bool buscar()
        {
            bool encontrado = false;
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    encontrado = true;
                    /*this.txtApellido.Text = fila["apellidos"].ToString();
                    this.txtNombre.Text = fila["nombres"].ToString();
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.dtFechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    break;*/
                }
            }
            return encontrado;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMatricula.SelectedIndex >= 0)
            {
                buscar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
