
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradorMostrarTrabajadores));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvGrilla1 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarTrabajador = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnQuitarTrabajador = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla1
            // 
            this.dgvGrilla1.AllowUserToAddRows = false;
            this.dgvGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla1.Location = new System.Drawing.Point(202, 98);
            this.dgvGrilla1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrilla1.Name = "dgvGrilla1";
            this.dgvGrilla1.ReadOnly = true;
            this.dgvGrilla1.RowHeadersWidth = 51;
            this.dgvGrilla1.Size = new System.Drawing.Size(435, 217);
            this.dgvGrilla1.TabIndex = 33;
            this.dgvGrilla1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla1_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.chkSeleccionar.Location = new System.Drawing.Point(39, 332);
            this.chkSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(128, 23);
            this.chkSeleccionar.TabIndex = 94;
            this.chkSeleccionar.Text = "seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = false;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuitarTrabajador);
            this.panel1.Controls.Add(this.btnAgregarTrabajador);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.chkSeleccionar);
            this.panel1.Controls.Add(this.dgvGrilla1);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 406);
            this.panel1.TabIndex = 95;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnRegresar.CustomizableEdges = borderEdges3;
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
            this.btnRegresar.Location = new System.Drawing.Point(510, 332);
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
            this.btnRegresar.TabIndex = 95;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegresar.TextMarginLeft = 0;
            this.btnRegresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegresar.UseDefaultRadiusAndThickness = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(233, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 30);
            this.label3.TabIndex = 96;
            this.label3.Text = "TRABAJADORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "Trabajadores:";
            // 
            // btnAgregarTrabajador
            // 
            this.btnAgregarTrabajador.AllowAnimations = true;
            this.btnAgregarTrabajador.AllowMouseEffects = true;
            this.btnAgregarTrabajador.AllowToggling = false;
            this.btnAgregarTrabajador.AnimationSpeed = 200;
            this.btnAgregarTrabajador.AutoGenerateColors = false;
            this.btnAgregarTrabajador.AutoRoundBorders = false;
            this.btnAgregarTrabajador.AutoSizeLeftIcon = true;
            this.btnAgregarTrabajador.AutoSizeRightIcon = true;
            this.btnAgregarTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTrabajador.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarTrabajador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarTrabajador.BackgroundImage")));
            this.btnAgregarTrabajador.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarTrabajador.ButtonText = "Agregar Trabajador";
            this.btnAgregarTrabajador.ButtonTextMarginLeft = 0;
            this.btnAgregarTrabajador.ColorContrastOnClick = 45;
            this.btnAgregarTrabajador.ColorContrastOnHover = 45;
            this.btnAgregarTrabajador.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAgregarTrabajador.CustomizableEdges = borderEdges2;
            this.btnAgregarTrabajador.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarTrabajador.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarTrabajador.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarTrabajador.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarTrabajador.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTrabajador.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajador.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTrabajador.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarTrabajador.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarTrabajador.IconMarginLeft = 11;
            this.btnAgregarTrabajador.IconPadding = 10;
            this.btnAgregarTrabajador.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTrabajador.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarTrabajador.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarTrabajador.IconSize = 25;
            this.btnAgregarTrabajador.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarTrabajador.IdleBorderRadius = 1;
            this.btnAgregarTrabajador.IdleBorderThickness = 1;
            this.btnAgregarTrabajador.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarTrabajador.IdleIconLeftImage = null;
            this.btnAgregarTrabajador.IdleIconRightImage = null;
            this.btnAgregarTrabajador.IndicateFocus = false;
            this.btnAgregarTrabajador.Location = new System.Drawing.Point(26, 147);
            this.btnAgregarTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTrabajador.Name = "btnAgregarTrabajador";
            this.btnAgregarTrabajador.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarTrabajador.OnDisabledState.BorderRadius = 1;
            this.btnAgregarTrabajador.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarTrabajador.OnDisabledState.BorderThickness = 1;
            this.btnAgregarTrabajador.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarTrabajador.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarTrabajador.OnDisabledState.IconLeftImage = null;
            this.btnAgregarTrabajador.OnDisabledState.IconRightImage = null;
            this.btnAgregarTrabajador.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarTrabajador.onHoverState.BorderRadius = 1;
            this.btnAgregarTrabajador.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarTrabajador.onHoverState.BorderThickness = 1;
            this.btnAgregarTrabajador.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarTrabajador.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajador.onHoverState.IconLeftImage = null;
            this.btnAgregarTrabajador.onHoverState.IconRightImage = null;
            this.btnAgregarTrabajador.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarTrabajador.OnIdleState.BorderRadius = 1;
            this.btnAgregarTrabajador.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarTrabajador.OnIdleState.BorderThickness = 1;
            this.btnAgregarTrabajador.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarTrabajador.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajador.OnIdleState.IconLeftImage = null;
            this.btnAgregarTrabajador.OnIdleState.IconRightImage = null;
            this.btnAgregarTrabajador.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarTrabajador.OnPressedState.BorderRadius = 1;
            this.btnAgregarTrabajador.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarTrabajador.OnPressedState.BorderThickness = 1;
            this.btnAgregarTrabajador.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarTrabajador.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTrabajador.OnPressedState.IconLeftImage = null;
            this.btnAgregarTrabajador.OnPressedState.IconRightImage = null;
            this.btnAgregarTrabajador.Size = new System.Drawing.Size(153, 51);
            this.btnAgregarTrabajador.TabIndex = 98;
            this.btnAgregarTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarTrabajador.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarTrabajador.TextMarginLeft = 0;
            this.btnAgregarTrabajador.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarTrabajador.UseDefaultRadiusAndThickness = true;
            this.btnAgregarTrabajador.Click += new System.EventHandler(this.btnAgregarTrabajador_Click_1);
            // 
            // btnQuitarTrabajador
            // 
            this.btnQuitarTrabajador.AllowAnimations = true;
            this.btnQuitarTrabajador.AllowMouseEffects = true;
            this.btnQuitarTrabajador.AllowToggling = false;
            this.btnQuitarTrabajador.AnimationSpeed = 200;
            this.btnQuitarTrabajador.AutoGenerateColors = false;
            this.btnQuitarTrabajador.AutoRoundBorders = false;
            this.btnQuitarTrabajador.AutoSizeLeftIcon = true;
            this.btnQuitarTrabajador.AutoSizeRightIcon = true;
            this.btnQuitarTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarTrabajador.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnQuitarTrabajador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarTrabajador.BackgroundImage")));
            this.btnQuitarTrabajador.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQuitarTrabajador.ButtonText = "Quitar Trabajador";
            this.btnQuitarTrabajador.ButtonTextMarginLeft = 0;
            this.btnQuitarTrabajador.ColorContrastOnClick = 45;
            this.btnQuitarTrabajador.ColorContrastOnHover = 45;
            this.btnQuitarTrabajador.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnQuitarTrabajador.CustomizableEdges = borderEdges1;
            this.btnQuitarTrabajador.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuitarTrabajador.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnQuitarTrabajador.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQuitarTrabajador.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnQuitarTrabajador.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnQuitarTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTrabajador.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTrabajador.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarTrabajador.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitarTrabajador.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnQuitarTrabajador.IconMarginLeft = 11;
            this.btnQuitarTrabajador.IconPadding = 10;
            this.btnQuitarTrabajador.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarTrabajador.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnQuitarTrabajador.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnQuitarTrabajador.IconSize = 25;
            this.btnQuitarTrabajador.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuitarTrabajador.IdleBorderRadius = 1;
            this.btnQuitarTrabajador.IdleBorderThickness = 1;
            this.btnQuitarTrabajador.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuitarTrabajador.IdleIconLeftImage = null;
            this.btnQuitarTrabajador.IdleIconRightImage = null;
            this.btnQuitarTrabajador.IndicateFocus = false;
            this.btnQuitarTrabajador.Location = new System.Drawing.Point(26, 216);
            this.btnQuitarTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarTrabajador.Name = "btnQuitarTrabajador";
            this.btnQuitarTrabajador.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnQuitarTrabajador.OnDisabledState.BorderRadius = 1;
            this.btnQuitarTrabajador.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQuitarTrabajador.OnDisabledState.BorderThickness = 1;
            this.btnQuitarTrabajador.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnQuitarTrabajador.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnQuitarTrabajador.OnDisabledState.IconLeftImage = null;
            this.btnQuitarTrabajador.OnDisabledState.IconRightImage = null;
            this.btnQuitarTrabajador.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQuitarTrabajador.onHoverState.BorderRadius = 1;
            this.btnQuitarTrabajador.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQuitarTrabajador.onHoverState.BorderThickness = 1;
            this.btnQuitarTrabajador.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuitarTrabajador.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTrabajador.onHoverState.IconLeftImage = null;
            this.btnQuitarTrabajador.onHoverState.IconRightImage = null;
            this.btnQuitarTrabajador.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuitarTrabajador.OnIdleState.BorderRadius = 1;
            this.btnQuitarTrabajador.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQuitarTrabajador.OnIdleState.BorderThickness = 1;
            this.btnQuitarTrabajador.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuitarTrabajador.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTrabajador.OnIdleState.IconLeftImage = null;
            this.btnQuitarTrabajador.OnIdleState.IconRightImage = null;
            this.btnQuitarTrabajador.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnQuitarTrabajador.OnPressedState.BorderRadius = 1;
            this.btnQuitarTrabajador.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnQuitarTrabajador.OnPressedState.BorderThickness = 1;
            this.btnQuitarTrabajador.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnQuitarTrabajador.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTrabajador.OnPressedState.IconLeftImage = null;
            this.btnQuitarTrabajador.OnPressedState.IconRightImage = null;
            this.btnQuitarTrabajador.Size = new System.Drawing.Size(153, 51);
            this.btnQuitarTrabajador.TabIndex = 99;
            this.btnQuitarTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitarTrabajador.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQuitarTrabajador.TextMarginLeft = 0;
            this.btnQuitarTrabajador.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnQuitarTrabajador.UseDefaultRadiusAndThickness = true;
            this.btnQuitarTrabajador.Click += new System.EventHandler(this.btnQuitarTrabajador_Click_1);
            // 
            // FrmAdministradorMostrarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Presentacion.Properties.Resources._4812d3cc80cd265ffab17b38b20b9eb3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 462);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdministradorMostrarTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorMostrarTrabajadores";
            this.Load += new System.EventHandler(this.FrmAdministradorMostrarTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGrilla1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarTrabajador;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnQuitarTrabajador;
    }
}