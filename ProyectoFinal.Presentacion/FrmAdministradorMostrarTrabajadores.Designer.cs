
namespace ProyectoFinal.Presentacion
{
    partial class FrmAdministradorMostrarTrabajadores
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnQuitarTrabajador = new System.Windows.Forms.Button();
            this.btnAgregarTrabajador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGrilla1 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegresar.Location = new System.Drawing.Point(248, 295);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(91, 56);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnQuitarTrabajador
            // 
            this.btnQuitarTrabajador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuitarTrabajador.Location = new System.Drawing.Point(40, 173);
            this.btnQuitarTrabajador.Name = "btnQuitarTrabajador";
            this.btnQuitarTrabajador.Size = new System.Drawing.Size(91, 56);
            this.btnQuitarTrabajador.TabIndex = 31;
            this.btnQuitarTrabajador.Text = "Quitar Trabajador";
            this.btnQuitarTrabajador.UseVisualStyleBackColor = false;
            this.btnQuitarTrabajador.Click += new System.EventHandler(this.btnQuitarTrabajador_Click);
            // 
            // btnAgregarTrabajador
            // 
            this.btnAgregarTrabajador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarTrabajador.Location = new System.Drawing.Point(40, 111);
            this.btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            this.btnAgregarTrabajador.Size = new System.Drawing.Size(91, 56);
            this.btnAgregarTrabajador.TabIndex = 30;
            this.btnAgregarTrabajador.Text = "Agregar Trabajador";
            this.btnAgregarTrabajador.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajador.Click += new System.EventHandler(this.btnAgregarTrabajador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Trabajadores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Trabajadores";
            // 
            // dgvGrilla1
            // 
            this.dgvGrilla1.AllowUserToAddRows = false;
            this.dgvGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla1.Location = new System.Drawing.Point(169, 84);
            this.dgvGrilla1.Name = "dgvGrilla1";
            this.dgvGrilla1.ReadOnly = true;
            this.dgvGrilla1.Size = new System.Drawing.Size(326, 176);
            this.dgvGrilla1.TabIndex = 33;
            this.dgvGrilla1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla1_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSeleccionar.Location = new System.Drawing.Point(40, 255);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(110, 21);
            this.chkSeleccionar.TabIndex = 94;
            this.chkSeleccionar.Text = "seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = false;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // FrmAdministradorMostrarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Presentacion.Properties.Resources.cube_426204_1280;
            this.ClientSize = new System.Drawing.Size(539, 375);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.dgvGrilla1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnQuitarTrabajador);
            this.Controls.Add(this.btnAgregarTrabajador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdministradorMostrarTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorMostrarTrabajadores";
            this.Load += new System.EventHandler(this.FrmAdministradorMostrarTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnQuitarTrabajador;
        private System.Windows.Forms.Button btnAgregarTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrilla1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox chkSeleccionar;
    }
}