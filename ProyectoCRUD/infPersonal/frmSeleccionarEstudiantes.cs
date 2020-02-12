using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.infPersonal
{
    public partial class frmSeleccionarEstudiantes : Form
    {
        public frmSeleccionarEstudiantes()
        {
            InitializeComponent();
        }

        private void frmSeleccionarEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.dtPersonales' Puede moverla o quitarla según sea necesario.
            this.dtPersonalesTableAdapter.Fill(this.dsEstudiantes.dtPersonales);

            this.reportViewer1.RefreshReport();
            DataTable dt = Academico.EstudianteDAO.getNombresCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            String matricula = this.cmbMatricula.SelectedValue.ToString();
            try
            {
                dtPersonalesTableAdapter.FBfiltrar(dsEstudiantes.dtPersonales, matricula);
                reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
