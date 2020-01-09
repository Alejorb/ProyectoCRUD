using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGridEstudiantes(); 
        }
        private void cargarGridEstudiantes()
        {
            this.dgEstudiantes.DataSource = Academico.EstudianteDAO.getDatos();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante estudiante = new Academico.Estudiante(); //Creando instancia
            estudiante.Matricula = this.txtMatricula.Text;
            estudiante.Apellidos = this.txtApellido.Text;
            estudiante.Nombres = this.txtNombre.Text;
            estudiante.FechaNAcimiento = this.dtFechaNacimiento.Value;
            
            string genero = "F";
            if(this.cmbGenero.Text.ToString().Equals("Masculino"))
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
                x = Academico.EstudianteDAO.guardar(estudiante);
                cargarGridEstudiantes();
                MessageBox.Show("Registros agregados: " + x.ToString());//el número de filas agregadas
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtMatricula.Clear();
            this.txtApellido.Clear();
            this.txtNombre.Clear();
            this.dtFechaNacimiento.DataBindings.Clear();
            this.txtCorreo.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
