
namespace ProyectoFinal.Presentacion
{
    partial class ReporteEmpleado
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
            this.datosRegistroEmpleado = new ProyectoFinal.Presentacion.Reportes.DatosRegistroEmpleado();
            this.datosRegistroEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Empleado_ListarTableAdapter = new ProyectoFinal.Presentacion.Reportes.DatosRegistroEmpleadoTableAdapters.SP_Empleado_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataEmpleado";
            reportDataSource1.Value = this.datosRegistroEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Presentacion.Reportes.RptEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosRegistroEmpleado
            // 
            this.datosRegistroEmpleado.DataSetName = "DatosRegistroEmpleado";
            this.datosRegistroEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosRegistroEmpleadoBindingSource
            // 
            this.datosRegistroEmpleadoBindingSource.DataMember = "SP_Empleado_Listar";
            this.datosRegistroEmpleadoBindingSource.DataSource = this.datosRegistroEmpleado;
            // 
            // sP_Empleado_ListarTableAdapter
            // 
            this.sP_Empleado_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEmpleado";
            this.Text = "ReporteEmpleado";
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosRegistroEmpleadoBindingSource;
        private Reportes.DatosRegistroEmpleado datosRegistroEmpleado;
        private Reportes.DatosRegistroEmpleadoTableAdapters.SP_Empleado_ListarTableAdapter sP_Empleado_ListarTableAdapter;
    }
}