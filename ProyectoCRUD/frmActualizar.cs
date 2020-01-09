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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(buscar()==false)
            {
                MessageBox.
            }
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
                    this.txtApellido.Text = fila["apellidos"].ToString();
                    this.txtNombre.Text = fila["nombres"].ToString();
                    this.txtGenero.Text = fila["genero"].ToString();
                    this.txtFechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    break;
                }
            }
            return false;
        }
        private void frmAcrualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.)
            buscar();
        }
    }
}
