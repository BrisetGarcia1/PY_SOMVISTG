
namespace ProyectoFinal.Presentacion
{
    partial class RegistroCategoria
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
            this.datosRegistroCategoria = new ProyectoFinal.Presentacion.Reportes.DatosRegistroCategoria();
            this.datosRegistroCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Categoria_ListarTableAdapter = new ProyectoFinal.Presentacion.Reportes.DatosRegistroCategoriaTableAdapters.SP_Categoria_ListarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosRegistroCategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Presentacion.Reportes.RptCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(795, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosRegistroCategoria
            // 
            this.datosRegistroCategoria.DataSetName = "DatosRegistroCategoria";
            this.datosRegistroCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosRegistroCategoriaBindingSource
            // 
            this.datosRegistroCategoriaBindingSource.DataMember = "SP_Categoria_Listar";
            this.datosRegistroCategoriaBindingSource.DataSource = this.datosRegistroCategoria;
            // 
            // sP_Categoria_ListarTableAdapter
            // 
            this.sP_Categoria_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RegistroCategoria";
            this.Text = "RegistroCategoria";
            this.Load += new System.EventHandler(this.RegistroCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosRegistroCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosRegistroCategoriaBindingSource;
        private Reportes.DatosRegistroCategoria datosRegistroCategoria;
        private Reportes.DatosRegistroCategoriaTableAdapters.SP_Categoria_ListarTableAdapter sP_Categoria_ListarTableAdapter;
    }
}