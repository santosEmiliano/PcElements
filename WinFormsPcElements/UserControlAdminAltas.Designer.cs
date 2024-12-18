namespace WinFormsPcElements
{
    partial class UserControlAdminAltas
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
            tableLayoutPanelBackgroud = new TableLayoutPanel();
            tableLayoutPanelMain = new TableLayoutPanel();
            panelInfo = new Panel();
            pictureBoxImg = new PictureBox();
            labelImg = new Label();
            buttonAgregar = new Button();
            panelListaProductos = new Panel();
            tableLayoutPanelHeader = new TableLayoutPanel();
            textBoxGama = new TextBox();
            textBoxTipo = new TextBox();
            textBoxNombre = new TextBox();
            labelGama = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            labelId = new Label();
            textBoxId = new TextBox();
            tableLayoutPanelFooter = new TableLayoutPanel();
            textBoxPrecio = new TextBox();
            textBoxStock = new TextBox();
            labelImagen = new Label();
            labelPrecio = new Label();
            labelStock = new Label();
            labelDescripcion = new Label();
            panelImagenBoton = new Panel();
            buttonImg = new Button();
            textBoxDescripcion = new TextBox();
            tableLayoutPanelBackgroud.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).BeginInit();
            tableLayoutPanelHeader.SuspendLayout();
            tableLayoutPanelFooter.SuspendLayout();
            panelImagenBoton.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelBackgroud
            // 
            tableLayoutPanelBackgroud.ColumnCount = 1;
            tableLayoutPanelBackgroud.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBackgroud.Controls.Add(tableLayoutPanelMain, 0, 2);
            tableLayoutPanelBackgroud.Controls.Add(tableLayoutPanelHeader, 0, 0);
            tableLayoutPanelBackgroud.Controls.Add(tableLayoutPanelFooter, 0, 1);
            tableLayoutPanelBackgroud.Dock = DockStyle.Fill;
            tableLayoutPanelBackgroud.Location = new Point(0, 0);
            tableLayoutPanelBackgroud.Margin = new Padding(2);
            tableLayoutPanelBackgroud.Name = "tableLayoutPanelBackgroud";
            tableLayoutPanelBackgroud.RowCount = 3;
            tableLayoutPanelBackgroud.RowStyles.Add(new RowStyle(SizeType.Percent, 22.7353458F));
            tableLayoutPanelBackgroud.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0248661F));
            tableLayoutPanelBackgroud.RowStyles.Add(new RowStyle(SizeType.Percent, 55.2397881F));
            tableLayoutPanelBackgroud.Size = new Size(813, 563);
            tableLayoutPanelBackgroud.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.9690247F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.03098F));
            tableLayoutPanelMain.Controls.Add(panelInfo, 1, 0);
            tableLayoutPanelMain.Controls.Add(panelListaProductos, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(3, 255);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(807, 305);
            tableLayoutPanelMain.TabIndex = 3;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(pictureBoxImg);
            panelInfo.Controls.Add(labelImg);
            panelInfo.Controls.Add(buttonAgregar);
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Location = new Point(608, 3);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(10);
            panelInfo.Size = new Size(196, 299);
            panelInfo.TabIndex = 1;
            // 
            // pictureBoxImg
            // 
            pictureBoxImg.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImg.Dock = DockStyle.Top;
            pictureBoxImg.Location = new Point(10, 65);
            pictureBoxImg.Name = "pictureBoxImg";
            pictureBoxImg.Padding = new Padding(10);
            pictureBoxImg.Size = new Size(176, 181);
            pictureBoxImg.TabIndex = 0;
            pictureBoxImg.TabStop = false;
            // 
            // labelImg
            // 
            labelImg.Dock = DockStyle.Top;
            labelImg.Font = new Font("Times New Roman", 18F);
            labelImg.ForeColor = Color.White;
            labelImg.Location = new Point(10, 10);
            labelImg.Margin = new Padding(2, 0, 2, 0);
            labelImg.Name = "labelImg";
            labelImg.Size = new Size(176, 55);
            labelImg.TabIndex = 2;
            labelImg.Text = "Imágen Cargada";
            labelImg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Cursor = Cursors.Hand;
            buttonAgregar.Dock = DockStyle.Bottom;
            buttonAgregar.FlatAppearance.BorderSize = 2;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Image = Properties.Resources.add_circleDM;
            buttonAgregar.Location = new Point(10, 235);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(176, 54);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar Registro";
            buttonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // panelListaProductos
            // 
            panelListaProductos.Dock = DockStyle.Fill;
            panelListaProductos.Location = new Point(3, 3);
            panelListaProductos.Name = "panelListaProductos";
            panelListaProductos.Size = new Size(599, 299);
            panelListaProductos.TabIndex = 2;
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
            tableLayoutPanelHeader.Controls.Add(textBoxId, 0, 1);
            tableLayoutPanelHeader.Dock = DockStyle.Fill;
            tableLayoutPanelHeader.Location = new Point(2, 2);
            tableLayoutPanelHeader.Margin = new Padding(2);
            tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            tableLayoutPanelHeader.RowCount = 2;
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelHeader.Size = new Size(809, 124);
            tableLayoutPanelHeader.TabIndex = 0;
            // 
            // textBoxGama
            // 
            textBoxGama.Anchor = AnchorStyles.None;
            textBoxGama.BorderStyle = BorderStyle.None;
            textBoxGama.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxGama.Location = new Point(654, 75);
            textBoxGama.Margin = new Padding(2);
            textBoxGama.Name = "textBoxGama";
            textBoxGama.Size = new Size(106, 36);
            textBoxGama.TabIndex = 7;
            textBoxGama.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Anchor = AnchorStyles.None;
            textBoxTipo.BorderStyle = BorderStyle.None;
            textBoxTipo.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxTipo.Location = new Point(460, 75);
            textBoxTipo.Margin = new Padding(2);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(90, 36);
            textBoxTipo.TabIndex = 6;
            textBoxTipo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.None;
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(209, 78);
            textBoxNombre.Margin = new Padding(2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(187, 30);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // labelGama
            // 
            labelGama.Anchor = AnchorStyles.None;
            labelGama.AutoSize = true;
            labelGama.Font = new Font("Times New Roman", 18F);
            labelGama.ForeColor = Color.White;
            labelGama.Location = new Point(673, 17);
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
            labelTipo.Location = new Point(477, 17);
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
            labelNombre.Location = new Point(258, 17);
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
            labelId.Location = new Point(82, 17);
            labelId.Margin = new Padding(2, 0, 2, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(37, 27);
            labelId.TabIndex = 0;
            labelId.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.None;
            textBoxId.BackColor = Color.White;
            textBoxId.BorderStyle = BorderStyle.None;
            textBoxId.Font = new Font("Verdana", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxId.ForeColor = SystemColors.WindowText;
            textBoxId.Location = new Point(32, 75);
            textBoxId.Margin = new Padding(2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(138, 36);
            textBoxId.TabIndex = 4;
            textBoxId.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanelFooter
            // 
            tableLayoutPanelFooter.ColumnCount = 4;
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelFooter.Controls.Add(textBoxPrecio, 2, 1);
            tableLayoutPanelFooter.Controls.Add(textBoxStock, 1, 1);
            tableLayoutPanelFooter.Controls.Add(labelImagen, 3, 0);
            tableLayoutPanelFooter.Controls.Add(labelPrecio, 2, 0);
            tableLayoutPanelFooter.Controls.Add(labelStock, 1, 0);
            tableLayoutPanelFooter.Controls.Add(labelDescripcion, 0, 0);
            tableLayoutPanelFooter.Controls.Add(panelImagenBoton, 3, 1);
            tableLayoutPanelFooter.Controls.Add(textBoxDescripcion, 0, 1);
            tableLayoutPanelFooter.Dock = DockStyle.Fill;
            tableLayoutPanelFooter.Location = new Point(2, 130);
            tableLayoutPanelFooter.Margin = new Padding(2);
            tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            tableLayoutPanelFooter.RowCount = 2;
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelFooter.Size = new Size(809, 120);
            tableLayoutPanelFooter.TabIndex = 1;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.None;
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxPrecio.Location = new Point(452, 72);
            textBoxPrecio.Margin = new Padding(2);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(106, 36);
            textBoxPrecio.TabIndex = 7;
            textBoxPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.None;
            textBoxStock.BorderStyle = BorderStyle.None;
            textBoxStock.Font = new Font("Verdana", 21.75F, FontStyle.Italic);
            textBoxStock.Location = new Point(250, 72);
            textBoxStock.Margin = new Padding(2);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(106, 36);
            textBoxStock.TabIndex = 6;
            textBoxStock.TextAlign = HorizontalAlignment.Center;
            // 
            // labelImagen
            // 
            labelImagen.Anchor = AnchorStyles.None;
            labelImagen.AutoSize = true;
            labelImagen.Font = new Font("Times New Roman", 18F);
            labelImagen.ForeColor = Color.White;
            labelImagen.Location = new Point(666, 16);
            labelImagen.Margin = new Padding(2, 0, 2, 0);
            labelImagen.Name = "labelImagen";
            labelImagen.Size = new Size(83, 27);
            labelImagen.TabIndex = 4;
            labelImagen.Text = "Imagen";
            // 
            // labelPrecio
            // 
            labelPrecio.Anchor = AnchorStyles.None;
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Times New Roman", 18F);
            labelPrecio.ForeColor = Color.White;
            labelPrecio.Location = new Point(468, 16);
            labelPrecio.Margin = new Padding(2, 0, 2, 0);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(74, 27);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio";
            // 
            // labelStock
            // 
            labelStock.Anchor = AnchorStyles.None;
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Times New Roman", 18F);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(270, 16);
            labelStock.Margin = new Padding(2, 0, 2, 0);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(66, 27);
            labelStock.TabIndex = 2;
            labelStock.Text = "Stock";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.None;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Times New Roman", 18F);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(37, 16);
            labelDescripcion.Margin = new Padding(2, 0, 2, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(127, 27);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "Descripcion";
            // 
            // panelImagenBoton
            // 
            panelImagenBoton.Controls.Add(buttonImg);
            panelImagenBoton.Dock = DockStyle.Fill;
            panelImagenBoton.Location = new Point(608, 62);
            panelImagenBoton.Margin = new Padding(2);
            panelImagenBoton.Name = "panelImagenBoton";
            panelImagenBoton.Size = new Size(199, 56);
            panelImagenBoton.TabIndex = 8;
            // 
            // buttonImg
            // 
            buttonImg.Anchor = AnchorStyles.None;
            buttonImg.BackgroundImageLayout = ImageLayout.Stretch;
            buttonImg.Cursor = Cursors.Hand;
            buttonImg.FlatStyle = FlatStyle.Flat;
            buttonImg.Image = Properties.Resources.File_plusDM;
            buttonImg.ImageAlign = ContentAlignment.TopCenter;
            buttonImg.Location = new Point(22, 0);
            buttonImg.Name = "buttonImg";
            buttonImg.Size = new Size(158, 51);
            buttonImg.TabIndex = 0;
            buttonImg.Text = "Agregar imágen";
            buttonImg.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonImg.UseVisualStyleBackColor = true;
            buttonImg.Click += buttonImg_Click;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Dock = DockStyle.Fill;
            textBoxDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescripcion.Location = new Point(2, 62);
            textBoxDescripcion.Margin = new Padding(2);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ScrollBars = ScrollBars.Both;
            textBoxDescripcion.Size = new Size(198, 56);
            textBoxDescripcion.TabIndex = 5;
            // 
            // UserControlAdminAltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 20, 31);
            Controls.Add(tableLayoutPanelBackgroud);
            Margin = new Padding(2);
            Name = "UserControlAdminAltas";
            Size = new Size(813, 563);
            Load += UserControlAdminAltas_Load;
            tableLayoutPanelBackgroud.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImg).EndInit();
            tableLayoutPanelHeader.ResumeLayout(false);
            tableLayoutPanelHeader.PerformLayout();
            tableLayoutPanelFooter.ResumeLayout(false);
            tableLayoutPanelFooter.PerformLayout();
            panelImagenBoton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelBackgroud;
        private TableLayoutPanel tableLayoutPanelHeader;
        private Label labelGama;
        private Label labelTipo;
        private Label labelNombre;
        private Label labelId;
        private TableLayoutPanel tableLayoutPanelFooter;
        private Label labelImagen;
        private Label labelPrecio;
        private Label labelStock;
        private Label labelDescripcion;
        private TextBox textBoxGama;
        private TextBox textBoxTipo;
        private TextBox textBoxNombre;
        private TextBox textBoxId;
        private TextBox textBoxPrecio;
        private TextBox textBoxStock;
        private TextBox textBoxDescripcion;
        private Panel panelImagenBoton;
        private Button buttonImg;
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelInfo;
        private Button buttonAgregar;
        private PictureBox pictureBoxImg;
        private Panel panelListaProductos;
        private Label labelImg;
    }
}
