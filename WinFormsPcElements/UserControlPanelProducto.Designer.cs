namespace WinFormsPcElements
{
    partial class UserControlPanelProducto
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
            pictureBoxProducto = new PictureBox();
            buttonAgregarCarrito = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanelIzq = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelDescripcion = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelNombre = new Label();
            labelPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelIzq.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Anchor = AnchorStyles.None;
            pictureBoxProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProducto.Location = new Point(23, 3);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(150, 142);
            pictureBoxProducto.TabIndex = 0;
            pictureBoxProducto.TabStop = false;
            // 
            // buttonAgregarCarrito
            // 
            buttonAgregarCarrito.Anchor = AnchorStyles.None;
            buttonAgregarCarrito.BackColor = Color.Transparent;
            buttonAgregarCarrito.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAgregarCarrito.Cursor = Cursors.Hand;
            buttonAgregarCarrito.FlatAppearance.BorderSize = 0;
            buttonAgregarCarrito.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAgregarCarrito.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAgregarCarrito.FlatStyle = FlatStyle.Flat;
            buttonAgregarCarrito.Location = new Point(8, 151);
            buttonAgregarCarrito.Name = "buttonAgregarCarrito";
            buttonAgregarCarrito.Size = new Size(180, 46);
            buttonAgregarCarrito.TabIndex = 1;
            buttonAgregarCarrito.Text = "Agregar al carrito";
            buttonAgregarCarrito.UseCompatibleTextRendering = true;
            buttonAgregarCarrito.UseVisualStyleBackColor = false;
            buttonAgregarCarrito.Click += buttonAgregarCarrito_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanelIzq, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(813, 206);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanelIzq
            // 
            tableLayoutPanelIzq.ColumnCount = 1;
            tableLayoutPanelIzq.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelIzq.Controls.Add(buttonAgregarCarrito, 0, 1);
            tableLayoutPanelIzq.Controls.Add(pictureBoxProducto, 0, 0);
            tableLayoutPanelIzq.Dock = DockStyle.Fill;
            tableLayoutPanelIzq.Location = new Point(3, 3);
            tableLayoutPanelIzq.Name = "tableLayoutPanelIzq";
            tableLayoutPanelIzq.RowCount = 2;
            tableLayoutPanelIzq.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tableLayoutPanelIzq.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tableLayoutPanelIzq.Size = new Size(197, 200);
            tableLayoutPanelIzq.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelDescripcion, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(206, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Size = new Size(604, 200);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // labelDescripcion
            // 
            labelDescripcion.Dock = DockStyle.Fill;
            labelDescripcion.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(3, 50);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(598, 150);
            labelDescripcion.TabIndex = 3;
            labelDescripcion.Text = "DESCRIPCION";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(labelNombre, 0, 0);
            tableLayoutPanel4.Controls.Add(labelPrecio, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.ForeColor = Color.White;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(598, 44);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(472, 44);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "label1";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecio
            // 
            labelPrecio.Dock = DockStyle.Fill;
            labelPrecio.Font = new Font("Verdana", 12F);
            labelPrecio.Location = new Point(481, 0);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(114, 44);
            labelPrecio.TabIndex = 1;
            labelPrecio.Text = "label1";
            labelPrecio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserControlPanelProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlPanelProducto";
            Size = new Size(813, 206);
            Load += UserControlPanelProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanelIzq.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxProducto;
        private Button buttonAgregarCarrito;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelIzq;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelDescripcion;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelNombre;
        private Label labelPrecio;
    }
}
