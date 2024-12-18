namespace WinFormsPcElements
{
    partial class FormAyuda
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
            buttonAltExitMenu = new Button();
            tableLayoutPanelExitMenu = new TableLayoutPanel();
            buttonClose = new Button();
            buttonRegresar = new Button();
            timerExitMenu = new System.Windows.Forms.Timer(components);
            timerAnimacion = new System.Windows.Forms.Timer(components);
            pictureBoxAyuda = new PictureBox();
            panelHeader.SuspendLayout();
            tableLayoutPanelExitMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAyuda).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(36, 104, 84);
            panelHeader.Controls.Add(buttonAltExitMenu);
            panelHeader.Controls.Add(tableLayoutPanelExitMenu);
            panelHeader.Controls.Add(buttonRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(946, 65);
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
            buttonAltExitMenu.Location = new Point(830, 0);
            buttonAltExitMenu.Name = "buttonAltExitMenu";
            buttonAltExitMenu.Size = new Size(55, 65);
            buttonAltExitMenu.TabIndex = 10;
            buttonAltExitMenu.UseVisualStyleBackColor = true;
            buttonAltExitMenu.Click += buttonAltExitMenu_Click;
            // 
            // tableLayoutPanelExitMenu
            // 
            tableLayoutPanelExitMenu.ColumnCount = 1;
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanelExitMenu.Controls.Add(buttonClose, 0, 0);
            tableLayoutPanelExitMenu.Dock = DockStyle.Right;
            tableLayoutPanelExitMenu.Location = new Point(885, 0);
            tableLayoutPanelExitMenu.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelExitMenu.Name = "tableLayoutPanelExitMenu";
            tableLayoutPanelExitMenu.RowCount = 1;
            tableLayoutPanelExitMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelExitMenu.Size = new Size(61, 65);
            tableLayoutPanelExitMenu.TabIndex = 9;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.None;
            buttonClose.BackColor = Color.Transparent;
            buttonClose.BackgroundImage = Properties.Resources.closeIcon;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(7, 9);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(46, 46);
            buttonClose.TabIndex = 4;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonSalir_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Center;
            buttonRegresar.Cursor = Cursors.Hand;
            buttonRegresar.Dock = DockStyle.Left;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(0, 0);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(85, 65);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // timerExitMenu
            // 
            timerExitMenu.Enabled = true;
            timerExitMenu.Interval = 20;
            timerExitMenu.Tick += timerExitMenu_Tick;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // pictureBoxAyuda
            // 
            pictureBoxAyuda.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAyuda.Dock = DockStyle.Fill;
            pictureBoxAyuda.Image = Properties.Resources.FormPrincipalImage;
            pictureBoxAyuda.Location = new Point(0, 65);
            pictureBoxAyuda.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAyuda.Name = "pictureBoxAyuda";
            pictureBoxAyuda.Size = new Size(946, 350);
            pictureBoxAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAyuda.TabIndex = 2;
            pictureBoxAyuda.TabStop = false;
            // 
            // FormAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 46, 34);
            ClientSize = new Size(946, 415);
            Controls.Add(pictureBoxAyuda);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAyuda";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAyuda";
            Load += FormAyuda_Load;
            panelHeader.ResumeLayout(false);
            tableLayoutPanelExitMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAyuda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonRegresar;
        private Button buttonAltExitMenu;
        private TableLayoutPanel tableLayoutPanelExitMenu;
        private Button buttonClose;
        private System.Windows.Forms.Timer timerExitMenu;
        private System.Windows.Forms.Timer timerAnimacion;
        private PictureBox pictureBoxAyuda;
    }
}