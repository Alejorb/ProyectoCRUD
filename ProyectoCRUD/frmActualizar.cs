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
                MessageBox.Show("No existe el registro...");
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
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.dtFechaNacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.txtCorreo.Text = fila["email"].ToString();
                    break;
                }
            }
            return encontrado;
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
                if (this.cmbMatricula.SelectedIndex >= 0)
                {
                    buscar();
                }    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante estudiante = new Academico.Estudiante(); //Creando instancia
            estudiante.Matricula = Convert.ToString(this.cmbMatricula.SelectedValue);
            estudiante.Apellidos = this.txtApellido.Text;
            estudiante.Nombres = this.txtNombre.Text;
            estudiante.FechaNAcimiento = this.dtFechaNacimiento.Value;

            string genero = "F";
            if (this.cmbGenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;

            if (Academico.EstudianteDAO.validarEmail(this.txtCorreo.Text) == false)
            {
                MessageBox.Show("El e-mail ingresado no se encuentra en el formato correcto",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estudiante.Correo = this.txtCorreo.Text;
            }

            try
            {
                x = Academico.EstudianteDAO.actualizar(estudiante);
                
                MessageBox.Show("Registros agregados: " + x.ToString());//el número de filas agregadas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }
    }
}
