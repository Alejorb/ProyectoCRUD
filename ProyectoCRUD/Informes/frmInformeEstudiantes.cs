using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Informes
{
    public partial class frmInformeEstudiantes : Form
    {
        public frmInformeEstudiantes()
        {
            InitializeComponent();
        }

        private void frmInformeEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes.Estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.dsEstudiantes.Estudiantes);

            this.reportViewer1.RefreshReport();
        }
    }
}
