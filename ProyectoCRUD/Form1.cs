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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            estudiante.Correo = this.txtCorreo.Text;
            string genero = "F";
            if(this.cmbGenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;

            try
            {
                x = Academico.EstudianteDAO.guardar(estudiante);
                MessageBox.Show("Registros agregados: " + x.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
