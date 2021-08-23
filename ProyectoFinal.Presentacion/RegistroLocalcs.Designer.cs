
namespace ProyectoFinal.Presentacion
{
    partial class RegistroLocalcs
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
            this.datosRegistroLocal = new ProyectoFinal.Presentacion.Reportes.DatosRegistroLocal();
            this.datosRegistroLocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Local_ListarTableAdapter = new ProyectoFinal.Presentacion.Reportes.DatosRegistroLocalTableAdapters.SP_Local_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroLocalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataLocal";
            reportDataSource1.Value = this.datosRegistroLocalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Presentacion.Reportes.RptLocal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosRegistroLocal
            // 
            this.datosRegistroLocal.DataSetName = "DatosRegistroLocal";
            this.datosRegistroLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosRegistroLocalBindingSource
            // 
            this.datosRegistroLocalBindingSource.DataMember = "SP_Local_Listar";
            this.datosRegistroLocalBindingSource.DataSource = this.datosRegistroLocal;
            this.datosRegistroLocalBindingSource.CurrentChanged += new System.EventHandler(this.datosRegistroLocalBindingSource_CurrentChanged);
            // 
            // sP_Local_ListarTableAdapter
            // 
            this.sP_Local_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroLocalcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RegistroLocalcs";
            this.Text = "RegistroLocalcs";
            this.Load += new System.EventHandler(this.RegistroLocalcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroLocalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosRegistroLocalBindingSource;
        private Reportes.DatosRegistroLocal datosRegistroLocal;
        private Reportes.DatosRegistroLocalTableAdapters.SP_Local_ListarTableAdapter sP_Local_ListarTableAdapter;
    }
}