namespace ProyectoCRUD.Informes
{
    partial class frmInformeEstudiantes
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
            this.dsEstudiantes = new ProyectoCRUD.ds.dsEstudiantes();
            this.EstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter = new ProyectoCRUD.ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.estudiantesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstudiantesBindingSource
            // 
            this.EstudiantesBindingSource.DataMember = "Estudiantes";
            this.EstudiantesBindingSource.DataSource = this.dsEstudiantes;
            // 
            // estudiantesBindingSource1
            // 
            this.estudiantesBindingSource1.DataMember = "Estudiantes";
            this.estudiantesBindingSource1.DataSource = this.dsEstudiantes;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estudiantesBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.Informes.rptEstudiantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // estudiantesBindingSource2
            // 
            this.estudiantesBindingSource2.DataMember = "Estudiantes";
            this.estudiantesBindingSource2.DataSource = this.dsEstudiantes;
            // 
            // frmInformeEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeEstudiantes";
            this.Text = "frmInformeEstudiantes";
            this.Load += new System.EventHandler(this.frmInformeEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ds.dsEstudiantes dsEstudiantes;
        private System.Windows.Forms.BindingSource EstudiantesBindingSource;
        private System.Windows.Forms.BindingSource estudiantesBindingSource1;
        private ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estudiantesBindingSource2;
    }
}