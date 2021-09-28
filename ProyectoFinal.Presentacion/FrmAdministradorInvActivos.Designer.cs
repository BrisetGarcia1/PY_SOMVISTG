
namespace ProyectoFinal.Presentacion
{
    partial class FrmAdministradorInvActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministradorInvActivos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.cmbInventario = new System.Windows.Forms.ComboBox();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDesactivarInventario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnActivarInventario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(86, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Inventarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(86, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Inventarios:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 90;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvGrilla.Location = new System.Drawing.Point(69, 175);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(428, 181);
            this.dgvGrilla.TabIndex = 29;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            // 
            // cmbInventario
            // 
            this.cmbInventario.BackColor = System.Drawing.Color.White;
            this.cmbInventario.FormattingEnabled = true;
            this.cmbInventario.Location = new System.Drawing.Point(198, 61);
            this.cmbInventario.Name = "cmbInventario";
            this.cmbInventario.Size = new System.Drawing.Size(272, 21);
            this.cmbInventario.TabIndex = 30;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.chkSeleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.chkSeleccionar.Location = new System.Drawing.Point(373, 109);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(107, 21);
            this.chkSeleccionar.TabIndex = 31;
            this.chkSeleccionar.Text = "seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = false;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnDesactivarInventario);
            this.panel1.Controls.Add(this.btnActivarInventario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvGrilla);
            this.panel1.Controls.Add(this.chkSeleccionar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbInventario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 407);
            this.panel1.TabIndex = 32;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRegresar.CustomizableEdges = borderEdges1;
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
            this.btnRegresar.Location = new System.Drawing.Point(402, 363);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnRegresar.Size = new System.Drawing.Size(95, 28);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegresar.TextMarginLeft = 0;
            this.btnRegresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegresar.UseDefaultRadiusAndThickness = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnDesactivarInventario
            // 
            this.btnDesactivarInventario.AllowAnimations = true;
            this.btnDesactivarInventario.AllowMouseEffects = true;
            this.btnDesactivarInventario.AllowToggling = false;
            this.btnDesactivarInventario.AnimationSpeed = 200;
            this.btnDesactivarInventario.AutoGenerateColors = false;
            this.btnDesactivarInventario.AutoRoundBorders = false;
            this.btnDesactivarInventario.AutoSizeLeftIcon = true;
            this.btnDesactivarInventario.AutoSizeRightIcon = true;
            this.btnDesactivarInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnDesactivarInventario.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnDesactivarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesactivarInventario.BackgroundImage")));
            this.btnDesactivarInventario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivarInventario.ButtonText = "Desactivar Inventario";
            this.btnDesactivarInventario.ButtonTextMarginLeft = 0;
            this.btnDesactivarInventario.ColorContrastOnClick = 45;
            this.btnDesactivarInventario.ColorContrastOnHover = 45;
            this.btnDesactivarInventario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDesactivarInventario.CustomizableEdges = borderEdges2;
            this.btnDesactivarInventario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDesactivarInventario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDesactivarInventario.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDesactivarInventario.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDesactivarInventario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDesactivarInventario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarInventario.ForeColor = System.Drawing.Color.White;
            this.btnDesactivarInventario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesactivarInventario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDesactivarInventario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDesactivarInventario.IconMarginLeft = 11;
            this.btnDesactivarInventario.IconPadding = 10;
            this.btnDesactivarInventario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesactivarInventario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDesactivarInventario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDesactivarInventario.IconSize = 25;
            this.btnDesactivarInventario.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDesactivarInventario.IdleBorderRadius = 1;
            this.btnDesactivarInventario.IdleBorderThickness = 1;
            this.btnDesactivarInventario.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDesactivarInventario.IdleIconLeftImage = null;
            this.btnDesactivarInventario.IdleIconRightImage = null;
            this.btnDesactivarInventario.IndicateFocus = false;
            this.btnDesactivarInventario.Location = new System.Drawing.Point(230, 101);
            this.btnDesactivarInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesactivarInventario.Name = "btnDesactivarInventario";
            this.btnDesactivarInventario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDesactivarInventario.OnDisabledState.BorderRadius = 1;
            this.btnDesactivarInventario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivarInventario.OnDisabledState.BorderThickness = 1;
            this.btnDesactivarInventario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDesactivarInventario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDesactivarInventario.OnDisabledState.IconLeftImage = null;
            this.btnDesactivarInventario.OnDisabledState.IconRightImage = null;
            this.btnDesactivarInventario.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDesactivarInventario.onHoverState.BorderRadius = 1;
            this.btnDesactivarInventario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivarInventario.onHoverState.BorderThickness = 1;
            this.btnDesactivarInventario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDesactivarInventario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivarInventario.onHoverState.IconLeftImage = null;
            this.btnDesactivarInventario.onHoverState.IconRightImage = null;
            this.btnDesactivarInventario.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDesactivarInventario.OnIdleState.BorderRadius = 1;
            this.btnDesactivarInventario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivarInventario.OnIdleState.BorderThickness = 1;
            this.btnDesactivarInventario.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDesactivarInventario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivarInventario.OnIdleState.IconLeftImage = null;
            this.btnDesactivarInventario.OnIdleState.IconRightImage = null;
            this.btnDesactivarInventario.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnDesactivarInventario.OnPressedState.BorderRadius = 1;
            this.btnDesactivarInventario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDesactivarInventario.OnPressedState.BorderThickness = 1;
            this.btnDesactivarInventario.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnDesactivarInventario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDesactivarInventario.OnPressedState.IconLeftImage = null;
            this.btnDesactivarInventario.OnPressedState.IconRightImage = null;
            this.btnDesactivarInventario.Size = new System.Drawing.Size(128, 32);
            this.btnDesactivarInventario.TabIndex = 51;
            this.btnDesactivarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDesactivarInventario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDesactivarInventario.TextMarginLeft = 0;
            this.btnDesactivarInventario.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDesactivarInventario.UseDefaultRadiusAndThickness = true;
            this.btnDesactivarInventario.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnActivarInventario
            // 
            this.btnActivarInventario.AllowAnimations = true;
            this.btnActivarInventario.AllowMouseEffects = true;
            this.btnActivarInventario.AllowToggling = false;
            this.btnActivarInventario.AnimationSpeed = 200;
            this.btnActivarInventario.AutoGenerateColors = false;
            this.btnActivarInventario.AutoRoundBorders = false;
            this.btnActivarInventario.AutoSizeLeftIcon = true;
            this.btnActivarInventario.AutoSizeRightIcon = true;
            this.btnActivarInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnActivarInventario.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnActivarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActivarInventario.BackgroundImage")));
            this.btnActivarInventario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivarInventario.ButtonText = "Activar Inventario";
            this.btnActivarInventario.ButtonTextMarginLeft = 0;
            this.btnActivarInventario.ColorContrastOnClick = 45;
            this.btnActivarInventario.ColorContrastOnHover = 45;
            this.btnActivarInventario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnActivarInventario.CustomizableEdges = borderEdges3;
            this.btnActivarInventario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivarInventario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActivarInventario.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActivarInventario.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActivarInventario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnActivarInventario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarInventario.ForeColor = System.Drawing.Color.White;
            this.btnActivarInventario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivarInventario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnActivarInventario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnActivarInventario.IconMarginLeft = 11;
            this.btnActivarInventario.IconPadding = 10;
            this.btnActivarInventario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivarInventario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnActivarInventario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnActivarInventario.IconSize = 25;
            this.btnActivarInventario.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivarInventario.IdleBorderRadius = 1;
            this.btnActivarInventario.IdleBorderThickness = 1;
            this.btnActivarInventario.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivarInventario.IdleIconLeftImage = null;
            this.btnActivarInventario.IdleIconRightImage = null;
            this.btnActivarInventario.IndicateFocus = false;
            this.btnActivarInventario.Location = new System.Drawing.Point(88, 101);
            this.btnActivarInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActivarInventario.Name = "btnActivarInventario";
            this.btnActivarInventario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnActivarInventario.OnDisabledState.BorderRadius = 1;
            this.btnActivarInventario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivarInventario.OnDisabledState.BorderThickness = 1;
            this.btnActivarInventario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnActivarInventario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnActivarInventario.OnDisabledState.IconLeftImage = null;
            this.btnActivarInventario.OnDisabledState.IconRightImage = null;
            this.btnActivarInventario.onHoverState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActivarInventario.onHoverState.BorderRadius = 1;
            this.btnActivarInventario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivarInventario.onHoverState.BorderThickness = 1;
            this.btnActivarInventario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnActivarInventario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnActivarInventario.onHoverState.IconLeftImage = null;
            this.btnActivarInventario.onHoverState.IconRightImage = null;
            this.btnActivarInventario.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivarInventario.OnIdleState.BorderRadius = 1;
            this.btnActivarInventario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivarInventario.OnIdleState.BorderThickness = 1;
            this.btnActivarInventario.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnActivarInventario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnActivarInventario.OnIdleState.IconLeftImage = null;
            this.btnActivarInventario.OnIdleState.IconRightImage = null;
            this.btnActivarInventario.OnPressedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnActivarInventario.OnPressedState.BorderRadius = 1;
            this.btnActivarInventario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnActivarInventario.OnPressedState.BorderThickness = 1;
            this.btnActivarInventario.OnPressedState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnActivarInventario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnActivarInventario.OnPressedState.IconLeftImage = null;
            this.btnActivarInventario.OnPressedState.IconRightImage = null;
            this.btnActivarInventario.Size = new System.Drawing.Size(128, 32);
            this.btnActivarInventario.TabIndex = 50;
            this.btnActivarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActivarInventario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActivarInventario.TextMarginLeft = 0;
            this.btnActivarInventario.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnActivarInventario.UseDefaultRadiusAndThickness = true;
            this.btnActivarInventario.Click += new System.EventHandler(this.btnActivarInventario_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "SELECCIONAR EL INVENTARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmAdministradorInvActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministradorInvActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministradorInvActivos";
            this.Load += new System.EventHandler(this.FrmAdministradorInvActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.ComboBox cmbInventario;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnActivarInventario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDesactivarInventario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegresar;
    }
}