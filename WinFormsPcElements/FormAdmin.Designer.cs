namespace WinFormsPcElements
{
    partial class FormAdmin
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
            panelHeader = new Panel();
            panelFecha = new Panel();
            labelFecha = new Label();
            pictureBoxLogoPc = new PictureBox();
            buttonAltExitMenu = new Button();
            tableLayoutPanelExitMenu = new TableLayoutPanel();
            buttonClose = new Button();
            buttonLogOut = new Button();
            buttonRegresar = new Button();
            panelSideBar = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonVentas = new Button();
            buttonGraficas = new Button();
            buttonBajas = new Button();
            buttonAltas = new Button();
            buttonInventario = new Button();
            buttonMod = new Button();
            panelMain = new Panel();
            tableLayoutPanelHome = new TableLayoutPanel();
            labelLema = new Label();
            pictureBoxPcElements = new PictureBox();
            timerAltExitMenu = new System.Windows.Forms.Timer(components);
            timerHora = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoPc).BeginInit();
            tableLayoutPanelExitMenu.SuspendLayout();
            panelSideBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelMain.SuspendLayout();
            tableLayoutPanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPcElements).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(panelFecha);
            panelHeader.Controls.Add(pictureBoxLogoPc);
            panelHeader.Controls.Add(buttonAltExitMenu);
            panelHeader.Controls.Add(tableLayoutPanelExitMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 58);
            panelHeader.TabIndex = 0;
            // 
            // panelFecha
            // 
            panelFecha.Controls.Add(labelFecha);
            panelFecha.Dock = DockStyle.Fill;
            panelFecha.Location = new Point(58, 0);
            panelFecha.Name = "panelFecha";
            panelFecha.Size = new Size(494, 58);
            panelFecha.TabIndex = 5;
            // 
            // labelFecha
            // 
            labelFecha.Dock = DockStyle.Fill;
            labelFecha.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(0, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(494, 58);
            labelFecha.TabIndex = 0;
            labelFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogoPc
            // 
            pictureBoxLogoPc.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            pictureBoxLogoPc.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLogoPc.Dock = DockStyle.Left;
            pictureBoxLogoPc.Location = new Point(0, 0);
            pictureBoxLogoPc.Name = "pictureBoxLogoPc";
            pictureBoxLogoPc.Size = new Size(58, 58);
            pictureBoxLogoPc.TabIndex = 4;
            pictureBoxLogoPc.TabStop = false;
            // 
            // buttonAltExitMenu
            // 
            buttonAltExitMenu.BackgroundImage = Properties.Resources.Arrow_left_circleDM;
            buttonAltExitMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonAltExitMenu.Cursor = Cursors.Hand;
            buttonAltExitMenu.Dock = DockStyle.Right;
            buttonAltExitMenu.FlatAppearance.BorderSize = 0;
            buttonAltExitMenu.FlatStyle = FlatStyle.Flat;
            buttonAltExitMenu.Location = new Point(552, 0);
            buttonAltExitMenu.Name = "buttonAltExitMenu";
            buttonAltExitMenu.Size = new Size(58, 58);
            buttonAltExitMenu.TabIndex = 1;
            buttonAltExitMenu.UseVisualStyleBackColor = true;
            buttonAltExitMenu.Click += buttonAltExitMenu_Click;
            // 
            // tableLayoutPanelExitMenu
            // 
            tableLayoutPanelExitMenu.ColumnCount = 3;
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelExitMenu.Controls.Add(buttonClose, 2, 0);
            tableLayoutPanelExitMenu.Controls.Add(buttonLogOut, 1, 0);
            tableLayoutPanelExitMenu.Controls.Add(buttonRegresar, 0, 0);
            tableLayoutPanelExitMenu.Dock = DockStyle.Right;
            tableLayoutPanelExitMenu.Location = new Point(610, 0);
            tableLayoutPanelExitMenu.Name = "tableLayoutPanelExitMenu";
            tableLayoutPanelExitMenu.RowCount = 1;
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.Size = new Size(190, 58);
            tableLayoutPanelExitMenu.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.None;
            buttonClose.BackgroundImage = Properties.Resources.closeIcon;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(129, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(58, 52);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Anchor = AnchorStyles.None;
            buttonLogOut.BackColor = Color.Transparent;
            buttonLogOut.BackgroundImage = Properties.Resources.Log_outDM;
            buttonLogOut.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Location = new Point(66, 3);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(57, 52);
            buttonLogOut.TabIndex = 3;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Anchor = AnchorStyles.None;
            buttonRegresar.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegresar.Cursor = Cursors.Hand;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(3, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(57, 52);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(tableLayoutPanel1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 58);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(114, 391);
            panelSideBar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonVentas, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonGraficas, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonBajas, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonAltas, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonInventario, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonMod, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(114, 391);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonVentas
            // 
            buttonVentas.Anchor = AnchorStyles.None;
            buttonVentas.BackColor = Color.Transparent;
            buttonVentas.BackgroundImage = Properties.Resources.Shopping_bagDM;
            buttonVentas.BackgroundImageLayout = ImageLayout.Center;
            buttonVentas.Cursor = Cursors.Hand;
            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatStyle = FlatStyle.Flat;
            buttonVentas.Location = new Point(3, 335);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Size = new Size(108, 46);
            buttonVentas.TabIndex = 10;
            buttonVentas.UseVisualStyleBackColor = false;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // buttonGraficas
            // 
            buttonGraficas.Anchor = AnchorStyles.None;
            buttonGraficas.BackColor = Color.Transparent;
            buttonGraficas.BackgroundImage = Properties.Resources.EstadisticasDM;
            buttonGraficas.BackgroundImageLayout = ImageLayout.Center;
            buttonGraficas.Cursor = Cursors.Hand;
            buttonGraficas.FlatAppearance.BorderSize = 0;
            buttonGraficas.FlatStyle = FlatStyle.Flat;
            buttonGraficas.Location = new Point(3, 269);
            buttonGraficas.Name = "buttonGraficas";
            buttonGraficas.Size = new Size(108, 46);
            buttonGraficas.TabIndex = 8;
            buttonGraficas.UseVisualStyleBackColor = false;
            buttonGraficas.Click += buttonGraficas_Click;
            // 
            // buttonBajas
            // 
            buttonBajas.Anchor = AnchorStyles.None;
            buttonBajas.BackColor = Color.Transparent;
            buttonBajas.BackgroundImage = Properties.Resources.deleteDM;
            buttonBajas.BackgroundImageLayout = ImageLayout.Center;
            buttonBajas.Cursor = Cursors.Hand;
            buttonBajas.FlatAppearance.BorderSize = 0;
            buttonBajas.FlatStyle = FlatStyle.Flat;
            buttonBajas.Location = new Point(3, 198);
            buttonBajas.Name = "buttonBajas";
            buttonBajas.Size = new Size(108, 59);
            buttonBajas.TabIndex = 6;
            buttonBajas.UseVisualStyleBackColor = false;
            buttonBajas.Click += buttonBajas_Click;
            // 
            // buttonAltas
            // 
            buttonAltas.Anchor = AnchorStyles.None;
            buttonAltas.BackColor = Color.Transparent;
            buttonAltas.BackgroundImage = Properties.Resources.add_circleDM;
            buttonAltas.BackgroundImageLayout = ImageLayout.Center;
            buttonAltas.Cursor = Cursors.Hand;
            buttonAltas.FlatAppearance.BorderSize = 0;
            buttonAltas.FlatStyle = FlatStyle.Flat;
            buttonAltas.Location = new Point(3, 74);
            buttonAltas.Name = "buttonAltas";
            buttonAltas.Size = new Size(108, 46);
            buttonAltas.TabIndex = 2;
            buttonAltas.UseVisualStyleBackColor = false;
            buttonAltas.Click += buttonAltas_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.Anchor = AnchorStyles.None;
            buttonInventario.BackColor = Color.Transparent;
            buttonInventario.BackgroundImage = Properties.Resources.ClipboardDM;
            buttonInventario.BackgroundImageLayout = ImageLayout.Center;
            buttonInventario.Cursor = Cursors.Hand;
            buttonInventario.FlatAppearance.BorderSize = 0;
            buttonInventario.FlatStyle = FlatStyle.Flat;
            buttonInventario.Location = new Point(3, 9);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(108, 46);
            buttonInventario.TabIndex = 0;
            buttonInventario.UseVisualStyleBackColor = false;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonMod
            // 
            buttonMod.Anchor = AnchorStyles.None;
            buttonMod.BackColor = Color.Transparent;
            buttonMod.BackgroundImage = Properties.Resources.EditDM;
            buttonMod.BackgroundImageLayout = ImageLayout.Center;
            buttonMod.Cursor = Cursors.Hand;
            buttonMod.FlatAppearance.BorderSize = 0;
            buttonMod.FlatStyle = FlatStyle.Flat;
            buttonMod.Location = new Point(3, 139);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(108, 46);
            buttonMod.TabIndex = 4;
            buttonMod.UseVisualStyleBackColor = false;
            buttonMod.Click += buttonMod_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tableLayoutPanelHome);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(114, 58);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(686, 391);
            panelMain.TabIndex = 2;
            // 
            // tableLayoutPanelHome
            // 
            tableLayoutPanelHome.BackColor = Color.Transparent;
            tableLayoutPanelHome.ColumnCount = 1;
            tableLayoutPanelHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelHome.Controls.Add(labelLema, 0, 1);
            tableLayoutPanelHome.Controls.Add(pictureBoxPcElements, 0, 0);
            tableLayoutPanelHome.Dock = DockStyle.Fill;
            tableLayoutPanelHome.Location = new Point(0, 0);
            tableLayoutPanelHome.Name = "tableLayoutPanelHome";
            tableLayoutPanelHome.RowCount = 3;
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 72.1227646F));
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tableLayoutPanelHome.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4859333F));
            tableLayoutPanelHome.Size = new Size(686, 391);
            tableLayoutPanelHome.TabIndex = 1;
            // 
            // labelLema
            // 
            labelLema.BackColor = Color.Transparent;
            labelLema.Dock = DockStyle.Top;
            labelLema.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLema.ForeColor = Color.White;
            labelLema.Location = new Point(3, 282);
            labelLema.Name = "labelLema";
            labelLema.Size = new Size(680, 65);
            labelLema.TabIndex = 2;
            labelLema.Text = "Powered Computational Enviroment";
            labelLema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPcElements
            // 
            pictureBoxPcElements.Anchor = AnchorStyles.None;
            pictureBoxPcElements.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            pictureBoxPcElements.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPcElements.Location = new Point(218, 16);
            pictureBoxPcElements.Name = "pictureBoxPcElements";
            pictureBoxPcElements.Size = new Size(250, 250);
            pictureBoxPcElements.TabIndex = 0;
            pictureBoxPcElements.TabStop = false;
            // 
            // timerAltExitMenu
            // 
            timerAltExitMenu.Enabled = true;
            timerAltExitMenu.Interval = 20;
            timerAltExitMenu.Tick += timerAltExitMenu_Tick;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(panelMain);
            Controls.Add(panelSideBar);
            Controls.Add(panelHeader);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            panelHeader.ResumeLayout(false);
            panelFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoPc).EndInit();
            tableLayoutPanelExitMenu.ResumeLayout(false);
            panelSideBar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            tableLayoutPanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPcElements).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelSideBar;
        private Panel panelMain;
        private TableLayoutPanel tableLayoutPanelExitMenu;
        private Button buttonClose;
        private Button buttonRegresar;
        private Button buttonAltExitMenu;
        private PictureBox pictureBoxLogoPc;
        private Button buttonInventario;
        private Button buttonGraficas;
        private Button buttonBajas;
        private Button buttonMod;
        private Button buttonAltas;
        private Button buttonLogOut;
        private Button buttonVentas;
        private System.Windows.Forms.Timer timerAltExitMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFecha;
        private Label labelFecha;
        private System.Windows.Forms.Timer timerHora;
        private TableLayoutPanel tableLayoutPanelHome;
        private Label labelLema;
        private PictureBox pictureBoxPcElements;
    }
}