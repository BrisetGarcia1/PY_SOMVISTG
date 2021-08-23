
namespace ProyectoFinal.Presentacion
{
    partial class RegistroDetalleInventario
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
            this.datosReporteDetalleInventario = new ProyectoFinal.Presentacion.Reportes.DatosReporteDetalleInventario();
            this.datosReporteDetalleInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DetalleInventario_ListarTableAdapter = new ProyectoFinal.Presentacion.Reportes.DatosReporteDetalleInventarioTableAdapters.SP_DetalleInventario_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDetalleInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDetalleInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataDetalleInventario";
            reportDataSource1.Value = this.datosReporteDetalleInventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Presentacion.Reportes.RptDetalleInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosReporteDetalleInventario
            // 
            this.datosReporteDetalleInventario.DataSetName = "DatosReporteDetalleInventario";
            this.datosReporteDetalleInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosReporteDetalleInventarioBindingSource
            // 
            this.datosReporteDetalleInventarioBindingSource.DataMember = "SP_DetalleInventario_Listar";
            this.datosReporteDetalleInventarioBindingSource.DataSource = this.datosReporteDetalleInventario;
            // 
            // sP_DetalleInventario_ListarTableAdapter
            // 
            this.sP_DetalleInventario_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroDetalleInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RegistroDetalleInventario";
            this.Text = "RegistroDetalleInventario";
            this.Load += new System.EventHandler(this.RegistroDetalleInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDetalleInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteDetalleInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosReporteDetalleInventarioBindingSource;
        private Reportes.DatosReporteDetalleInventario datosReporteDetalleInventario;
        private Reportes.DatosReporteDetalleInventarioTableAdapters.SP_DetalleInventario_ListarTableAdapter sP_DetalleInventario_ListarTableAdapter;
    }
}