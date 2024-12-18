namespace WinFormsPcElements
{
    partial class FormBienvenida
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
            timerCerrarFormulario = new System.Windows.Forms.Timer(components);
            panelFondo = new Panel();
            labelProgreso = new Label();
            labelFinalizado = new Label();
            progressBarBienvenida = new ProgressBar();
            panelCentral = new Panel();
            tableLayoutPanelMain = new TableLayoutPanel();
            labelBienvenida = new Label();
            timerProgressBar = new System.Windows.Forms.Timer(components);
            panelFondo.SuspendLayout();
            panelCentral.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // timerCerrarFormulario
            // 
            timerCerrarFormulario.Interval = 3000;
            timerCerrarFormulario.Tick += timerCerrarFormulario_Tick;
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(15, 46, 34);
            panelFondo.Controls.Add(labelProgreso);
            panelFondo.Controls.Add(labelFinalizado);
            panelFondo.Controls.Add(progressBarBienvenida);
            panelFondo.Controls.Add(panelCentral);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Margin = new Padding(3, 2, 3, 2);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(492, 236);
            panelFondo.TabIndex = 0;
            // 
            // labelProgreso
            // 
            labelProgreso.AutoSize = true;
            labelProgreso.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProgreso.ForeColor = Color.White;
            labelProgreso.Location = new Point(12, 210);
            labelProgreso.Name = "labelProgreso";
            labelProgreso.Size = new Size(34, 17);
            labelProgreso.TabIndex = 3;
            labelProgreso.Text = "0%";
            // 
            // labelFinalizado
            // 
            labelFinalizado.AutoSize = true;
            labelFinalizado.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinalizado.ForeColor = Color.White;
            labelFinalizado.Location = new Point(369, 210);
            labelFinalizado.Name = "labelFinalizado";
            labelFinalizado.Size = new Size(101, 17);
            labelFinalizado.TabIndex = 2;
            labelFinalizado.Text = "ENTRANDO...";
            labelFinalizado.Visible = false;
            // 
            // progressBarBienvenida
            // 
            progressBarBienvenida.BackColor = Color.FromArgb(31, 216, 164);
            progressBarBienvenida.ForeColor = Color.FromArgb(50, 255, 230);
            progressBarBienvenida.Location = new Point(23, 184);
            progressBarBienvenida.Margin = new Padding(3, 2, 3, 2);
            progressBarBienvenida.Name = "progressBarBienvenida";
            progressBarBienvenida.Size = new Size(447, 16);
            progressBarBienvenida.TabIndex = 1;
            // 
            // panelCentral
            // 
            panelCentral.BackgroundImage = Properties.Resources.rectangleDM;
            panelCentral.BackgroundImageLayout = ImageLayout.Stretch;
            panelCentral.Controls.Add(tableLayoutPanelMain);
            panelCentral.Location = new Point(76, 58);
            panelCentral.Margin = new Padding(3, 2, 3, 2);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(339, 111);
            panelCentral.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.BackColor = Color.Transparent;
            tableLayoutPanelMain.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(labelBienvenida, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(339, 111);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelBienvenida
            // 
            labelBienvenida.Anchor = AnchorStyles.None;
            labelBienvenida.AutoSize = true;
            labelBienvenida.BackColor = Color.Transparent;
            labelBienvenida.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = Color.White;
            labelBienvenida.Location = new Point(59, 41);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(220, 29);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido _User";
            labelBienvenida.TextAlign = ContentAlignment.BottomCenter;
            // 
            // timerProgressBar
            // 
            timerProgressBar.Enabled = true;
            timerProgressBar.Interval = 15;
            timerProgressBar.Tick += timerProgressBar_Tick;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 236);
            Controls.Add(panelFondo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBienvenida";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBienvenida";
            Load += FormBienvenida_Load;
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            panelCentral.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Timer timerCerrarFormulario;
        private Panel panelFondo;
        private Panel panelCentral;
        private Label labelBienvenida;
        private ProgressBar progressBarBienvenida;
        private System.Windows.Forms.Timer timerProgressBar;
        private Label labelFinalizado;
        private Label labelProgreso;
        private TableLayoutPanel tableLayoutPanelMain;
    }
}