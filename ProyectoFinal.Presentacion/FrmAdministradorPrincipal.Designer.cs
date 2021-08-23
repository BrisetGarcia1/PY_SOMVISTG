
namespace ProyectoFinal.Presentacion
{
    partial class FrmAdministradorPrincipal
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
            this.btnMostrarInvActivos = new System.Windows.Forms.Button();
            this.btnMostrarTrabajadores = new System.Windows.Forms.Button();
            this.btnMostrarInvDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarInvActivos
            // 
            this.btnMostrarInvActivos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarInvActivos.Location = new System.Drawing.Point(233, 116);
            this.btnMostrarInvActivos.Name = "btnMostrarInvActivos";
            this.btnMostrarInvActivos.Size = new System.Drawing.Size(91, 56);
            this.btnMostrarInvActivos.TabIndex = 11;
            this.btnMostrarInvActivos.Text = "Mostrar Inventarios Activos";
            this.btnMostrarInvActivos.UseVisualStyleBackColor = false;
            this.btnMostrarInvActivos.Click += new System.EventHandler(this.btnMostrarInvActivos_Click);
            // 
            // btnMostrarTrabajadores
            // 
            this.btnMostrarTrabajadores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarTrabajadores.Location = new System.Drawing.Point(125, 116);
            this.btnMostrarTrabajadores.Name = "btnMostrarTrabajadores";
            this.btnMostrarTrabajadores.Size = new System.Drawing.Size(91, 56);
            this.btnMostrarTrabajadores.TabIndex = 10;
            this.btnMostrarTrabajadores.Text = "Mostrar Trabajadores";
            this.btnMostrarTrabajadores.UseVisualStyleBackColor = false;
            this.btnMostrarTrabajadores.Click += new System.EventHandler(this.btnMostrarTrabajadores_Click);
            // 
            // btnMostrarInvDetalle
            // 
            this.btnMostrarInvDetalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarInvDetalle.Location = new System.Drawing.Point(342, 116);
            this.btnMostrarInvDetalle.Name = "btnMostrarInvDetalle";
            this.btnMostrarInvDetalle.Size = new System.Drawing.Size(91, 56);
            this.btnMostrarInvDetalle.TabIndex = 9;
            this.btnMostrarInvDetalle.Text = "Mostrar Detalle del Inventario";
            this.btnMostrarInvDetalle.UseVisualStyleBackColor = false;
            this.btnMostrarInvDetalle.Click += new System.EventHandler(this.btnMostrarInvDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionar el Inventario";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla.Location = new System.Drawing.Point(25, 214);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(501, 204);
            this.dgvGrilla.TabIndex = 13;
            // 
            // FrmAdministradorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Presentacion.Properties.Resources.cube_426204_1280;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnMostrarInvActivos);
            this.Controls.Add(this.btnMostrarTrabajadores);
            this.Controls.Add(this.btnMostrarInvDetalle);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdministradorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorPrincipal";
            this.Load += new System.EventHandler(this.FrmAdministradorPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarInvActivos;
        private System.Windows.Forms.Button btnMostrarTrabajadores;
        private System.Windows.Forms.Button btnMostrarInvDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridView dgvGrilla;
    }
}