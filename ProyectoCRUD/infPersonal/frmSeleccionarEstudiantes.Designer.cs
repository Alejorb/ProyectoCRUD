namespace ProyectoCRUD.infPersonal
{
    partial class frmSeleccionarEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtPersonalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiantes = new ProyectoCRUD.ds.dsEstudiantes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPersonalesTableAdapter = new ProyectoCRUD.ds.dsEstudiantesTableAdapters.dtPersonalesTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPersonalesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPersonalesBindingSource
            // 
            this.dtPersonalesBindingSource.DataMember = "dtPersonales";
            this.dtPersonalesBindingSource.DataSource = this.dsEstudiantes;
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dtPersonalesBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.dtPersonalesBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.infPersonal.rptPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(109, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(502, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtPersonalesTableAdapter
            // 
            this.dtPersonalesTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(448, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbMatricula
            // 
            this.cmbMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(226, 44);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(181, 21);
            this.cmbMatricula.TabIndex = 8;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el estudiante";
            // 
            // dtPersonalesBindingSource1
            // 
            this.dtPersonalesBindingSource1.DataMember = "dtPersonales";
            this.dtPersonalesBindingSource1.DataSource = this.dsEstudiantes;
            // 
            // frmSeleccionarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmSeleccionarEstudiantes";
            this.Text = "frmSeleccionarEstudiantes";
            this.Load += new System.EventHandler(this.frmSeleccionarEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsEstudiantes dsEstudiantes;
        private System.Windows.Forms.BindingSource dtPersonalesBindingSource;
        private ds.dsEstudiantesTableAdapters.dtPersonalesTableAdapter dtPersonalesTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dtPersonalesBindingSource1;
    }
}