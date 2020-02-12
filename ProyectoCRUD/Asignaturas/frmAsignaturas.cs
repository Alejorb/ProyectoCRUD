using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Asignaturas
{
    public partial class frmAsignaturas : Form
    {
        public frmAsignaturas()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Asignaturas asignatura = new Academico.Asignaturas(); //Creando instancia
            asignatura.CodAsignatura = Convert.ToString(this.cmbCodigo.SelectedValue);
            asignatura.NombreAsignatura = this.txtcodAsignatura.Text;
            asignatura.NombreAsignatura = this.txtNombreAsignatura.Text;
            asignatura.Nivel = int.Parse(this.txtNivel.Text);
            asignatura.Creditos = int.Parse(this.txtCreditos.Text);
            asignatura.Carrera = this.txtCarrera.Text;

            try
            {
                x = Academico.AsignaturasDAO.actualizar(asignatura);

                MessageBox.Show("Registros actualizados: " + x.ToString());//el número de filas agregadas
                actcombo();
                encerar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void frmAsignaturas_Load(object sender, EventArgs e)
        {
            actcombo();
        }
        private void actcombo()
        {
            DataTable dt = Academico.AsignaturasDAO.getNombresCompletos();
            this.cmbCodigo.DataSource = dt;
            this.cmbCodigo.DisplayMember = "Asignatura";
            this.cmbCodigo.ValueMember = "CodAsignatura";
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCodigo.SelectedIndex >= 0)
            {
                buscar();
            }
        }
        private bool buscar()
        {
            bool encontrado = false;
            DataTable dt = Academico.AsignaturasDAO.getDatos(this.cmbCodigo.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    encontrado = true;
                    this.txtcodAsignatura.Text = fila["codAsignatura"].ToString();
                    this.txtNombreAsignatura.Text = fila["nombreAsignatura"].ToString();
                    this.txtNivel.Text = fila["nivel"].ToString();
                    this.txtCreditos.Text = fila["creditos"].ToString();
                    this.txtCarrera.Text = fila["carrera"].ToString();
                    break;
                }
            }
            return encontrado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (buscar() == false)
            {
                MessageBox.Show("No existe el registro...");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.txtcodAsignatura.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el código...");
                this.txtcodAsignatura.Focus();
                return;
            }
            if (this.txtNombreAsignatura.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la asignatura...");
                this.txtNombreAsignatura.Focus();
                return;
            }
            if (this.txtNivel.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el nivel...");
                this.txtNivel.Focus();
                return;
            }
            if (this.txtCreditos.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese los créditos...");
                this.txtCreditos.Focus();
                return;
            }
            if (this.txtCarrera.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la carrera...");
                this.txtCarrera.Focus();
                return;
            }
            Academico.Asignaturas usuario = new Academico.Asignaturas(); //Creando instancia
            usuario.CodAsignatura = this.txtcodAsignatura.Text;
            usuario.NombreAsignatura = this.txtNombreAsignatura.Text;
            usuario.Nivel = int.Parse(this.txtNivel.Text);
            usuario.Creditos = int.Parse(this.txtCreditos.Text);
            usuario.Carrera = this.txtCarrera.Text;
            int x = Academico.AsignaturasDAO.guardar(usuario);
            if (x > 0)
            {
                MessageBox.Show("Usuario guardado con éxito...");
                actcombo();
                encerar();
                

            }
            else
            {
                MessageBox.Show("No se puede agregar el usuario...");
            }

        }
        private void encerar()
        {
            this.txtcodAsignatura.Text = String.Empty;
            this.txtNombreAsignatura.Text = String.Empty;
            this.txtNivel.Text = String.Empty;
            this.txtCreditos.Text = String.Empty;
            this.txtCarrera.Text = String.Empty;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el dato?",
                "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                int x = Academico.AsignaturasDAO.borrar(this.cmbCodigo.SelectedValue.ToString());
                actcombo();
                encerar();

            }
        }
    }
}
