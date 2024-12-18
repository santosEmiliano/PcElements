namespace WinFormsPcElements
{
    partial class FormTienda
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
            components = new System.ComponentModel.Container();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            panelHeader = new Panel();
            tableLayoutPanelFiltrosTipo = new TableLayoutPanel();
            buttonMotherBoard = new Button();
            buttonRAM = new Button();
            buttonProcesador = new Button();
            buttonFuente = new Button();
            buttonGrafica = new Button();
            buttonAltExitMenu = new Button();
            tableLayoutPanelExitMenu = new TableLayoutPanel();
            buttonSalir = new Button();
            panelMenuUser = new Panel();
            buttonUser = new Button();
            buttonMenu = new Button();
            timerSideBar = new System.Windows.Forms.Timer(components);
            timerComprar = new System.Windows.Forms.Timer(components);
            flowLayoutPanelSideBar = new FlowLayoutPanel();
            flowLayoutPanelComprar = new FlowLayoutPanel();
            panelComprar = new Panel();
            buttonComprar = new Button();
            labelFiltros = new Label();
            labelGama = new Label();
            tableLayoutPanelCheckBoxGama = new TableLayoutPanel();
            checkBoxGamaMedia = new CheckBox();
            checkBoxGamaBaja = new CheckBox();
            checkBoxGamaAlta = new CheckBox();
            labelPrecio = new Label();
            trackBarPrecio = new TrackBar();
            buttonArmarPc = new Button();
            buttonPagar = new Button();
            timerMotherBoard = new System.Windows.Forms.Timer(components);
            timerProcesador = new System.Windows.Forms.Timer(components);
            timerGrafica = new System.Windows.Forms.Timer(components);
            timerFuente = new System.Windows.Forms.Timer(components);
            timerRAM = new System.Windows.Forms.Timer(components);
            timerExitMenu = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            tableLayoutPanelHome = new TableLayoutPanel();
            labelHora = new Label();
            pictureBoxPcElements = new PictureBox();
            timerHora = new System.Windows.Forms.Timer(components);
            labelLema = new Label();
            panelHeader.SuspendLayout();
            tableLayoutPanelFiltrosTipo.SuspendLayout();
            tableLayoutPanelExitMenu.SuspendLayout();
            panelMenuUser.SuspendLayout();
            flowLayoutPanelSideBar.SuspendLayout();
            flowLayoutPanelComprar.SuspendLayout();
            panelComprar.SuspendLayout();
            tableLayoutPanelCheckBoxGama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPrecio).BeginInit();
            panelMain.SuspendLayout();
            tableLayoutPanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPcElements).BeginInit();
            SuspendLayout();
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(36, 104, 84);
            panelHeader.Controls.Add(tableLayoutPanelFiltrosTipo);
            panelHeader.Controls.Add(buttonAltExitMenu);
            panelHeader.Controls.Add(tableLayoutPanelExitMenu);
            panelHeader.Controls.Add(panelMenuUser);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1101, 76);
            panelHeader.TabIndex = 1;
            // 
            // tableLayoutPanelFiltrosTipo
            // 
            tableLayoutPanelFiltrosTipo.ColumnCount = 5;
            tableLayoutPanelFiltrosTipo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelFiltrosTipo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelFiltrosTipo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelFiltrosTipo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelFiltrosTipo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelFiltrosTipo.Controls.Add(buttonMotherBoard, 0, 0);
            tableLayoutPanelFiltrosTipo.Controls.Add(buttonRAM, 4, 0);
            tableLayoutPanelFiltrosTipo.Controls.Add(buttonProcesador, 1, 0);
            tableLayoutPanelFiltrosTipo.Controls.Add(buttonFuente, 3, 0);
            tableLayoutPanelFiltrosTipo.Controls.Add(buttonGrafica, 2, 0);
            tableLayoutPanelFiltrosTipo.Dock = DockStyle.Fill;
            tableLayoutPanelFiltrosTipo.Location = new Point(214, 0);
            tableLayoutPanelFiltrosTipo.Name = "tableLayoutPanelFiltrosTipo";
            tableLayoutPanelFiltrosTipo.RowCount = 1;
            tableLayoutPanelFiltrosTipo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFiltrosTipo.Size = new Size(773, 76);
            tableLayoutPanelFiltrosTipo.TabIndex = 9;
            // 
            // buttonMotherBoard
            // 
            buttonMotherBoard.Anchor = AnchorStyles.None;
            buttonMotherBoard.Enabled = false;
            buttonMotherBoard.FlatStyle = FlatStyle.Flat;
            buttonMotherBoard.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonMotherBoard.ForeColor = Color.White;
            buttonMotherBoard.Image = Properties.Resources.logoMotherBoard;
            buttonMotherBoard.ImageAlign = ContentAlignment.TopLeft;
            buttonMotherBoard.Location = new Point(13, 2);
            buttonMotherBoard.Margin = new Padding(3, 2, 3, 2);
            buttonMotherBoard.Name = "buttonMotherBoard";
            buttonMotherBoard.Size = new Size(128, 72);
            buttonMotherBoard.TabIndex = 2;
            buttonMotherBoard.Text = "Placa Madre";
            buttonMotherBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMotherBoard.UseVisualStyleBackColor = true;
            buttonMotherBoard.Click += buttonMotherBoard_Click;
            // 
            // buttonRAM
            // 
            buttonRAM.Anchor = AnchorStyles.None;
            buttonRAM.Enabled = false;
            buttonRAM.FlatStyle = FlatStyle.Flat;
            buttonRAM.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonRAM.ForeColor = Color.White;
            buttonRAM.Image = Properties.Resources.logoRam;
            buttonRAM.Location = new Point(622, 2);
            buttonRAM.Margin = new Padding(3, 2, 3, 2);
            buttonRAM.Name = "buttonRAM";
            buttonRAM.Size = new Size(144, 72);
            buttonRAM.TabIndex = 6;
            buttonRAM.Text = "Memoria RAM";
            buttonRAM.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRAM.UseVisualStyleBackColor = true;
            buttonRAM.Click += buttonRAM_Click;
            // 
            // buttonProcesador
            // 
            buttonProcesador.Anchor = AnchorStyles.None;
            buttonProcesador.Enabled = false;
            buttonProcesador.FlatStyle = FlatStyle.Flat;
            buttonProcesador.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonProcesador.ForeColor = Color.White;
            buttonProcesador.Image = Properties.Resources.logoProcesadores;
            buttonProcesador.Location = new Point(157, 2);
            buttonProcesador.Margin = new Padding(3, 2, 3, 2);
            buttonProcesador.Name = "buttonProcesador";
            buttonProcesador.Size = new Size(148, 72);
            buttonProcesador.TabIndex = 3;
            buttonProcesador.Text = "Procesador";
            buttonProcesador.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProcesador.UseVisualStyleBackColor = true;
            buttonProcesador.Click += buttonProcesador_Click;
            // 
            // buttonFuente
            // 
            buttonFuente.Anchor = AnchorStyles.None;
            buttonFuente.Enabled = false;
            buttonFuente.FlatStyle = FlatStyle.Flat;
            buttonFuente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonFuente.ForeColor = Color.White;
            buttonFuente.Image = Properties.Resources.logoFuente;
            buttonFuente.Location = new Point(465, 2);
            buttonFuente.Margin = new Padding(3, 2, 3, 2);
            buttonFuente.Name = "buttonFuente";
            buttonFuente.Size = new Size(148, 72);
            buttonFuente.TabIndex = 5;
            buttonFuente.Text = "Fuente de Poder";
            buttonFuente.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFuente.UseVisualStyleBackColor = true;
            buttonFuente.Click += buttonFuente_Click;
            // 
            // buttonGrafica
            // 
            buttonGrafica.Anchor = AnchorStyles.None;
            buttonGrafica.Enabled = false;
            buttonGrafica.FlatStyle = FlatStyle.Flat;
            buttonGrafica.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonGrafica.ForeColor = Color.White;
            buttonGrafica.Image = Properties.Resources.logoGraficas;
            buttonGrafica.Location = new Point(318, 2);
            buttonGrafica.Margin = new Padding(3, 2, 3, 2);
            buttonGrafica.Name = "buttonGrafica";
            buttonGrafica.Size = new Size(133, 72);
            buttonGrafica.TabIndex = 4;
            buttonGrafica.Text = "Tarjeta Grafica";
            buttonGrafica.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGrafica.UseVisualStyleBackColor = true;
            buttonGrafica.Click += buttonGrafica_Click;
            // 
            // buttonAltExitMenu
            // 
            buttonAltExitMenu.BackgroundImage = Properties.Resources.Arrow_left_circleDM;
            buttonAltExitMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonAltExitMenu.Cursor = Cursors.Hand;
            buttonAltExitMenu.Dock = DockStyle.Right;
            buttonAltExitMenu.FlatAppearance.BorderSize = 0;
            buttonAltExitMenu.FlatStyle = FlatStyle.Flat;
            buttonAltExitMenu.ForeColor = Color.FromArgb(61, 104, 104);
            buttonAltExitMenu.Location = new Point(987, 0);
            buttonAltExitMenu.Name = "buttonAltExitMenu";
            buttonAltExitMenu.Size = new Size(55, 76);
            buttonAltExitMenu.TabIndex = 8;
            buttonAltExitMenu.UseVisualStyleBackColor = true;
            buttonAltExitMenu.Click += buttonAltExitMenu_Click;
            // 
            // tableLayoutPanelExitMenu
            // 
            tableLayoutPanelExitMenu.ColumnCount = 1;
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanelExitMenu.Controls.Add(buttonSalir, 0, 0);
            tableLayoutPanelExitMenu.Dock = DockStyle.Right;
            tableLayoutPanelExitMenu.Location = new Point(1042, 0);
            tableLayoutPanelExitMenu.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelExitMenu.Name = "tableLayoutPanelExitMenu";
            tableLayoutPanelExitMenu.RowCount = 1;
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.Size = new Size(59, 76);
            tableLayoutPanelExitMenu.TabIndex = 7;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.None;
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources.closeIcon;
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(7, 15);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(45, 46);
            buttonSalir.TabIndex = 4;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panelMenuUser
            // 
            panelMenuUser.Controls.Add(buttonUser);
            panelMenuUser.Controls.Add(buttonMenu);
            panelMenuUser.Dock = DockStyle.Left;
            panelMenuUser.Location = new Point(0, 0);
            panelMenuUser.Margin = new Padding(3, 2, 3, 2);
            panelMenuUser.Name = "panelMenuUser";
            panelMenuUser.Size = new Size(214, 76);
            panelMenuUser.TabIndex = 1;
            // 
            // buttonUser
            // 
            buttonUser.BackgroundImage = Properties.Resources.UserDM;
            buttonUser.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUser.Dock = DockStyle.Fill;
            buttonUser.FlatAppearance.BorderSize = 0;
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Location = new Point(60, 0);
            buttonUser.Margin = new Padding(3, 2, 3, 2);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(154, 76);
            buttonUser.TabIndex = 1;
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.Dock = DockStyle.Left;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Image = Properties.Resources.Menu;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(3, 2, 3, 2);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(60, 76);
            buttonMenu.TabIndex = 0;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // timerSideBar
            // 
            timerSideBar.Enabled = true;
            timerSideBar.Interval = 1;
            timerSideBar.Tick += timerSideBar_Tick;
            // 
            // timerComprar
            // 
            timerComprar.Enabled = true;
            timerComprar.Interval = 10;
            timerComprar.Tick += timerComprar_Tick;
            // 
            // flowLayoutPanelSideBar
            // 
            flowLayoutPanelSideBar.BackColor = Color.FromArgb(36, 104, 84);
            flowLayoutPanelSideBar.Controls.Add(flowLayoutPanelComprar);
            flowLayoutPanelSideBar.Controls.Add(buttonArmarPc);
            flowLayoutPanelSideBar.Controls.Add(buttonPagar);
            flowLayoutPanelSideBar.Dock = DockStyle.Left;
            flowLayoutPanelSideBar.Enabled = false;
            flowLayoutPanelSideBar.Location = new Point(0, 76);
            flowLayoutPanelSideBar.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelSideBar.Name = "flowLayoutPanelSideBar";
            flowLayoutPanelSideBar.Size = new Size(214, 486);
            flowLayoutPanelSideBar.TabIndex = 0;
            // 
            // flowLayoutPanelComprar
            // 
            flowLayoutPanelComprar.BackColor = Color.Transparent;
            flowLayoutPanelComprar.Controls.Add(panelComprar);
            flowLayoutPanelComprar.Controls.Add(labelFiltros);
            flowLayoutPanelComprar.Controls.Add(labelGama);
            flowLayoutPanelComprar.Controls.Add(tableLayoutPanelCheckBoxGama);
            flowLayoutPanelComprar.Controls.Add(labelPrecio);
            flowLayoutPanelComprar.Controls.Add(trackBarPrecio);
            flowLayoutPanelComprar.Dock = DockStyle.Top;
            flowLayoutPanelComprar.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelComprar.Location = new Point(3, 2);
            flowLayoutPanelComprar.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelComprar.Name = "flowLayoutPanelComprar";
            flowLayoutPanelComprar.Size = new Size(208, 339);
            flowLayoutPanelComprar.TabIndex = 1;
            // 
            // panelComprar
            // 
            panelComprar.Controls.Add(buttonComprar);
            panelComprar.Location = new Point(3, 2);
            panelComprar.Margin = new Padding(3, 2, 3, 2);
            panelComprar.Name = "panelComprar";
            panelComprar.Size = new Size(206, 61);
            panelComprar.TabIndex = 3;
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.Transparent;
            buttonComprar.FlatAppearance.BorderSize = 0;
            buttonComprar.FlatStyle = FlatStyle.Flat;
            buttonComprar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonComprar.ForeColor = Color.White;
            buttonComprar.Image = Properties.Resources.Shopping_cartDM;
            buttonComprar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonComprar.Location = new Point(0, 0);
            buttonComprar.Margin = new Padding(3, 2, 3, 2);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(206, 61);
            buttonComprar.TabIndex = 0;
            buttonComprar.Text = "  Comprar";
            buttonComprar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonComprar.UseVisualStyleBackColor = false;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // labelFiltros
            // 
            labelFiltros.FlatStyle = FlatStyle.Flat;
            labelFiltros.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            labelFiltros.ForeColor = Color.White;
            labelFiltros.Location = new Point(3, 73);
            labelFiltros.Margin = new Padding(3, 8, 3, 0);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(206, 21);
            labelFiltros.TabIndex = 1;
            labelFiltros.Text = "Filtros";
            labelFiltros.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelGama
            // 
            labelGama.FlatStyle = FlatStyle.Flat;
            labelGama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            labelGama.ForeColor = Color.White;
            labelGama.Location = new Point(3, 102);
            labelGama.Margin = new Padding(3, 8, 3, 0);
            labelGama.Name = "labelGama";
            labelGama.Size = new Size(68, 27);
            labelGama.TabIndex = 3;
            labelGama.Text = "Gama";
            labelGama.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelCheckBoxGama
            // 
            tableLayoutPanelCheckBoxGama.ColumnCount = 1;
            tableLayoutPanelCheckBoxGama.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCheckBoxGama.Controls.Add(checkBoxGamaMedia, 0, 1);
            tableLayoutPanelCheckBoxGama.Controls.Add(checkBoxGamaBaja, 0, 2);
            tableLayoutPanelCheckBoxGama.Controls.Add(checkBoxGamaAlta, 0, 0);
            tableLayoutPanelCheckBoxGama.ForeColor = Color.Transparent;
            tableLayoutPanelCheckBoxGama.Location = new Point(3, 132);
            tableLayoutPanelCheckBoxGama.Name = "tableLayoutPanelCheckBoxGama";
            tableLayoutPanelCheckBoxGama.RowCount = 3;
            tableLayoutPanelCheckBoxGama.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCheckBoxGama.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCheckBoxGama.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCheckBoxGama.Size = new Size(124, 96);
            tableLayoutPanelCheckBoxGama.TabIndex = 1;
            // 
            // checkBoxGamaMedia
            // 
            checkBoxGamaMedia.AutoSize = true;
            checkBoxGamaMedia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBoxGamaMedia.ForeColor = Color.White;
            checkBoxGamaMedia.Location = new Point(3, 34);
            checkBoxGamaMedia.Margin = new Padding(3, 2, 3, 2);
            checkBoxGamaMedia.Name = "checkBoxGamaMedia";
            checkBoxGamaMedia.Size = new Size(112, 22);
            checkBoxGamaMedia.TabIndex = 8;
            checkBoxGamaMedia.Text = "Gama Media";
            checkBoxGamaMedia.UseVisualStyleBackColor = true;
            checkBoxGamaMedia.CheckedChanged += checkBoxGamaMedia_CheckedChanged;
            // 
            // checkBoxGamaBaja
            // 
            checkBoxGamaBaja.AutoSize = true;
            checkBoxGamaBaja.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBoxGamaBaja.ForeColor = Color.White;
            checkBoxGamaBaja.Location = new Point(3, 66);
            checkBoxGamaBaja.Margin = new Padding(3, 2, 3, 2);
            checkBoxGamaBaja.Name = "checkBoxGamaBaja";
            checkBoxGamaBaja.Size = new Size(101, 22);
            checkBoxGamaBaja.TabIndex = 9;
            checkBoxGamaBaja.Text = "Gama Baja";
            checkBoxGamaBaja.UseVisualStyleBackColor = true;
            checkBoxGamaBaja.CheckedChanged += checkBoxGamaBaja_CheckedChanged;
            // 
            // checkBoxGamaAlta
            // 
            checkBoxGamaAlta.AutoSize = true;
            checkBoxGamaAlta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBoxGamaAlta.ForeColor = Color.White;
            checkBoxGamaAlta.Location = new Point(3, 2);
            checkBoxGamaAlta.Margin = new Padding(3, 2, 3, 2);
            checkBoxGamaAlta.Name = "checkBoxGamaAlta";
            checkBoxGamaAlta.Size = new Size(96, 22);
            checkBoxGamaAlta.TabIndex = 1;
            checkBoxGamaAlta.Text = "Gama Alta";
            checkBoxGamaAlta.UseVisualStyleBackColor = true;
            checkBoxGamaAlta.CheckedChanged += checkBoxGamaAlta_CheckedChanged;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.FlatStyle = FlatStyle.Flat;
            labelPrecio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(3, 239);
            labelPrecio.Margin = new Padding(3, 8, 3, 8);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(146, 20);
            labelPrecio.TabIndex = 6;
            labelPrecio.Text = "Precio: $0 - $15000";
            labelPrecio.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBarPrecio
            // 
            trackBarPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBarPrecio.Location = new Point(3, 275);
            trackBarPrecio.Margin = new Padding(3, 8, 3, 8);
            trackBarPrecio.Maximum = 5;
            trackBarPrecio.Name = "trackBarPrecio";
            trackBarPrecio.Size = new Size(206, 45);
            trackBarPrecio.TabIndex = 7;
            trackBarPrecio.Value = 5;
            trackBarPrecio.ValueChanged += trackBarPrecio_ValueChanged;
            // 
            // buttonArmarPc
            // 
            buttonArmarPc.BackColor = Color.Transparent;
            buttonArmarPc.Dock = DockStyle.Top;
            buttonArmarPc.FlatAppearance.BorderSize = 0;
            buttonArmarPc.FlatStyle = FlatStyle.Flat;
            buttonArmarPc.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonArmarPc.ForeColor = Color.White;
            buttonArmarPc.Image = Properties.Resources.ArmaTuPC;
            buttonArmarPc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonArmarPc.Location = new Point(3, 345);
            buttonArmarPc.Margin = new Padding(3, 2, 3, 2);
            buttonArmarPc.Name = "buttonArmarPc";
            buttonArmarPc.Size = new Size(206, 61);
            buttonArmarPc.TabIndex = 2;
            buttonArmarPc.Text = "  Arma Tu PC";
            buttonArmarPc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonArmarPc.UseVisualStyleBackColor = false;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.Black;
            buttonPagar.Dock = DockStyle.Top;
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            buttonPagar.ForeColor = Color.White;
            buttonPagar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPagar.Location = new Point(3, 433);
            buttonPagar.Margin = new Padding(3, 25, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(206, 61);
            buttonPagar.TabIndex = 3;
            buttonPagar.Text = "Pagar";
            buttonPagar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Visible = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // timerMotherBoard
            // 
            timerMotherBoard.Enabled = true;
            timerMotherBoard.Interval = 30;
            timerMotherBoard.Tick += timerMotherBoard_Tick;
            // 
            // timerProcesador
            // 
            timerProcesador.Enabled = true;
            timerProcesador.Interval = 30;
            timerProcesador.Tick += timerProcesador_Tick;
            // 
            // timerGrafica
            // 
            timerGrafica.Enabled = true;
            timerGrafica.Interval = 30;
            timerGrafica.Tick += timerGrafica_Tick;
            // 
            // timerFuente
            // 
            timerFuente.Enabled = true;
            timerFuente.Interval = 30;
            timerFuente.Tick += timerFuente_Tick;
            // 
            // timerRAM
            // 
            timerRAM.Enabled = true;
            timerRAM.Interval = 30;
            timerRAM.Tick += timerRAM_Tick;
            // 
            // timerExitMenu
            // 
            timerExitMenu.Enabled = true;
            timerExitMenu.Interval = 20;
            timerExitMenu.Tick += timerExitMenu_Tick;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(27, 87, 69);
            panelMain.Controls.Add(tableLayoutPanelHome);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(214, 76);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(887, 486);
            panelMain.TabIndex = 2;
            // 
            // tableLayoutPanelHome
            // 
            tableLayoutPanelHome.BackColor = Color.Transparent;
            tableLayoutPanelHome.ColumnCount = 1;
            tableLayoutPanelHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelHome.Controls.Add(labelLema, 0, 1);
            tableLayoutPanelHome.Controls.Add(pictureBoxPcElements, 0, 0);
            tableLayoutPanelHome.Controls.Add(labelHora, 0, 2);
            tableLayoutPanelHome.Dock = DockStyle.Fill;
            tableLayoutPanelHome.Location = new Point(0, 0);
            tableLayoutPanelHome.Name = "tableLayoutPanelHome";
            tableLayoutPanelHome.RowCount = 3;
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 56.790123F));
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 26.54321F));
            tableLayoutPanelHome.Size = new Size(887, 486);
            tableLayoutPanelHome.TabIndex = 0;
            // 
            // labelHora
            // 
            labelHora.BackColor = Color.Transparent;
            labelHora.Dock = DockStyle.Top;
            labelHora.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.White;
            labelHora.Location = new Point(3, 356);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(881, 66);
            labelHora.TabIndex = 1;
            labelHora.Text = "Hora_";
            labelHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPcElements
            // 
            pictureBoxPcElements.Anchor = AnchorStyles.None;
            pictureBoxPcElements.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            pictureBoxPcElements.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPcElements.Location = new Point(293, 3);
            pictureBoxPcElements.Name = "pictureBoxPcElements";
            pictureBoxPcElements.Size = new Size(300, 270);
            pictureBoxPcElements.TabIndex = 0;
            pictureBoxPcElements.TabStop = false;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Tick += timerHora_Tick;
            // 
            // labelLema
            // 
            labelLema.BackColor = Color.Transparent;
            labelLema.Dock = DockStyle.Top;
            labelLema.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLema.ForeColor = Color.White;
            labelLema.Location = new Point(3, 276);
            labelLema.Name = "labelLema";
            labelLema.Size = new Size(881, 66);
            labelLema.TabIndex = 2;
            labelLema.Text = "Powered Computational Enviroment";
            labelLema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormTienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 562);
            Controls.Add(panelMain);
            Controls.Add(flowLayoutPanelSideBar);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTienda";
            Opacity = 0D;
            Text = "FormTienda";
            Load += FormTienda_Load;
            panelHeader.ResumeLayout(false);
            tableLayoutPanelFiltrosTipo.ResumeLayout(false);
            tableLayoutPanelExitMenu.ResumeLayout(false);
            panelMenuUser.ResumeLayout(false);
            flowLayoutPanelSideBar.ResumeLayout(false);
            flowLayoutPanelComprar.ResumeLayout(false);
            flowLayoutPanelComprar.PerformLayout();
            panelComprar.ResumeLayout(false);
            tableLayoutPanelCheckBoxGama.ResumeLayout(false);
            tableLayoutPanelCheckBoxGama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPrecio).EndInit();
            panelMain.ResumeLayout(false);
            tableLayoutPanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPcElements).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerAnimacion;
        private Panel panelHeader;
        private System.Windows.Forms.Timer timerSideBar;
        private Button buttonMenu;
        private System.Windows.Forms.Timer timerComprar;
        private Panel panelMenuUser;
        private Button buttonUser;
        private FlowLayoutPanel flowLayoutPanelSideBar;
        private FlowLayoutPanel flowLayoutPanelComprar;
        private Panel panelComprar;
        private Button buttonComprar;
        private Label labelFiltros;
        private Label labelGama;
        private Label labelPrecio;
        private Button buttonArmarPc;
        private Button buttonGrafica;
        private Button buttonProcesador;
        private Button buttonMotherBoard;
        private Button buttonRAM;
        private Button buttonFuente;
        private System.Windows.Forms.Timer timerMotherBoard;
        private System.Windows.Forms.Timer timerProcesador;
        private System.Windows.Forms.Timer timerGrafica;
        private System.Windows.Forms.Timer timerFuente;
        private System.Windows.Forms.Timer timerRAM;
        private TrackBar trackBarPrecio;
        private Button buttonSalir;
        private TableLayoutPanel tableLayoutPanelExitMenu;
        private Button buttonAltExitMenu;
        private System.Windows.Forms.Timer timerExitMenu;
        private Panel panelMain;
        private CheckBox checkBoxGamaAlta;
        private CheckBox checkBoxGamaMedia;
        private CheckBox checkBoxGamaBaja;
        private Button buttonPagar;
        private TableLayoutPanel tableLayoutPanelHome;
        private PictureBox pictureBoxPcElements;
        private Label labelHora;
        private System.Windows.Forms.Timer timerHora;
        private TableLayoutPanel tableLayoutPanelFiltrosTipo;
        private TableLayoutPanel tableLayoutPanelCheckBoxGama;
        private Label labelLema;
    }
}