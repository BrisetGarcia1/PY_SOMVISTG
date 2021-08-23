
namespace ProyectoFinal.Presentacion
{
    partial class ReporteUsuario
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosReporteUsuario = new ProyectoFinal.Presentacion.Reportes.DatosReporteUsuario();
            this.datosReporteUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Usuario_ListarTableAdapter = new ProyectoFinal.Presentacion.Reportes.DatosReporteUsuarioTableAdapters.SP_Usuario_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosReporteUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Presentacion.Reportes.RptUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosReporteUsuario
            // 
            this.datosReporteUsuario.DataSetName = "DatosReporteUsuario";
            this.datosReporteUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosReporteUsuarioBindingSource
            // 
            this.datosReporteUsuarioBindingSource.DataMember = "SP_Usuario_Listar";
            this.datosReporteUsuarioBindingSource.DataSource = this.datosReporteUsuario;
            // 
            // sP_Usuario_ListarTableAdapter
            // 
            this.sP_Usuario_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteUsuario";
            this.Text = "ReporteUsuario";
            this.Load += new System.EventHandler(this.ReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosReporteUsuarioBindingSource;
        private Reportes.DatosReporteUsuario datosReporteUsuario;
        private Reportes.DatosReporteUsuarioTableAdapters.SP_Usuario_ListarTableAdapter sP_Usuario_ListarTableAdapter;
    }
}