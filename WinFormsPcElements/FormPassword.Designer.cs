namespace WinFormsPcElements
{
    partial class FormPassword
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
            buttonRegresar = new Button();
            panelCentral = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTeamLogo = new Panel();
            buttonSalir = new Button();
            buttonContinue = new Button();
            labelBy = new Label();
            pictureBoxLogoTeam = new PictureBox();
            panelPassword = new Panel();
            buttonShowPassword = new Button();
            textBoxPassword = new TextBox();
            labelUser = new Label();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelCentral.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTeamLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoTeam).BeginInit();
            panelPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(36, 104, 84);
            panelHeader.Controls.Add(buttonRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(808, 47);
            panelHeader.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegresar.Cursor = Cursors.Hand;
            buttonRegresar.Dock = DockStyle.Left;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(0, 0);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(82, 47);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(15, 46, 34);
            panelCentral.Controls.Add(tableLayoutPanel1);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 47);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(808, 420);
            panelCentral.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(panelTeamLogo, 1, 0);
            tableLayoutPanel1.Controls.Add(panelPassword, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(808, 420);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTeamLogo
            // 
            panelTeamLogo.Controls.Add(buttonSalir);
            panelTeamLogo.Controls.Add(buttonContinue);
            panelTeamLogo.Controls.Add(labelBy);
            panelTeamLogo.Controls.Add(pictureBoxLogoTeam);
            panelTeamLogo.Dock = DockStyle.Fill;
            panelTeamLogo.Location = new Point(528, 3);
            panelTeamLogo.Name = "panelTeamLogo";
            panelTeamLogo.Size = new Size(277, 414);
            panelTeamLogo.TabIndex = 1;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources.closeIcon;
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(225, 4);
            buttonSalir.Margin = new Padding(3, 4, 3, 4);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(51, 41);
            buttonSalir.TabIndex = 3;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.Transparent;
            buttonContinue.BackgroundImageLayout = ImageLayout.Stretch;
            buttonContinue.FlatAppearance.BorderSize = 0;
            buttonContinue.FlatStyle = FlatStyle.Flat;
            buttonContinue.ForeColor = Color.FromArgb(187, 255, 225);
            buttonContinue.Location = new Point(147, 349);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(113, 43);
            buttonContinue.TabIndex = 2;
            buttonContinue.Text = "Continuar";
            buttonContinue.UseVisualStyleBackColor = false;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // labelBy
            // 
            labelBy.AutoSize = true;
            labelBy.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelBy.ForeColor = Color.White;
            labelBy.Location = new Point(125, 37);
            labelBy.Name = "labelBy";
            labelBy.Size = new Size(53, 37);
            labelBy.TabIndex = 1;
            labelBy.Text = "By";
            // 
            // pictureBoxLogoTeam
            // 
            pictureBoxLogoTeam.Anchor = AnchorStyles.None;
            pictureBoxLogoTeam.BackgroundImage = Properties.Resources.circleTeamLogoDM;
            pictureBoxLogoTeam.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogoTeam.Location = new Point(26, 93);
            pictureBoxLogoTeam.Name = "pictureBoxLogoTeam";
            pictureBoxLogoTeam.Size = new Size(246, 189);
            pictureBoxLogoTeam.TabIndex = 0;
            pictureBoxLogoTeam.TabStop = false;
            // 
            // panelPassword
            // 
            panelPassword.Anchor = AnchorStyles.Left;
            panelPassword.BackgroundImage = Properties.Resources.rectangleDM;
            panelPassword.BackgroundImageLayout = ImageLayout.Stretch;
            panelPassword.Controls.Add(buttonShowPassword);
            panelPassword.Controls.Add(textBoxPassword);
            panelPassword.Controls.Add(labelUser);
            panelPassword.Location = new Point(21, 138);
            panelPassword.Margin = new Padding(21, 3, 3, 3);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(487, 144);
            panelPassword.TabIndex = 2;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.BackColor = Color.Transparent;
            buttonShowPassword.BackgroundImage = Properties.Resources.Eye_offDM;
            buttonShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonShowPassword.FlatAppearance.BorderSize = 0;
            buttonShowPassword.FlatStyle = FlatStyle.Flat;
            buttonShowPassword.Location = new Point(424, 64);
            buttonShowPassword.Margin = new Padding(3, 4, 3, 4);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(46, 53);
            buttonShowPassword.TabIndex = 2;
            buttonShowPassword.UseVisualStyleBackColor = false;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(42, 126, 104);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(21, 61);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(386, 54);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.FromArgb(31, 216, 164);
            labelUser.Location = new Point(21, 11);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(315, 33);
            labelUser.TabIndex = 0;
            labelUser.Text = "Ingresa la contraseña:";
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // FormPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 467);
            Controls.Add(panelCentral);
            Controls.Add(panelHeader);
            Name = "FormPassword";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPassword";
            Load += FormPassword_Load;
            panelHeader.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelTeamLogo.ResumeLayout(false);
            panelTeamLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoTeam).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelCentral;
        private Button buttonRegresar;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxLogoTeam;
        private Panel panelTeamLogo;
        private Label labelBy;
        private Panel panelPassword;
        private Label labelUser;
        private TextBox textBoxPassword;
        private System.Windows.Forms.Timer timerAnimacion;
        private Button buttonContinue;
        private Button buttonShowPassword;
        private Button buttonSalir;
    }
}