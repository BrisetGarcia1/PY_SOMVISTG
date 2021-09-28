
namespace ProyectoFinal.Presentacion
{
    partial class FrmAdministradorInvDetalle
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradorInvDetalle));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRealizarPedidos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInventario
            // 
            this.txtInventario.BackColor = System.Drawing.Color.White;
            this.txtInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventario.Location = new System.Drawing.Point(192, 102);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(292, 30);
            this.txtInventario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inventario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(264, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Inventario movimiento:";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla.Location = new System.Drawing.Point(24, 215);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(677, 208);
            this.dgvGrilla.TabIndex = 30;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRealizarPedidos);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvGrilla);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtInventario);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 506);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "DETALLE DE INVENTARIO";
            // 
            // btnRegresar
            // 
            this.btnRegresar.AllowAnimations = true;
            this.btnRegresar.AllowMouseEffects = true;
            this.btnRegresar.AllowToggling = false;
            this.btnRegresar.AnimationSpeed = 200;
            this.btnRegresar.AutoGenerateColors = false;
            this.btnRegresar.AutoRoundBorders = false;
            this.btnRegresar.AutoSizeLeftIcon = true;
            this.btnRegresar.AutoSizeRightIcon = true;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegresar.ButtonText = "Regresar";
            this.btnRegresar.ButtonTextMarginLeft = 0;
            this.btnRegresar.ColorContrastOnClick = 45;
            this.btnRegresar.ColorContrastOnHover = 45;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegresar.CustomizableEdges = borderEdges2;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegresar.IconMarginLeft = 11;
            this.btnRegresar.IconPadding = 10;
            this.btnRegresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegresar.IconSize = 25;
            this.btnRegresar.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegresar.IdleBorderRadius = 1;
            this.btnRegresar.IdleBorderThickness = 1;
            this.btnRegresar.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegresar.IdleIconLeftImage = null;
            this.btnRegresar.IdleIconRightImage = null;
            this.btnRegresar.IndicateFocus = false;
            this.btnRegresar.Location = new System.Drawing.Point(574, 440);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegresar.OnDisabledState.BorderRadius = 1;
            this.btnRegresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegresar.OnDisabledState.BorderThickness = 1;
            this.btnRegresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegresar.OnDisabledState.IconLeftImage = null;
            this.btnRegresar.OnDisabledState.IconRightImage = null;
            this.btnRegresar.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegresar.onHoverState.BorderRadius = 1;
            this.btnRegresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegresar.onHoverState.BorderThickness = 1;
            this.btnRegresar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegresar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.onHoverState.IconLeftImage = null;
            this.btnRegresar.onHoverState.IconRightImage = null;
            this.btnRegresar.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegresar.OnIdleState.BorderRadius = 1;
            this.btnRegresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegresar.OnIdleState.BorderThickness = 1;
            this.btnRegresar.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegresar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.OnIdleState.IconLeftImage = null;
            this.btnRegresar.OnIdleState.IconRightImage = null;
            this.btnRegresar.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnRegresar.OnPressedState.BorderRadius = 1;
            this.btnRegresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegresar.OnPressedState.BorderThickness = 1;
            this.btnRegresar.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnRegresar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.OnPressedState.IconLeftImage = null;
            this.btnRegresar.OnPressedState.IconRightImage = null;
            this.btnRegresar.Size = new System.Drawing.Size(127, 35);
            this.btnRegresar.TabIndex = 53;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegresar.TextMarginLeft = 0;
            this.btnRegresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegresar.UseDefaultRadiusAndThickness = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnRealizarPedidos
            // 
            this.btnRealizarPedidos.AllowAnimations = true;
            this.btnRealizarPedidos.AllowMouseEffects = true;
            this.btnRealizarPedidos.AllowToggling = false;
            this.btnRealizarPedidos.AnimationSpeed = 200;
            this.btnRealizarPedidos.AutoGenerateColors = false;
            this.btnRealizarPedidos.AutoRoundBorders = false;
            this.btnRealizarPedidos.AutoSizeLeftIcon = true;
            this.btnRealizarPedidos.AutoSizeRightIcon = true;
            this.btnRealizarPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnRealizarPedidos.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnRealizarPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRealizarPedidos.BackgroundImage")));
            this.btnRealizarPedidos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRealizarPedidos.ButtonText = "Realizar Pedidos";
            this.btnRealizarPedidos.ButtonTextMarginLeft = 0;
            this.btnRealizarPedidos.ColorContrastOnClick = 45;
            this.btnRealizarPedidos.ColorContrastOnHover = 45;
            this.btnRealizarPedidos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRealizarPedidos.CustomizableEdges = borderEdges1;
            this.btnRealizarPedidos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRealizarPedidos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRealizarPedidos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRealizarPedidos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRealizarPedidos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRealizarPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedidos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarPedidos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRealizarPedidos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRealizarPedidos.IconMarginLeft = 11;
            this.btnRealizarPedidos.IconPadding = 10;
            this.btnRealizarPedidos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRealizarPedidos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRealizarPedidos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRealizarPedidos.IconSize = 25;
            this.btnRealizarPedidos.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRealizarPedidos.IdleBorderRadius = 1;
            this.btnRealizarPedidos.IdleBorderThickness = 1;
            this.btnRealizarPedidos.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRealizarPedidos.IdleIconLeftImage = null;
            this.btnRealizarPedidos.IdleIconRightImage = null;
            this.btnRealizarPedidos.IndicateFocus = false;
            this.btnRealizarPedidos.Location = new System.Drawing.Point(506, 98);
            this.btnRealizarPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarPedidos.Name = "btnRealizarPedidos";
            this.btnRealizarPedidos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRealizarPedidos.OnDisabledState.BorderRadius = 1;
            this.btnRealizarPedidos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRealizarPedidos.OnDisabledState.BorderThickness = 1;
            this.btnRealizarPedidos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRealizarPedidos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRealizarPedidos.OnDisabledState.IconLeftImage = null;
            this.btnRealizarPedidos.OnDisabledState.IconRightImage = null;
            this.btnRealizarPedidos.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRealizarPedidos.onHoverState.BorderRadius = 1;
            this.btnRealizarPedidos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRealizarPedidos.onHoverState.BorderThickness = 1;
            this.btnRealizarPedidos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRealizarPedidos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedidos.onHoverState.IconLeftImage = null;
            this.btnRealizarPedidos.onHoverState.IconRightImage = null;
            this.btnRealizarPedidos.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRealizarPedidos.OnIdleState.BorderRadius = 1;
            this.btnRealizarPedidos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRealizarPedidos.OnIdleState.BorderThickness = 1;
            this.btnRealizarPedidos.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRealizarPedidos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedidos.OnIdleState.IconLeftImage = null;
            this.btnRealizarPedidos.OnIdleState.IconRightImage = null;
            this.btnRealizarPedidos.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnRealizarPedidos.OnPressedState.BorderRadius = 1;
            this.btnRealizarPedidos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRealizarPedidos.OnPressedState.BorderThickness = 1;
            this.btnRealizarPedidos.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnRealizarPedidos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedidos.OnPressedState.IconLeftImage = null;
            this.btnRealizarPedidos.OnPressedState.IconRightImage = null;
            this.btnRealizarPedidos.Size = new System.Drawing.Size(171, 40);
            this.btnRealizarPedidos.TabIndex = 54;
            this.btnRealizarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRealizarPedidos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRealizarPedidos.TextMarginLeft = 0;
            this.btnRealizarPedidos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRealizarPedidos.UseDefaultRadiusAndThickness = true;
            this.btnRealizarPedidos.Click += new System.EventHandler(this.btnRealizarPedidos_Click_1);
            // 
            // FrmAdministradorInvDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Presentacion.Properties.Resources._4812d3cc80cd265ffab17b38b20b9eb3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdministradorInvDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorInvDetalle";
            this.Load += new System.EventHandler(this.FrmAdministradorInvDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegresar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRealizarPedidos;
    }
}