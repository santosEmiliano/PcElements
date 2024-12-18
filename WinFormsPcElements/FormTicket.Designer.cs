namespace WinFormsPcElements
{
    partial class FormTicket
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            panelMain = new Panel();
            panelCentral = new Panel();
            labelTotalAdd = new Label();
            labelTotal = new Label();
            pictureBoxLogo = new PictureBox();
            labelNomTienda = new Label();
            labelFechaAdd = new Label();
            labelFolioAdd = new Label();
            labelFolio = new Label();
            labelNombreAdd = new Label();
            labelNombre = new Label();
            dGVProductos = new DataGridView();
            buttonRegresar = new Button();
            buttonTicket = new Button();
            timerHora = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGVProductos).BeginInit();
            SuspendLayout();
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(17, 26, 39);
            panelMain.Controls.Add(panelCentral);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(781, 429);
            panelMain.TabIndex = 2;
            // 
            // panelCentral
            // 
            panelCentral.BackgroundImage = Properties.Resources.BackgroundInfoDM;
            panelCentral.BackgroundImageLayout = ImageLayout.Stretch;
            panelCentral.Controls.Add(labelTotalAdd);
            panelCentral.Controls.Add(labelTotal);
            panelCentral.Controls.Add(labelNomTienda);
            panelCentral.Controls.Add(labelFechaAdd);
            panelCentral.Controls.Add(labelFolioAdd);
            panelCentral.Controls.Add(labelFolio);
            panelCentral.Controls.Add(labelNombreAdd);
            panelCentral.Controls.Add(labelNombre);
            panelCentral.Controls.Add(dGVProductos);
            panelCentral.Controls.Add(buttonRegresar);
            panelCentral.Controls.Add(buttonTicket);
            panelCentral.Controls.Add(pictureBoxLogo);
            panelCentral.Location = new Point(35, 38);
            panelCentral.Margin = new Padding(3, 2, 3, 2);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(709, 347);
            panelCentral.TabIndex = 0;
            // 
            // labelTotalAdd
            // 
            labelTotalAdd.AutoSize = true;
            labelTotalAdd.BackColor = Color.Transparent;
            labelTotalAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalAdd.ForeColor = Color.White;
            labelTotalAdd.Location = new Point(399, 297);
            labelTotalAdd.Name = "labelTotalAdd";
            labelTotalAdd.Size = new Size(56, 22);
            labelTotalAdd.TabIndex = 11;
            labelTotalAdd.Text = "_Total";
            labelTotalAdd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(226, 297);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(166, 22);
            labelTotal.TabIndex = 10;
            labelTotal.Text = "Total con Impuestos:";
            labelTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.circlePcElementsLogo;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(29, 2);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(113, 65);
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            // 
            // labelNomTienda
            // 
            labelNomTienda.AutoSize = true;
            labelNomTienda.BackColor = Color.Transparent;
            labelNomTienda.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomTienda.ForeColor = Color.White;
            labelNomTienda.Location = new Point(131, 10);
            labelNomTienda.Name = "labelNomTienda";
            labelNomTienda.Size = new Size(541, 27);
            labelNomTienda.TabIndex = 8;
            labelNomTienda.Text = "PC<Elements> Powered Computational Enviroment";
            labelNomTienda.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFechaAdd
            // 
            labelFechaAdd.AutoSize = true;
            labelFechaAdd.BackColor = Color.Transparent;
            labelFechaAdd.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            labelFechaAdd.ForeColor = Color.White;
            labelFechaAdd.Location = new Point(566, 55);
            labelFechaAdd.Name = "labelFechaAdd";
            labelFechaAdd.Size = new Size(86, 18);
            labelFechaAdd.TabIndex = 7;
            labelFechaAdd.Text = "dd/mm/aaaa";
            labelFechaAdd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFolioAdd
            // 
            labelFolioAdd.AutoSize = true;
            labelFolioAdd.BackColor = Color.Transparent;
            labelFolioAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFolioAdd.ForeColor = Color.White;
            labelFolioAdd.Location = new Point(217, 49);
            labelFolioAdd.Name = "labelFolioAdd";
            labelFolioAdd.Size = new Size(56, 22);
            labelFolioAdd.TabIndex = 6;
            labelFolioAdd.Text = "_Folio";
            labelFolioAdd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFolio
            // 
            labelFolio.AutoSize = true;
            labelFolio.BackColor = Color.Transparent;
            labelFolio.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFolio.ForeColor = Color.White;
            labelFolio.Location = new Point(166, 48);
            labelFolio.Name = "labelFolio";
            labelFolio.Size = new Size(53, 22);
            labelFolio.TabIndex = 5;
            labelFolio.Text = "Folio:";
            labelFolio.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNombreAdd
            // 
            labelNombreAdd.AutoSize = true;
            labelNombreAdd.BackColor = Color.Transparent;
            labelNombreAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreAdd.ForeColor = Color.White;
            labelNombreAdd.Location = new Point(130, 80);
            labelNombreAdd.Name = "labelNombreAdd";
            labelNombreAdd.Size = new Size(79, 22);
            labelNombreAdd.TabIndex = 4;
            labelNombreAdd.Text = "_Nombre";
            labelNombreAdd.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(52, 80);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(76, 22);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre:";
            labelNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // dGVProductos
            // 
            dGVProductos.AllowUserToAddRows = false;
            dGVProductos.AllowUserToDeleteRows = false;
            dGVProductos.AllowUserToOrderColumns = true;
            dGVProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dGVProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dGVProductos.EnableHeadersVisualStyles = false;
            dGVProductos.Location = new Point(52, 114);
            dGVProductos.Margin = new Padding(3, 2, 3, 2);
            dGVProductos.Name = "dGVProductos";
            dGVProductos.ReadOnly = true;
            dGVProductos.RowHeadersWidth = 51;
            dGVProductos.Size = new Size(612, 131);
            dGVProductos.TabIndex = 2;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.BackgroundImage = Properties.Resources.BackgroundInfoLM;
            buttonRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRegresar.Cursor = Cursors.Hand;
            buttonRegresar.FlatAppearance.BorderSize = 0;
            buttonRegresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonRegresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.ForeColor = Color.White;
            buttonRegresar.Location = new Point(538, 280);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(126, 54);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.Transparent;
            buttonTicket.BackgroundImage = Properties.Resources.BackgroundInfoLM;
            buttonTicket.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTicket.Cursor = Cursors.Hand;
            buttonTicket.FlatAppearance.BorderSize = 0;
            buttonTicket.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTicket.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTicket.FlatStyle = FlatStyle.Flat;
            buttonTicket.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTicket.ForeColor = Color.White;
            buttonTicket.Location = new Point(52, 280);
            buttonTicket.Margin = new Padding(3, 2, 3, 2);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(126, 54);
            buttonTicket.TabIndex = 0;
            buttonTicket.Text = "Generar Ticket";
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 429);
            Controls.Add(panelMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTicket";
            Load += FormTicket_Load;
            panelMain.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGVProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerAnimacion;
        private Panel panelMain;
        private Panel panelCentral;
        private Label labelTotalAdd;
        private Label labelTotal;
        private PictureBox pictureBoxLogo;
        private Label labelNomTienda;
        private Label labelFechaAdd;
        private Label labelFolioAdd;
        private Label labelFolio;
        private Label labelNombreAdd;
        private Label labelNombre;
        private DataGridView dGVProductos;
        private Button buttonRegresar;
        private Button buttonTicket;
        private System.Windows.Forms.Timer timerHora;
    }
}