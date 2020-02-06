namespace ProyectoCRUD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtPersonalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiantes = new ProyectoCRUD.ds.dsEstudiantes();
            this.btnVer = new System.Windows.Forms.Button();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtPersonalesTableAdapter = new ProyectoCRUD.ds.dsEstudiantesTableAdapters.dtPersonalesTableAdapter();
            this.EstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtPersonalesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtPersonalesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource2)).BeginInit();
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
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(509, 43);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // cmbMatricula
            // 
            this.cmbMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(277, 40);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(181, 21);
            this.cmbMatricula.TabIndex = 4;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el estudiante";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(621, 43);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtPersonalesTableAdapter
            // 
            this.dtPersonalesTableAdapter.ClearBeforeFill = true;
            // 
            // EstudiantesBindingSource
            // 
            this.EstudiantesBindingSource.DataMember = "Estudiantes";
            this.EstudiantesBindingSource.DataSource = this.dsEstudiantes;
            // 
            // dtPersonalesBindingSource1
            // 
            this.dtPersonalesBindingSource1.DataMember = "dtPersonales";
            this.dtPersonalesBindingSource1.DataSource = this.dsEstudiantes;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EstudiantesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.dtPersonalesBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.infPersonal.rptPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(714, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // dtPersonalesBindingSource2
            // 
            this.dtPersonalesBindingSource2.DataMember = "dtPersonales";
            this.dtPersonalesBindingSource2.DataSource = this.dsEstudiantes;
            // 
            // frmSeleccionarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cmbMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmSeleccionarEstudiantes";
            this.Text = "frmSeleccionarEstudiantes";
            this.Load += new System.EventHandler(this.frmSeleccionarEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersonalesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cmbMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource dtPersonalesBindingSource;
        private ds.dsEstudiantes dsEstudiantes;
        private ds.dsEstudiantesTableAdapters.dtPersonalesTableAdapter dtPersonalesTableAdapter;
        private System.Windows.Forms.BindingSource EstudiantesBindingSource;
        private System.Windows.Forms.BindingSource dtPersonalesBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtPersonalesBindingSource2;
    }
}