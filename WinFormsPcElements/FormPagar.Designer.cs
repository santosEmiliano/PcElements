namespace WinFormsPcElements
{
    partial class FormPagar
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
            labelTotal = new Label();
            buttonLimpiar = new Button();
            buttonPagar = new Button();
            panelProductos = new Panel();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            timerExitMenu = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(36, 104, 84);
            panelHeader.Controls.Add(buttonRegresar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(711, 59);
            panelHeader.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Center;
            buttonRegresar.Dock = DockStyle.Left;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Location = new Point(0, 0);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(57, 59);
            buttonRegresar.TabIndex = 0;
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(41, 163, 131);
            panelCentral.Controls.Add(labelTotal);
            panelCentral.Controls.Add(buttonLimpiar);
            panelCentral.Controls.Add(buttonPagar);
            panelCentral.Controls.Add(panelProductos);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 59);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(711, 402);
            panelCentral.TabIndex = 1;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(316, 329);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(24, 26);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "$";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Transparent;
            buttonLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.ForeColor = Color.White;
            buttonLimpiar.Location = new Point(545, 299);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(154, 91);
            buttonLimpiar.TabIndex = 2;
            buttonLimpiar.Text = "Limpiar \r\nCarrito\r\n";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonPagar
            // 
            buttonPagar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPagar.ForeColor = Color.White;
            buttonPagar.Location = new Point(12, 299);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(154, 91);
            buttonPagar.TabIndex = 1;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // panelProductos
            // 
            panelProductos.AutoScroll = true;
            panelProductos.BackColor = Color.Transparent;
            panelProductos.BackgroundImage = Properties.Resources.rectangleDM;
            panelProductos.BackgroundImageLayout = ImageLayout.Stretch;
            panelProductos.Location = new Point(40, 26);
            panelProductos.Name = "panelProductos";
            panelProductos.Padding = new Padding(10);
            panelProductos.Size = new Size(636, 255);
            panelProductos.TabIndex = 0;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // timerExitMenu
            // 
            timerExitMenu.Interval = 20;
            // 
            // FormPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 461);
            Controls.Add(panelCentral);
            Controls.Add(panelHeader);
            Name = "FormPagar";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPagar";
            Load += FormPagar_Load;
            panelHeader.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonRegresar;
        private Panel panelCentral;
        private Panel panelProductos;
        private Button buttonPagar;
        private Button buttonLimpiar;
        private Label labelTotal;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Timer timerExitMenu;
    }
}