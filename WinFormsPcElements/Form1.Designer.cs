namespace WinFormsPcElements
{
    partial class FormPortada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            flowLayoutPanelUaa = new FlowLayoutPanel();
            pictureBoxUaaLogo = new PictureBox();
            labelLemaUaa = new Label();
            buttonAltExitMenu = new Button();
            tableLayoutPanelExitMenu = new TableLayoutPanel();
            buttonMinimize = new Button();
            buttonClose = new Button();
            panelCentral = new Panel();
            panelOptionsMenu = new Panel();
            tableLayoutPanelOptionsMenu = new TableLayoutPanel();
            buttonHelp = new Button();
            buttonAltTheme = new Button();
            tableLayoutPanelMain = new TableLayoutPanel();
            buttonLogoPc = new Button();
            tableLayoutPanelInfo = new TableLayoutPanel();
            labelTitulo = new Label();
            tableLayoutPanelButtons = new TableLayoutPanel();
            buttonTeamLogo = new Button();
            buttonIniciar = new Button();
            buttonTwitter = new Button();
            buttonYoutube = new Button();
            buttonInstagram = new Button();
            panelFooter = new Panel();
            buttonAltOptionsMenu = new Button();
            labelHora = new Label();
            timerExitMenu = new System.Windows.Forms.Timer(components);
            timerHora = new System.Windows.Forms.Timer(components);
            timerOptionsMenu = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            flowLayoutPanelUaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUaaLogo).BeginInit();
            tableLayoutPanelExitMenu.SuspendLayout();
            panelCentral.SuspendLayout();
            panelOptionsMenu.SuspendLayout();
            tableLayoutPanelOptionsMenu.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelInfo.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(21, 68, 103);
            panelHeader.Controls.Add(flowLayoutPanelUaa);
            panelHeader.Controls.Add(buttonAltExitMenu);
            panelHeader.Controls.Add(tableLayoutPanelExitMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(820, 73);
            panelHeader.TabIndex = 0;
            // 
            // flowLayoutPanelUaa
            // 
            flowLayoutPanelUaa.Controls.Add(pictureBoxUaaLogo);
            flowLayoutPanelUaa.Controls.Add(labelLemaUaa);
            flowLayoutPanelUaa.Dock = DockStyle.Left;
            flowLayoutPanelUaa.Location = new Point(0, 0);
            flowLayoutPanelUaa.Name = "flowLayoutPanelUaa";
            flowLayoutPanelUaa.Size = new Size(477, 73);
            flowLayoutPanelUaa.TabIndex = 0;
            // 
            // pictureBoxUaaLogo
            // 
            pictureBoxUaaLogo.BackColor = Color.Transparent;
            pictureBoxUaaLogo.BackgroundImage = Properties.Resources.uaaLogo;
            pictureBoxUaaLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxUaaLogo.Cursor = Cursors.Help;
            pictureBoxUaaLogo.Location = new Point(3, 3);
            pictureBoxUaaLogo.Name = "pictureBoxUaaLogo";
            pictureBoxUaaLogo.Size = new Size(67, 67);
            pictureBoxUaaLogo.TabIndex = 0;
            pictureBoxUaaLogo.TabStop = false;
            pictureBoxUaaLogo.MouseLeave += pictureBoxUaaLogo_MouseLeave;
            pictureBoxUaaLogo.MouseHover += pictureBoxUaaLogo_MouseHover;
            // 
            // labelLemaUaa
            // 
            labelLemaUaa.Anchor = AnchorStyles.None;
            labelLemaUaa.AutoSize = true;
            labelLemaUaa.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLemaUaa.ForeColor = Color.White;
            labelLemaUaa.Location = new Point(76, 15);
            labelLemaUaa.Name = "labelLemaUaa";
            labelLemaUaa.Size = new Size(329, 42);
            labelLemaUaa.TabIndex = 1;
            labelLemaUaa.Text = "Universidad Autónoma de Aguascalientes\r\n\"Se Lumen Proferre\"";
            labelLemaUaa.TextAlign = ContentAlignment.MiddleCenter;
            labelLemaUaa.Visible = false;
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
            buttonAltExitMenu.Location = new Point(690, 0);
            buttonAltExitMenu.Name = "buttonAltExitMenu";
            buttonAltExitMenu.Size = new Size(55, 73);
            buttonAltExitMenu.TabIndex = 2;
            buttonAltExitMenu.UseVisualStyleBackColor = true;
            buttonAltExitMenu.Click += buttonAltExitMenu_Click;
            // 
            // tableLayoutPanelExitMenu
            // 
            tableLayoutPanelExitMenu.ColumnCount = 2;
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelExitMenu.Controls.Add(buttonMinimize, 0, 0);
            tableLayoutPanelExitMenu.Controls.Add(buttonClose, 1, 0);
            tableLayoutPanelExitMenu.Dock = DockStyle.Right;
            tableLayoutPanelExitMenu.Location = new Point(745, 0);
            tableLayoutPanelExitMenu.Name = "tableLayoutPanelExitMenu";
            tableLayoutPanelExitMenu.RowCount = 1;
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelExitMenu.Size = new Size(75, 73);
            tableLayoutPanelExitMenu.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.None;
            buttonMinimize.BackColor = Color.Transparent;
            buttonMinimize.BackgroundImage = Properties.Resources.minimizeIcon;
            buttonMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Location = new Point(3, 16);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(31, 40);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.None;
            buttonClose.BackColor = Color.Transparent;
            buttonClose.BackgroundImage = Properties.Resources.closeIcon;
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(40, 16);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(31, 40);
            buttonClose.TabIndex = 1;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(17, 26, 39);
            panelCentral.BackgroundImageLayout = ImageLayout.Stretch;
            panelCentral.Controls.Add(panelOptionsMenu);
            panelCentral.Controls.Add(tableLayoutPanelMain);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 73);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(0, 0, 0, 12);
            panelCentral.Size = new Size(820, 310);
            panelCentral.TabIndex = 1;
            // 
            // panelOptionsMenu
            // 
            panelOptionsMenu.Anchor = AnchorStyles.None;
            panelOptionsMenu.BackColor = Color.FromArgb(36, 104, 84);
            panelOptionsMenu.Controls.Add(tableLayoutPanelOptionsMenu);
            panelOptionsMenu.Location = new Point(0, 185);
            panelOptionsMenu.Name = "panelOptionsMenu";
            panelOptionsMenu.Size = new Size(133, 125);
            panelOptionsMenu.TabIndex = 1;
            // 
            // tableLayoutPanelOptionsMenu
            // 
            tableLayoutPanelOptionsMenu.ColumnCount = 1;
            tableLayoutPanelOptionsMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelOptionsMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelOptionsMenu.Controls.Add(buttonHelp, 0, 1);
            tableLayoutPanelOptionsMenu.Controls.Add(buttonAltTheme, 0, 0);
            tableLayoutPanelOptionsMenu.Dock = DockStyle.Fill;
            tableLayoutPanelOptionsMenu.Location = new Point(0, 0);
            tableLayoutPanelOptionsMenu.Name = "tableLayoutPanelOptionsMenu";
            tableLayoutPanelOptionsMenu.Padding = new Padding(5);
            tableLayoutPanelOptionsMenu.RowCount = 2;
            tableLayoutPanelOptionsMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOptionsMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelOptionsMenu.Size = new Size(133, 125);
            tableLayoutPanelOptionsMenu.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(15, 46, 34);
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Dock = DockStyle.Fill;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.ForeColor = Color.FromArgb(184, 255, 225);
            buttonHelp.Image = Properties.Resources.Help_circleDM;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(8, 65);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(117, 52);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Help";
            buttonHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonAltTheme
            // 
            buttonAltTheme.BackColor = Color.FromArgb(15, 46, 34);
            buttonAltTheme.Cursor = Cursors.Hand;
            buttonAltTheme.Dock = DockStyle.Fill;
            buttonAltTheme.FlatAppearance.BorderSize = 0;
            buttonAltTheme.FlatStyle = FlatStyle.Flat;
            buttonAltTheme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAltTheme.ForeColor = Color.FromArgb(184, 255, 225);
            buttonAltTheme.Image = Properties.Resources.Moon;
            buttonAltTheme.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAltTheme.Location = new Point(8, 8);
            buttonAltTheme.Name = "buttonAltTheme";
            buttonAltTheme.Size = new Size(117, 51);
            buttonAltTheme.TabIndex = 0;
            buttonAltTheme.Text = "Oscuro";
            buttonAltTheme.TextAlign = ContentAlignment.MiddleLeft;
            buttonAltTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAltTheme.UseVisualStyleBackColor = false;
            buttonAltTheme.Click += buttonAltTheme_Click;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(buttonLogoPc, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInfo, 0, 1);
            tableLayoutPanelMain.Location = new Point(200, 6);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(449, 286);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonLogoPc
            // 
            buttonLogoPc.Anchor = AnchorStyles.None;
            buttonLogoPc.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            buttonLogoPc.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogoPc.Cursor = Cursors.Hand;
            buttonLogoPc.FlatAppearance.BorderSize = 0;
            buttonLogoPc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogoPc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogoPc.FlatStyle = FlatStyle.Flat;
            buttonLogoPc.ForeColor = Color.Transparent;
            buttonLogoPc.Location = new Point(145, 15);
            buttonLogoPc.Name = "buttonLogoPc";
            buttonLogoPc.Size = new Size(158, 112);
            buttonLogoPc.TabIndex = 0;
            buttonLogoPc.UseVisualStyleBackColor = true;
            buttonLogoPc.Click += buttonLogoPc_Click;
            // 
            // tableLayoutPanelInfo
            // 
            tableLayoutPanelInfo.BackColor = Color.Transparent;
            tableLayoutPanelInfo.BackgroundImage = Properties.Resources.BackgroundInfoDM;
            tableLayoutPanelInfo.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanelInfo.ColumnCount = 1;
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.Controls.Add(labelTitulo, 0, 0);
            tableLayoutPanelInfo.Controls.Add(tableLayoutPanelButtons, 0, 1);
            tableLayoutPanelInfo.Dock = DockStyle.Fill;
            tableLayoutPanelInfo.Location = new Point(3, 146);
            tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            tableLayoutPanelInfo.RowCount = 2;
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelInfo.Size = new Size(443, 137);
            tableLayoutPanelInfo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Dock = DockStyle.Fill;
            labelTitulo.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(184, 255, 225);
            labelTitulo.Location = new Point(3, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(437, 68);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Powered Computational Enviroment\r\nPC MARKETPLACE";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.AutoSize = true;
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelButtons.Controls.Add(buttonTeamLogo, 0, 0);
            tableLayoutPanelButtons.Controls.Add(buttonIniciar, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(0, 68);
            tableLayoutPanelButtons.Margin = new Padding(0);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.Padding = new Padding(10);
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(443, 69);
            tableLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonTeamLogo
            // 
            buttonTeamLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonTeamLogo.BackColor = Color.Transparent;
            buttonTeamLogo.BackgroundImage = Properties.Resources.circleTeamLogoDM;
            buttonTeamLogo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTeamLogo.Cursor = Cursors.Hand;
            buttonTeamLogo.FlatAppearance.BorderSize = 0;
            buttonTeamLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTeamLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTeamLogo.FlatStyle = FlatStyle.Flat;
            buttonTeamLogo.Location = new Point(49, 10);
            buttonTeamLogo.Margin = new Padding(0);
            buttonTeamLogo.Name = "buttonTeamLogo";
            buttonTeamLogo.Size = new Size(69, 49);
            buttonTeamLogo.TabIndex = 1;
            buttonTeamLogo.UseVisualStyleBackColor = false;
            buttonTeamLogo.Click += buttonTeamLogo_Click;
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIniciar.Cursor = Cursors.Hand;
            buttonIniciar.Dock = DockStyle.Fill;
            buttonIniciar.FlatAppearance.BorderSize = 0;
            buttonIniciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIniciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIniciar.FlatStyle = FlatStyle.Flat;
            buttonIniciar.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIniciar.Location = new Point(173, 16);
            buttonIniciar.Margin = new Padding(15, 6, 30, 6);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(230, 37);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "INICIAR";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // buttonTwitter
            // 
            buttonTwitter.BackColor = Color.Transparent;
            buttonTwitter.BackgroundImage = Properties.Resources.TwitterDM;
            buttonTwitter.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTwitter.Cursor = Cursors.Hand;
            buttonTwitter.Dock = DockStyle.Right;
            buttonTwitter.FlatAppearance.BorderSize = 0;
            buttonTwitter.FlatStyle = FlatStyle.Flat;
            buttonTwitter.Location = new Point(671, 0);
            buttonTwitter.Name = "buttonTwitter";
            buttonTwitter.Size = new Size(48, 66);
            buttonTwitter.TabIndex = 2;
            buttonTwitter.UseVisualStyleBackColor = false;
            buttonTwitter.Click += buttonTwitter_Click;
            // 
            // buttonYoutube
            // 
            buttonYoutube.BackColor = Color.Transparent;
            buttonYoutube.BackgroundImage = Properties.Resources.YoutubeDM;
            buttonYoutube.BackgroundImageLayout = ImageLayout.Zoom;
            buttonYoutube.Cursor = Cursors.Hand;
            buttonYoutube.Dock = DockStyle.Right;
            buttonYoutube.FlatAppearance.BorderSize = 0;
            buttonYoutube.FlatStyle = FlatStyle.Flat;
            buttonYoutube.Location = new Point(719, 0);
            buttonYoutube.Name = "buttonYoutube";
            buttonYoutube.Size = new Size(51, 66);
            buttonYoutube.TabIndex = 1;
            buttonYoutube.UseVisualStyleBackColor = false;
            buttonYoutube.Click += buttonYoutube_Click;
            // 
            // buttonInstagram
            // 
            buttonInstagram.BackColor = Color.Transparent;
            buttonInstagram.BackgroundImage = Properties.Resources.InstagramDM;
            buttonInstagram.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInstagram.Cursor = Cursors.Hand;
            buttonInstagram.Dock = DockStyle.Right;
            buttonInstagram.FlatAppearance.BorderSize = 0;
            buttonInstagram.FlatStyle = FlatStyle.Flat;
            buttonInstagram.Location = new Point(770, 0);
            buttonInstagram.Margin = new Padding(2, 3, 3, 3);
            buttonInstagram.Name = "buttonInstagram";
            buttonInstagram.Size = new Size(50, 66);
            buttonInstagram.TabIndex = 0;
            buttonInstagram.UseVisualStyleBackColor = false;
            buttonInstagram.Click += buttonInstagram_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(21, 68, 103);
            panelFooter.Controls.Add(buttonAltOptionsMenu);
            panelFooter.Controls.Add(buttonTwitter);
            panelFooter.Controls.Add(buttonYoutube);
            panelFooter.Controls.Add(labelHora);
            panelFooter.Controls.Add(buttonInstagram);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 383);
            panelFooter.Margin = new Padding(3, 9, 3, 3);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(820, 66);
            panelFooter.TabIndex = 2;
            // 
            // buttonAltOptionsMenu
            // 
            buttonAltOptionsMenu.BackgroundImage = Properties.Resources.settingsDM;
            buttonAltOptionsMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonAltOptionsMenu.Cursor = Cursors.Hand;
            buttonAltOptionsMenu.Dock = DockStyle.Left;
            buttonAltOptionsMenu.FlatAppearance.BorderSize = 0;
            buttonAltOptionsMenu.FlatStyle = FlatStyle.Flat;
            buttonAltOptionsMenu.Location = new Point(0, 0);
            buttonAltOptionsMenu.Name = "buttonAltOptionsMenu";
            buttonAltOptionsMenu.Size = new Size(133, 66);
            buttonAltOptionsMenu.TabIndex = 3;
            buttonAltOptionsMenu.UseVisualStyleBackColor = true;
            buttonAltOptionsMenu.Click += buttonAltOptionsMenu_Click;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Lucida Fax", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.FromArgb(184, 255, 225);
            labelHora.Location = new Point(378, 13);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(105, 36);
            labelHora.TabIndex = 0;
            labelHora.Text = "00:00";
            labelHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerExitMenu
            // 
            timerExitMenu.Enabled = true;
            timerExitMenu.Interval = 3;
            timerExitMenu.Tick += timerExitMenu_Tick;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // timerOptionsMenu
            // 
            timerOptionsMenu.Enabled = true;
            timerOptionsMenu.Interval = 3;
            timerOptionsMenu.Tick += timerOptionsMenu_Tick;
            // 
            // FormPortada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 449);
            Controls.Add(panelCentral);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Name = "FormPortada";
            Text = "Portada";
            Load += FormPortada_Load;
            panelHeader.ResumeLayout(false);
            flowLayoutPanelUaa.ResumeLayout(false);
            flowLayoutPanelUaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUaaLogo).EndInit();
            tableLayoutPanelExitMenu.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            panelOptionsMenu.ResumeLayout(false);
            tableLayoutPanelOptionsMenu.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelInfo.ResumeLayout(false);
            tableLayoutPanelInfo.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private FlowLayoutPanel flowLayoutPanelUaa;
        private PictureBox pictureBoxUaaLogo;
        private Label labelLemaUaa;
        private Panel panelCentral;
        private Panel panelFooter;
        private Button buttonAltExitMenu;
        private TableLayoutPanel tableLayoutPanelExitMenu;
        private Button buttonMinimize;
        private Button buttonClose;
        private TableLayoutPanel tableLayoutPanelMain;
        private Label labelHora;
        private Button buttonLogoPc;
        private TableLayoutPanel tableLayoutPanelInfo;
        private Button buttonIniciar;
        private Button buttonTeamLogo;
        private Label labelTitulo;
        private Button buttonInstagram;
        private Button buttonYoutube;
        private Button buttonTwitter;
        private System.Windows.Forms.Timer timerExitMenu;
        private System.Windows.Forms.Timer timerHora;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button buttonAltOptionsMenu;
        private System.Windows.Forms.Timer timerOptionsMenu;
        private Panel panelOptionsMenu;
        private TableLayoutPanel tableLayoutPanelOptionsMenu;
        private Button buttonHelp;
        private Button buttonAltTheme;
    }
}
