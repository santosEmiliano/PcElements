namespace WinFormsPcElements
{
    partial class UserControlModificar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanelBackground = new TableLayoutPanel();
            tableLayoutPanelCenter = new TableLayoutPanel();
            textBoxPrecio = new TextBox();
            textBoxStock = new TextBox();
            textBoxDescripcion = new TextBox();
            labelImagen = new Label();
            labelPrecio = new Label();
            labelStock = new Label();
            labelDescripcion = new Label();
            panel1 = new Panel();
            buttonAgregarImagen = new Button();
            tableLayoutPanelHeader = new TableLayoutPanel();
            textBoxGama = new TextBox();
            textBoxTipo = new TextBox();
            textBoxNombre = new TextBox();
            labelGama = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            labelId = new Label();
            numericUpDownId = new NumericUpDown();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelInfo = new Panel();
            buttonModificar = new Button();
            pictureBoxImg = new PictureBox();
            labelImg = new Label();
            panelListaProductos = new Panel();
            tableLayoutPanelBackground.SuspendLayout();
            tableLayoutPanelCenter.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelBackground
            // 
            tableLayoutPanelBackground.ColumnCount = 1;
            tableLayoutPanelBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBackground.Controls.Add(tableLayoutPanelCenter, 0, 1);
            tableLayoutPanelBackground.Controls.Add(tableLayoutPanelHeader, 0, 0);
            tableLayoutPanelBackground.Controls.Add(tableLayoutPanelMain, 0, 2);
            tableLayoutPanelBackground.Dock = DockStyle.Fill;
            tableLayoutPanelBackground.Location = new Point(0, 0);
            tableLayoutPanelBackground.Margin = new Padding(2);
            tableLayoutPanelBackground.Name = "tableLayoutPanelBackground";
            tableLayoutPanelBackground.RowCount = 3;
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanelBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanelBackground.Size = new Size(963, 597);
            tableLayoutPanelBackground.TabIndex = 0;
            // 
            // tableLayoutPanelCenter
            // 
            tableLayoutPanelCenter.ColumnCount = 4;
            tableLayoutPanelCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCenter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCenter.Controls.Add(textBoxPrecio, 2, 1);
            tableLayoutPanelCenter.Controls.Add(textBoxStock, 1, 1);
            tableLayoutPanelCenter.Controls.Add(textBoxDescripcion, 0, 1);
            tableLayoutPanelCenter.Controls.Add(labelImagen, 3, 0);
            tableLayoutPanelCenter.Controls.Add(labelPrecio, 2, 0);
            tableLayoutPanelCenter.Controls.Add(labelStock, 1, 0);
            tableLayoutPanelCenter.Controls.Add(labelDescripcion, 0, 0);
            tableLayoutPanelCenter.Controls.Add(panel1, 3, 1);
            tableLayoutPanelCenter.Dock = DockStyle.Fill;
            tableLayoutPanelCenter.Location = new Point(2, 134);
            tableLayoutPanelCenter.Margin = new Padding(2);
            tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            tableLayoutPanelCenter.RowCount = 2;
            tableLayoutPanelCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCenter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCenter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCenter.Size = new Size(959, 128);
            tableLayoutPanelCenter.TabIndex = 1;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.None;
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxPrecio.Location = new Point(544, 78);
            textBoxPrecio.Margin = new Padding(2);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(106, 36);
            textBoxPrecio.TabIndex = 15;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.None;
            textBoxStock.BorderStyle = BorderStyle.None;
            textBoxStock.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxStock.Location = new Point(305, 78);
            textBoxStock.Margin = new Padding(2);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(106, 36);
            textBoxStock.TabIndex = 14;
            textBoxStock.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Dock = DockStyle.Fill;
            textBoxDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescripcion.Location = new Point(2, 66);
            textBoxDescripcion.Margin = new Padding(2);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ScrollBars = ScrollBars.Both;
            textBoxDescripcion.Size = new Size(235, 60);
            textBoxDescripcion.TabIndex = 13;
            // 
            // labelImagen
            // 
            labelImagen.Anchor = AnchorStyles.None;
            labelImagen.AutoSize = true;
            labelImagen.BackColor = Color.Transparent;
            labelImagen.Font = new Font("Times New Roman", 18F);
            labelImagen.ForeColor = Color.White;
            labelImagen.Location = new Point(796, 18);
            labelImagen.Margin = new Padding(2, 0, 2, 0);
            labelImagen.Name = "labelImagen";
            labelImagen.Size = new Size(83, 27);
            labelImagen.TabIndex = 5;
            labelImagen.Text = "Imagen";
            // 
            // labelPrecio
            // 
            labelPrecio.Anchor = AnchorStyles.None;
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Times New Roman", 18F);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(560, 18);
            labelPrecio.Margin = new Padding(2, 0, 2, 0);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(74, 27);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio";
            // 
            // labelStock
            // 
            labelStock.Anchor = AnchorStyles.None;
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Times New Roman", 18F);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(325, 18);
            labelStock.Margin = new Padding(2, 0, 2, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(66, 27);
            labelStock.TabIndex = 3;
            labelStock.Text = "Stock";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.None;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Times New Roman", 18F);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(56, 18);
            labelDescripcion.Margin = new Padding(2, 0, 2, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(127, 27);
            labelDescripcion.TabIndex = 2;
            labelDescripcion.Text = "Descripcion";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAgregarImagen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(719, 66);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 60);
            panel1.TabIndex = 12;
            // 
            // buttonAgregarImagen
            // 
            buttonAgregarImagen.Anchor = AnchorStyles.None;
            buttonAgregarImagen.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregarImagen.Cursor = Cursors.Hand;
            buttonAgregarImagen.FlatStyle = FlatStyle.Flat;
            buttonAgregarImagen.ImageAlign = ContentAlignment.TopCenter;
            buttonAgregarImagen.Location = new Point(44, 6);
            buttonAgregarImagen.Name = "buttonAgregarImagen";
            buttonAgregarImagen.Size = new Size(158, 51);
            buttonAgregarImagen.TabIndex = 1;
            buttonAgregarImagen.Text = "Agregar imágen";
            buttonAgregarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAgregarImagen.UseVisualStyleBackColor = true;
            buttonAgregarImagen.Click += buttonAgregarImagen_Click;
            // 
            // tableLayoutPanelHeader
            // 
            tableLayoutPanelHeader.ColumnCount = 4;
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelHeader.Controls.Add(textBoxGama, 3, 1);
            tableLayoutPanelHeader.Controls.Add(textBoxTipo, 2, 1);
            tableLayoutPanelHeader.Controls.Add(textBoxNombre, 1, 1);
            tableLayoutPanelHeader.Controls.Add(labelGama, 3, 0);
            tableLayoutPanelHeader.Controls.Add(labelTipo, 2, 0);
            tableLayoutPanelHeader.Controls.Add(labelNombre, 1, 0);
            tableLayoutPanelHeader.Controls.Add(labelId, 0, 0);
            tableLayoutPanelHeader.Controls.Add(numericUpDownId, 0, 1);
            tableLayoutPanelHeader.Dock = DockStyle.Fill;
            tableLayoutPanelHeader.Location = new Point(2, 2);
            tableLayoutPanelHeader.Margin = new Padding(2);
            tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            tableLayoutPanelHeader.RowCount = 2;
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.Size = new Size(959, 128);
            tableLayoutPanelHeader.TabIndex = 0;
            // 
            // textBoxGama
            // 
            textBoxGama.Anchor = AnchorStyles.None;
            textBoxGama.BorderStyle = BorderStyle.None;
            textBoxGama.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxGama.Location = new Point(785, 78);
            textBoxGama.Margin = new Padding(2);
            textBoxGama.Name = "textBoxGama";
            textBoxGama.Size = new Size(106, 36);
            textBoxGama.TabIndex = 11;
            textBoxGama.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Anchor = AnchorStyles.None;
            textBoxTipo.BorderStyle = BorderStyle.None;
            textBoxTipo.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxTipo.Location = new Point(552, 78);
            textBoxTipo.Margin = new Padding(2);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(90, 36);
            textBoxTipo.TabIndex = 10;
            textBoxTipo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.None;
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(265, 81);
            textBoxNombre.Margin = new Padding(2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(187, 30);
            textBoxNombre.TabIndex = 9;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // labelGama
            // 
            labelGama.Anchor = AnchorStyles.None;
            labelGama.AutoSize = true;
            labelGama.Font = new Font("Times New Roman", 18F);
            labelGama.ForeColor = Color.White;
            labelGama.Location = new Point(803, 18);
            labelGama.Margin = new Padding(2, 0, 2, 0);
            labelGama.Name = "labelGama";
            labelGama.Size = new Size(69, 27);
            labelGama.TabIndex = 3;
            labelGama.Text = "Gama";
            // 
            // labelTipo
            // 
            labelTipo.Anchor = AnchorStyles.None;
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Times New Roman", 18F);
            labelTipo.ForeColor = Color.White;
            labelTipo.Location = new Point(570, 18);
            labelTipo.Margin = new Padding(2, 0, 2, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(55, 27);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo";
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.None;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Times New Roman", 18F);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(313, 18);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(90, 27);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.None;
            labelId.AutoSize = true;
            labelId.Font = new Font("Times New Roman", 18F);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(101, 18);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(37, 27);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Anchor = AnchorStyles.None;
            numericUpDownId.Location = new Point(56, 84);
            numericUpDownId.Margin = new Padding(2);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(126, 23);
            numericUpDownId.TabIndex = 4;
            numericUpDownId.ValueChanged += numericUpDownId_ValueChanged;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.32279F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6772137F));
            tableLayoutPanelMain.Controls.Add(panelInfo, 1, 0);
            tableLayoutPanelMain.Controls.Add(panelListaProductos, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(3, 267);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(957, 327);
            tableLayoutPanelMain.TabIndex = 2;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(buttonModificar);
            panelInfo.Controls.Add(pictureBoxImg);
            panelInfo.Controls.Add(labelImg);
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Location = new Point(695, 3);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(259, 321);
            panelInfo.TabIndex = 0;
            // 
            // buttonModificar
            // 
            buttonModificar.Cursor = Cursors.Hand;
            buttonModificar.Dock = DockStyle.Bottom;
            buttonModificar.FlatAppearance.BorderSize = 2;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Image = Properties.Resources.add_circleDM;
            buttonModificar.Location = new Point(0, 267);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(259, 54);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Agregar Registro";
            buttonModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImg.Dock = DockStyle.Top;
            pictureBoxImg.Location = new Point(0, 55);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Padding = new Padding(10);
            pictureBoxImg.Size = new Size(259, 181);
            pictureBoxImg.TabIndex = 4;
            pictureBoxImg.TabStop = false;
            // 
            // labelImg
            // 
            labelImg.Dock = DockStyle.Top;
            labelImg.Font = new Font("Times New Roman", 18F);
            labelImg.ForeColor = Color.White;
            labelImg.Location = new Point(0, 0);
            labelImg.Margin = new Padding(2, 0, 2, 0);
            labelImg.Name = "labelImg";
            labelImg.Size = new Size(259, 55);
            labelImg.TabIndex = 3;
            labelImg.Text = "Imágen Cargada";
            labelImg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelListaProductos
            // 
            panelListaProductos.Dock = DockStyle.Fill;
            panelListaProductos.Location = new Point(3, 3);
            panelListaProductos.Name = "panelListaProductos";
            panelListaProductos.Size = new Size(686, 321);
            panelListaProductos.TabIndex = 1;
            // 
            // UserControlModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 20, 31);
            Controls.Add(tableLayoutPanelBackground);
            Margin = new Padding(2);
            Name = "UserControlModificar";
            Size = new Size(963, 597);
            Load += UserControlModificar_Load;
            tableLayoutPanelBackground.ResumeLayout(false);
            tableLayoutPanelCenter.ResumeLayout(false);
            tableLayoutPanelCenter.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanelHeader.ResumeLayout(false);
            tableLayoutPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelBackground;
        private TableLayoutPanel tableLayoutPanelCenter;
        private TableLayoutPanel tableLayoutPanelHeader;
        private Label labelId;
        private Label labelNombre;
        private Label labelImagen;
        private Label labelPrecio;
        private Label labelStock;
        private Label labelDescripcion;
        private Label labelGama;
        private Label labelTipo;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelInfo;
        private Label labelImg;
        private PictureBox pictureBoxImg;
        private Button buttonModificar;
        private NumericUpDown numericUpDownId;
        private TextBox textBoxNombre;
        private TextBox textBoxTipo;
        private TextBox textBoxGama;
        private TextBox textBoxDescripcion;
        private TextBox textBoxStock;
        private TextBox textBoxPrecio;
        private Button buttonAgregarImagen;
        private Panel panelListaProductos;
    }
}
