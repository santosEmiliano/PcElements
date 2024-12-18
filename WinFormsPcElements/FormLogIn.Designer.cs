namespace WinFormsPcElements
{
    partial class FormLogIn
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
            buttonRegresar = new Button();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            panelHeader = new Panel();
            buttonSalir = new Button();
            panelCentral = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBoxLogo = new PictureBox();
            panelUser = new Panel();
            textBoxUser = new TextBox();
            panelContinuar = new Panel();
            buttonContinuar = new Button();
            panelHeader.SuspendLayout();
            panelCentral.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelUser.SuspendLayout();
            panelContinuar.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Center;
            buttonRegresar.Dock = DockStyle.Left;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(0, 0);
            buttonRegresar.Margin = new Padding(2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(78, 58);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 46, 34);
            panelHeader.Controls.Add(buttonSalir);
            panelHeader.Controls.Add(buttonRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(775, 58);
            panelHeader.TabIndex = 1;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = Properties.Resources.closeIcon;
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.Dock = DockStyle.Right;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(700, 0);
            buttonSalir.Margin = new Padding(2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 58);
            buttonSalir.TabIndex = 1;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(15, 46, 34);
            panelCentral.Controls.Add(tableLayoutPanel1);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 58);
            panelCentral.Margin = new Padding(2);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(775, 373);
            panelCentral.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.Controls.Add(pictureBoxLogo, 0, 0);
            tableLayoutPanel1.Controls.Add(panelUser, 0, 1);
            tableLayoutPanel1.Location = new Point(86, 36);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(604, 302);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(217, 7);
            pictureBoxLogo.Margin = new Padding(2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(169, 136);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelUser
            // 
            panelUser.BackgroundImage = Properties.Resources.BackgroundInfoDM;
            panelUser.BackgroundImageLayout = ImageLayout.Stretch;
            panelUser.Controls.Add(textBoxUser);
            panelUser.Controls.Add(panelContinuar);
            panelUser.Dock = DockStyle.Fill;
            panelUser.Location = new Point(2, 153);
            panelUser.Margin = new Padding(2);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(600, 147);
            panelUser.TabIndex = 1;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.None;
            textBoxUser.BackColor = Color.FromArgb(41, 163, 131);
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUser.ForeColor = Color.White;
            textBoxUser.Location = new Point(124, 27);
            textBoxUser.Margin = new Padding(2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "USER";
            textBoxUser.Size = new Size(341, 44);
            textBoxUser.TabIndex = 1;
            textBoxUser.Tag = "";
            textBoxUser.TextAlign = HorizontalAlignment.Center;
            textBoxUser.KeyPress += textBoxUser_KeyPress;
            // 
            // panelContinuar
            // 
            panelContinuar.BackColor = Color.Transparent;
            panelContinuar.Controls.Add(buttonContinuar);
            panelContinuar.Dock = DockStyle.Bottom;
            panelContinuar.Location = new Point(0, 93);
            panelContinuar.Margin = new Padding(2);
            panelContinuar.Name = "panelContinuar";
            panelContinuar.Size = new Size(600, 54);
            panelContinuar.TabIndex = 0;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = Color.Transparent;
            buttonContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonContinuar.Cursor = Cursors.Hand;
            buttonContinuar.FlatAppearance.BorderSize = 0;
            buttonContinuar.FlatStyle = FlatStyle.Flat;
            buttonContinuar.ForeColor = Color.FromArgb(187, 255, 225);
            buttonContinuar.Location = new Point(484, 0);
            buttonContinuar.Margin = new Padding(2);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(84, 38);
            buttonContinuar.TabIndex = 0;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 431);
            Controls.Add(panelCentral);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "FormLogIn";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogIn";
            Load += FormLogIn_Load;
            panelHeader.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelContinuar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegresar;
        private System.Windows.Forms.Timer timerAnimacion;
        private Panel panelHeader;
        private Panel panelCentral;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxLogo;
        private Panel panelUser;
        private Panel panelContinuar;
        private TextBox textBoxUser;
        private Button buttonContinuar;
        private Button buttonSalir;
    }
}