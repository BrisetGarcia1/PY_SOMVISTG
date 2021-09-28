
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradorPrincipal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarTrabajadores = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMostrarInvActivos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMostrarInvDetalle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla.Location = new System.Drawing.Point(28, 175);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(618, 289);
            this.dgvGrilla.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMostrarInvDetalle);
            this.panel1.Controls.Add(this.btnMostrarInvActivos);
            this.panel1.Controls.Add(this.btnMostrarTrabajadores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvGrilla);
            this.panel1.Location = new System.Drawing.Point(34, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 493);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(172, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "SELECCIONAR EL INVENTARIO";
            // 
            // btnMostrarTrabajadores
            // 
            this.btnMostrarTrabajadores.AllowAnimations = true;
            this.btnMostrarTrabajadores.AllowMouseEffects = true;
            this.btnMostrarTrabajadores.AllowToggling = false;
            this.btnMostrarTrabajadores.AnimationSpeed = 200;
            this.btnMostrarTrabajadores.AutoGenerateColors = false;
            this.btnMostrarTrabajadores.AutoRoundBorders = false;
            this.btnMostrarTrabajadores.AutoSizeLeftIcon = true;
            this.btnMostrarTrabajadores.AutoSizeRightIcon = true;
            this.btnMostrarTrabajadores.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTrabajadores.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarTrabajadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarTrabajadores.BackgroundImage")));
            this.btnMostrarTrabajadores.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarTrabajadores.ButtonText = "Mostrar Trabajadores";
            this.btnMostrarTrabajadores.ButtonTextMarginLeft = 0;
            this.btnMostrarTrabajadores.ColorContrastOnClick = 45;
            this.btnMostrarTrabajadores.ColorContrastOnHover = 45;
            this.btnMostrarTrabajadores.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnMostrarTrabajadores.CustomizableEdges = borderEdges3;
            this.btnMostrarTrabajadores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrarTrabajadores.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarTrabajadores.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarTrabajadores.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarTrabajadores.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMostrarTrabajadores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTrabajadores.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTrabajadores.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarTrabajadores.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMostrarTrabajadores.IconMarginLeft = 11;
            this.btnMostrarTrabajadores.IconPadding = 10;
            this.btnMostrarTrabajadores.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarTrabajadores.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarTrabajadores.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMostrarTrabajadores.IconSize = 25;
            this.btnMostrarTrabajadores.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarTrabajadores.IdleBorderRadius = 1;
            this.btnMostrarTrabajadores.IdleBorderThickness = 1;
            this.btnMostrarTrabajadores.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarTrabajadores.IdleIconLeftImage = null;
            this.btnMostrarTrabajadores.IdleIconRightImage = null;
            this.btnMostrarTrabajadores.IndicateFocus = false;
            this.btnMostrarTrabajadores.Location = new System.Drawing.Point(28, 98);
            this.btnMostrarTrabajadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarTrabajadores.Name = "btnMostrarTrabajadores";
            this.btnMostrarTrabajadores.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarTrabajadores.OnDisabledState.BorderRadius = 1;
            this.btnMostrarTrabajadores.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarTrabajadores.OnDisabledState.BorderThickness = 1;
            this.btnMostrarTrabajadores.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarTrabajadores.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarTrabajadores.OnDisabledState.IconLeftImage = null;
            this.btnMostrarTrabajadores.OnDisabledState.IconRightImage = null;
            this.btnMostrarTrabajadores.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrarTrabajadores.onHoverState.BorderRadius = 1;
            this.btnMostrarTrabajadores.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarTrabajadores.onHoverState.BorderThickness = 1;
            this.btnMostrarTrabajadores.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMostrarTrabajadores.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTrabajadores.onHoverState.IconLeftImage = null;
            this.btnMostrarTrabajadores.onHoverState.IconRightImage = null;
            this.btnMostrarTrabajadores.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarTrabajadores.OnIdleState.BorderRadius = 1;
            this.btnMostrarTrabajadores.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarTrabajadores.OnIdleState.BorderThickness = 1;
            this.btnMostrarTrabajadores.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarTrabajadores.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTrabajadores.OnIdleState.IconLeftImage = null;
            this.btnMostrarTrabajadores.OnIdleState.IconRightImage = null;
            this.btnMostrarTrabajadores.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarTrabajadores.OnPressedState.BorderRadius = 1;
            this.btnMostrarTrabajadores.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarTrabajadores.OnPressedState.BorderThickness = 1;
            this.btnMostrarTrabajadores.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarTrabajadores.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTrabajadores.OnPressedState.IconLeftImage = null;
            this.btnMostrarTrabajadores.OnPressedState.IconRightImage = null;
            this.btnMostrarTrabajadores.Size = new System.Drawing.Size(170, 51);
            this.btnMostrarTrabajadores.TabIndex = 99;
            this.btnMostrarTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarTrabajadores.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrarTrabajadores.TextMarginLeft = 0;
            this.btnMostrarTrabajadores.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMostrarTrabajadores.UseDefaultRadiusAndThickness = true;
            this.btnMostrarTrabajadores.Click += new System.EventHandler(this.btnMostrarTrabajadores_Click_1);
            // 
            // btnMostrarInvActivos
            // 
            this.btnMostrarInvActivos.AllowAnimations = true;
            this.btnMostrarInvActivos.AllowMouseEffects = true;
            this.btnMostrarInvActivos.AllowToggling = false;
            this.btnMostrarInvActivos.AnimationSpeed = 200;
            this.btnMostrarInvActivos.AutoGenerateColors = false;
            this.btnMostrarInvActivos.AutoRoundBorders = false;
            this.btnMostrarInvActivos.AutoSizeLeftIcon = true;
            this.btnMostrarInvActivos.AutoSizeRightIcon = true;
            this.btnMostrarInvActivos.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarInvActivos.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvActivos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarInvActivos.BackgroundImage")));
            this.btnMostrarInvActivos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvActivos.ButtonText = "Mostrar Inventarios Activos";
            this.btnMostrarInvActivos.ButtonTextMarginLeft = 0;
            this.btnMostrarInvActivos.ColorContrastOnClick = 45;
            this.btnMostrarInvActivos.ColorContrastOnHover = 45;
            this.btnMostrarInvActivos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnMostrarInvActivos.CustomizableEdges = borderEdges2;
            this.btnMostrarInvActivos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrarInvActivos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarInvActivos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarInvActivos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarInvActivos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMostrarInvActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInvActivos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvActivos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarInvActivos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarInvActivos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMostrarInvActivos.IconMarginLeft = 11;
            this.btnMostrarInvActivos.IconPadding = 10;
            this.btnMostrarInvActivos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarInvActivos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarInvActivos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMostrarInvActivos.IconSize = 25;
            this.btnMostrarInvActivos.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvActivos.IdleBorderRadius = 1;
            this.btnMostrarInvActivos.IdleBorderThickness = 1;
            this.btnMostrarInvActivos.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvActivos.IdleIconLeftImage = null;
            this.btnMostrarInvActivos.IdleIconRightImage = null;
            this.btnMostrarInvActivos.IndicateFocus = false;
            this.btnMostrarInvActivos.Location = new System.Drawing.Point(206, 98);
            this.btnMostrarInvActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarInvActivos.Name = "btnMostrarInvActivos";
            this.btnMostrarInvActivos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarInvActivos.OnDisabledState.BorderRadius = 1;
            this.btnMostrarInvActivos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvActivos.OnDisabledState.BorderThickness = 1;
            this.btnMostrarInvActivos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarInvActivos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarInvActivos.OnDisabledState.IconLeftImage = null;
            this.btnMostrarInvActivos.OnDisabledState.IconRightImage = null;
            this.btnMostrarInvActivos.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrarInvActivos.onHoverState.BorderRadius = 1;
            this.btnMostrarInvActivos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvActivos.onHoverState.BorderThickness = 1;
            this.btnMostrarInvActivos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMostrarInvActivos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvActivos.onHoverState.IconLeftImage = null;
            this.btnMostrarInvActivos.onHoverState.IconRightImage = null;
            this.btnMostrarInvActivos.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvActivos.OnIdleState.BorderRadius = 1;
            this.btnMostrarInvActivos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvActivos.OnIdleState.BorderThickness = 1;
            this.btnMostrarInvActivos.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvActivos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvActivos.OnIdleState.IconLeftImage = null;
            this.btnMostrarInvActivos.OnIdleState.IconRightImage = null;
            this.btnMostrarInvActivos.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarInvActivos.OnPressedState.BorderRadius = 1;
            this.btnMostrarInvActivos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvActivos.OnPressedState.BorderThickness = 1;
            this.btnMostrarInvActivos.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarInvActivos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvActivos.OnPressedState.IconLeftImage = null;
            this.btnMostrarInvActivos.OnPressedState.IconRightImage = null;
            this.btnMostrarInvActivos.Size = new System.Drawing.Size(205, 51);
            this.btnMostrarInvActivos.TabIndex = 100;
            this.btnMostrarInvActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarInvActivos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrarInvActivos.TextMarginLeft = 0;
            this.btnMostrarInvActivos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMostrarInvActivos.UseDefaultRadiusAndThickness = true;
            this.btnMostrarInvActivos.Click += new System.EventHandler(this.btnMostrarInvActivos_Click_1);
            // 
            // btnMostrarInvDetalle
            // 
            this.btnMostrarInvDetalle.AllowAnimations = true;
            this.btnMostrarInvDetalle.AllowMouseEffects = true;
            this.btnMostrarInvDetalle.AllowToggling = false;
            this.btnMostrarInvDetalle.AnimationSpeed = 200;
            this.btnMostrarInvDetalle.AutoGenerateColors = false;
            this.btnMostrarInvDetalle.AutoRoundBorders = false;
            this.btnMostrarInvDetalle.AutoSizeLeftIcon = true;
            this.btnMostrarInvDetalle.AutoSizeRightIcon = true;
            this.btnMostrarInvDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarInvDetalle.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarInvDetalle.BackgroundImage")));
            this.btnMostrarInvDetalle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvDetalle.ButtonText = "Mostrar Detalle del Inventario";
            this.btnMostrarInvDetalle.ButtonTextMarginLeft = 0;
            this.btnMostrarInvDetalle.ColorContrastOnClick = 45;
            this.btnMostrarInvDetalle.ColorContrastOnHover = 45;
            this.btnMostrarInvDetalle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnMostrarInvDetalle.CustomizableEdges = borderEdges1;
            this.btnMostrarInvDetalle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrarInvDetalle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarInvDetalle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarInvDetalle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarInvDetalle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMostrarInvDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInvDetalle.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvDetalle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarInvDetalle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarInvDetalle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMostrarInvDetalle.IconMarginLeft = 11;
            this.btnMostrarInvDetalle.IconPadding = 10;
            this.btnMostrarInvDetalle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarInvDetalle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMostrarInvDetalle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMostrarInvDetalle.IconSize = 25;
            this.btnMostrarInvDetalle.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvDetalle.IdleBorderRadius = 1;
            this.btnMostrarInvDetalle.IdleBorderThickness = 1;
            this.btnMostrarInvDetalle.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvDetalle.IdleIconLeftImage = null;
            this.btnMostrarInvDetalle.IdleIconRightImage = null;
            this.btnMostrarInvDetalle.IndicateFocus = false;
            this.btnMostrarInvDetalle.Location = new System.Drawing.Point(417, 98);
            this.btnMostrarInvDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarInvDetalle.Name = "btnMostrarInvDetalle";
            this.btnMostrarInvDetalle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMostrarInvDetalle.OnDisabledState.BorderRadius = 1;
            this.btnMostrarInvDetalle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvDetalle.OnDisabledState.BorderThickness = 1;
            this.btnMostrarInvDetalle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMostrarInvDetalle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMostrarInvDetalle.OnDisabledState.IconLeftImage = null;
            this.btnMostrarInvDetalle.OnDisabledState.IconRightImage = null;
            this.btnMostrarInvDetalle.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrarInvDetalle.onHoverState.BorderRadius = 1;
            this.btnMostrarInvDetalle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvDetalle.onHoverState.BorderThickness = 1;
            this.btnMostrarInvDetalle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMostrarInvDetalle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvDetalle.onHoverState.IconLeftImage = null;
            this.btnMostrarInvDetalle.onHoverState.IconRightImage = null;
            this.btnMostrarInvDetalle.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvDetalle.OnIdleState.BorderRadius = 1;
            this.btnMostrarInvDetalle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvDetalle.OnIdleState.BorderThickness = 1;
            this.btnMostrarInvDetalle.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarInvDetalle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvDetalle.OnIdleState.IconLeftImage = null;
            this.btnMostrarInvDetalle.OnIdleState.IconRightImage = null;
            this.btnMostrarInvDetalle.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarInvDetalle.OnPressedState.BorderRadius = 1;
            this.btnMostrarInvDetalle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMostrarInvDetalle.OnPressedState.BorderThickness = 1;
            this.btnMostrarInvDetalle.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnMostrarInvDetalle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInvDetalle.OnPressedState.IconLeftImage = null;
            this.btnMostrarInvDetalle.OnPressedState.IconRightImage = null;
            this.btnMostrarInvDetalle.Size = new System.Drawing.Size(229, 51);
            this.btnMostrarInvDetalle.TabIndex = 101;
            this.btnMostrarInvDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarInvDetalle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrarInvDetalle.TextMarginLeft = 0;
            this.btnMostrarInvDetalle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMostrarInvDetalle.UseDefaultRadiusAndThickness = true;
            this.btnMostrarInvDetalle.Click += new System.EventHandler(this.btnMostrarInvDetalle_Click_1);
            // 
            // FrmAdministradorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Presentacion.Properties.Resources._4812d3cc80cd265ffab17b38b20b9eb3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdministradorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorPrincipal";
            this.Load += new System.EventHandler(this.FrmAdministradorPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMostrarTrabajadores;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMostrarInvActivos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMostrarInvDetalle;
    }
}