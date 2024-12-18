namespace WinFormsPcElements
{
    partial class FormIntegrantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntegrantes));
            panelHeader = new Panel();
            buttonAltExitMenu = new Button();
            tableLayoutPanelExitMenu = new TableLayoutPanel();
            buttonSalir = new Button();
            buttonAtras = new Button();
            panelCentral = new Panel();
            tableLayoutPanelInfo = new TableLayoutPanel();
            labelInfo = new Label();
            pictureBoxFamilia = new PictureBox();
            tableLayoutPanelIntegrantes = new TableLayoutPanel();
            labelHarimInfo = new Label();
            labelSantosInfo = new Label();
            pictureBoxErick = new PictureBox();
            pictureBoxSantos = new PictureBox();
            pictureBoxHarim = new PictureBox();
            labelErickInfo = new Label();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            timerExitMenu = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            tableLayoutPanelExitMenu.SuspendLayout();
            panelCentral.SuspendLayout();
            tableLayoutPanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFamilia).BeginInit();
            tableLayoutPanelIntegrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSantos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHarim).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(61, 104, 104);
            panelHeader.Controls.Add(buttonAltExitMenu);
            panelHeader.Controls.Add(tableLayoutPanelExitMenu);
            panelHeader.Controls.Add(buttonAtras);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(802, 64);
            panelHeader.TabIndex = 0;
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
            buttonAltExitMenu.Location = new Point(688, 0);
            buttonAltExitMenu.Name = "buttonAltExitMenu";
            buttonAltExitMenu.Size = new Size(55, 64);
            buttonAltExitMenu.TabIndex = 12;
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
            tableLayoutPanelExitMenu.Location = new Point(743, 0);
            tableLayoutPanelExitMenu.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelExitMenu.Name = "tableLayoutPanelExitMenu";
            tableLayoutPanelExitMenu.RowCount = 1;
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.Size = new Size(59, 64);
            tableLayoutPanelExitMenu.TabIndex = 11;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.None;
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources.closeIcon;
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(7, 9);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(45, 46);
            buttonSalir.TabIndex = 4;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonAtras
            // 
            buttonAtras.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonAtras.BackgroundImageLayout = ImageLayout.Center;
            buttonAtras.Dock = DockStyle.Left;
            buttonAtras.FlatAppearance.BorderSize = 0;
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Location = new Point(0, 0);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(68, 64);
            buttonAtras.TabIndex = 0;
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.Transparent;
            panelCentral.BackgroundImageLayout = ImageLayout.Stretch;
            panelCentral.Controls.Add(tableLayoutPanelInfo);
            panelCentral.Controls.Add(tableLayoutPanelIntegrantes);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 64);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(802, 394);
            panelCentral.TabIndex = 1;
            // 
            // tableLayoutPanelInfo
            // 
            tableLayoutPanelInfo.BackColor = Color.FromArgb(100, 167, 198, 134);
            tableLayoutPanelInfo.ColumnCount = 1;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.Controls.Add(labelInfo, 0, 0);
            tableLayoutPanelInfo.Controls.Add(pictureBoxFamilia, 0, 1);
            tableLayoutPanelInfo.Dock = DockStyle.Fill;
            tableLayoutPanelInfo.Location = new Point(579, 0);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 2;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.Size = new Size(223, 394);
            tableLayoutPanelInfo.TabIndex = 1;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.None;
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(32, 51);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(159, 95);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Programación II\r\n\r\nGeorgina Salazar Partida\r\n\r\n17 / Diciembre / 2024";
            labelInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFamilia
            // 
            pictureBoxFamilia.Anchor = AnchorStyles.None;
            pictureBoxFamilia.BackgroundImage = Properties.Resources.fotoFamilia;
            pictureBoxFamilia.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxFamilia.Location = new Point(11, 222);
            pictureBoxFamilia.Name = "pictureBoxFamilia";
            pictureBoxFamilia.Size = new Size(200, 147);
            pictureBoxFamilia.TabIndex = 1;
            pictureBoxFamilia.TabStop = false;
            // 
            // tableLayoutPanelIntegrantes
            // 
            tableLayoutPanelIntegrantes.BackColor = Color.Transparent;
            tableLayoutPanelIntegrantes.ColumnCount = 3;
            tableLayoutPanelIntegrantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelIntegrantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelIntegrantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelIntegrantes.Controls.Add(labelHarimInfo, 2, 1);
            tableLayoutPanelIntegrantes.Controls.Add(labelSantosInfo, 1, 1);
            tableLayoutPanelIntegrantes.Controls.Add(pictureBoxErick, 0, 0);
            tableLayoutPanelIntegrantes.Controls.Add(pictureBoxSantos, 1, 0);
            tableLayoutPanelIntegrantes.Controls.Add(pictureBoxHarim, 2, 0);
            tableLayoutPanelIntegrantes.Controls.Add(labelErickInfo, 0, 1);
            tableLayoutPanelIntegrantes.Dock = DockStyle.Left;
            tableLayoutPanelIntegrantes.Location = new Point(0, 0);
            tableLayoutPanelIntegrantes.Name = "tableLayoutPanelIntegrantes";
            tableLayoutPanelIntegrantes.RowCount = 2;
            tableLayoutPanelIntegrantes.RowStyles.Add(new RowStyle(SizeType.Percent, 34.74F));
            tableLayoutPanelIntegrantes.RowStyles.Add(new RowStyle(SizeType.Percent, 65.26F));
            tableLayoutPanelIntegrantes.Size = new Size(579, 394);
            tableLayoutPanelIntegrantes.TabIndex = 0;
            // 
            // labelHarimInfo
            // 
            labelHarimInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHarimInfo.AutoSize = true;
            labelHarimInfo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHarimInfo.ForeColor = Color.White;
            labelHarimInfo.Location = new Point(389, 136);
            labelHarimInfo.Name = "labelHarimInfo";
            labelHarimInfo.Padding = new Padding(10);
            labelHarimInfo.Size = new Size(187, 215);
            labelHarimInfo.TabIndex = 5;
            labelHarimInfo.Text = resources.GetString("labelHarimInfo.Text");
            labelHarimInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSantosInfo
            // 
            labelSantosInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSantosInfo.AutoSize = true;
            labelSantosInfo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSantosInfo.ForeColor = Color.White;
            labelSantosInfo.Location = new Point(196, 136);
            labelSantosInfo.Name = "labelSantosInfo";
            labelSantosInfo.Padding = new Padding(10);
            labelSantosInfo.Size = new Size(187, 230);
            labelSantosInfo.TabIndex = 4;
            labelSantosInfo.Text = resources.GetString("labelSantosInfo.Text");
            labelSantosInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxErick
            // 
            pictureBoxErick.Anchor = AnchorStyles.None;
            pictureBoxErick.BackgroundImage = Properties.Resources.fotoErick;
            pictureBoxErick.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxErick.Location = new Point(32, 21);
            pictureBoxErick.Name = "pictureBoxErick";
            pictureBoxErick.Size = new Size(128, 93);
            pictureBoxErick.TabIndex = 0;
            pictureBoxErick.TabStop = false;
            // 
            // pictureBoxSantos
            // 
            pictureBoxSantos.Anchor = AnchorStyles.None;
            pictureBoxSantos.BackgroundImage = Properties.Resources.fotoSantos;
            pictureBoxSantos.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxSantos.Location = new Point(225, 21);
            pictureBoxSantos.Name = "pictureBoxSantos";
            pictureBoxSantos.Size = new Size(128, 93);
            pictureBoxSantos.TabIndex = 1;
            pictureBoxSantos.TabStop = false;
            // 
            // pictureBoxHarim
            // 
            pictureBoxHarim.Anchor = AnchorStyles.None;
            pictureBoxHarim.BackgroundImage = Properties.Resources.fotoHarim;
            pictureBoxHarim.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHarim.Location = new Point(418, 21);
            pictureBoxHarim.Name = "pictureBoxHarim";
            pictureBoxHarim.Size = new Size(128, 93);
            pictureBoxHarim.TabIndex = 2;
            pictureBoxHarim.TabStop = false;
            // 
            // labelErickInfo
            // 
            labelErickInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelErickInfo.AutoSize = true;
            labelErickInfo.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErickInfo.ForeColor = Color.White;
            labelErickInfo.Location = new Point(3, 136);
            labelErickInfo.Name = "labelErickInfo";
            labelErickInfo.Padding = new Padding(10);
            labelErickInfo.Size = new Size(187, 185);
            labelErickInfo.TabIndex = 3;
            labelErickInfo.Text = resources.GetString("labelErickInfo.Text");
            labelErickInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // timerExitMenu
            // 
            timerExitMenu.Tick += timerExitMenu_Tick;
            // 
            // FormIntegrantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 458);
            Controls.Add(panelCentral);
            Controls.Add(panelHeader);
            Name = "FormIntegrantes";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIntegrantes";
            Load += FormIntegrantes_Load;
            panelHeader.ResumeLayout(false);
            tableLayoutPanelExitMenu.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            tableLayoutPanelInfo.ResumeLayout(false);
            tableLayoutPanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFamilia).EndInit();
            tableLayoutPanelIntegrantes.ResumeLayout(false);
            tableLayoutPanelIntegrantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErick).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSantos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHarim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonAtras;
        private Panel panelCentral;
        private TableLayoutPanel tableLayoutPanelInfo;
        private TableLayoutPanel tableLayoutPanelIntegrantes;
        private PictureBox pictureBoxErick;
        private PictureBox pictureBoxSantos;
        private PictureBox pictureBoxHarim;
        private Label labelHarimInfo;
        private Label labelSantosInfo;
        private Label labelErickInfo;
        private Label labelInfo;
        private PictureBox pictureBoxFamilia;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Timer timerExitMenu;
        private Button buttonAltExitMenu;
        private TableLayoutPanel tableLayoutPanelExitMenu;
        private Button buttonSalir;
    }
}