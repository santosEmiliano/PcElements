namespace WinFormsPcElements
{
    partial class UserControlAdminMod
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
            panelHeader = new Panel();
            labelTitulo = new Label();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelTextBox = new TableLayoutPanel();
            tableLayoutPanelId = new TableLayoutPanel();
            labelId = new Label();
            numericUpDownId = new NumericUpDown();
            tableLayoutPanelNombre = new TableLayoutPanel();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            buttonDarBaja = new Button();
            panelListaProductos = new Panel();
            panelHeader.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelTextBox.SuspendLayout();
            tableLayoutPanelId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            tableLayoutPanelNombre.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(931, 75);
            panelHeader.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.Dock = DockStyle.Fill;
            labelTitulo.Location = new Point(0, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(931, 75);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "BAJAS DE PRODUCTOS";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelTextBox, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonDarBaja, 0, 1);
            tableLayoutPanelMain.Controls.Add(panelListaProductos, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 75);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5813446F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 62.4728851F));
            tableLayoutPanelMain.Size = new Size(931, 461);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanelTextBox
            // 
            tableLayoutPanelTextBox.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanelTextBox.ColumnCount = 2;
            tableLayoutPanelTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.Controls.Add(tableLayoutPanelId, 1, 0);
            tableLayoutPanelTextBox.Controls.Add(tableLayoutPanelNombre, 0, 0);
            tableLayoutPanelTextBox.Dock = DockStyle.Fill;
            tableLayoutPanelTextBox.Location = new Point(3, 3);
            tableLayoutPanelTextBox.Name = "tableLayoutPanelTextBox";
            tableLayoutPanelTextBox.RowCount = 1;
            tableLayoutPanelTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTextBox.Size = new Size(925, 109);
            tableLayoutPanelTextBox.TabIndex = 0;
            // 
            // tableLayoutPanelId
            // 
            tableLayoutPanelId.ColumnCount = 1;
            tableLayoutPanelId.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelId.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelId.Controls.Add(labelId, 0, 0);
            tableLayoutPanelId.Controls.Add(numericUpDownId, 0, 1);
            tableLayoutPanelId.Dock = DockStyle.Fill;
            tableLayoutPanelId.Location = new Point(466, 5);
            tableLayoutPanelId.Name = "tableLayoutPanelId";
            tableLayoutPanelId.RowCount = 2;
            tableLayoutPanelId.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelId.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelId.Size = new Size(454, 99);
            tableLayoutPanelId.TabIndex = 2;
            // 
            // labelId
            // 
            labelId.Dock = DockStyle.Fill;
            labelId.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelId.Location = new Point(3, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(448, 49);
            labelId.TabIndex = 1;
            labelId.Text = "ELIMINAR POR ID";
            labelId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Dock = DockStyle.Fill;
            numericUpDownId.Location = new Point(3, 52);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(448, 23);
            numericUpDownId.TabIndex = 2;
            // 
            // tableLayoutPanelNombre
            // 
            tableLayoutPanelNombre.ColumnCount = 1;
            tableLayoutPanelNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelNombre.Controls.Add(labelNombre, 0, 0);
            tableLayoutPanelNombre.Controls.Add(textBoxNombre, 0, 1);
            tableLayoutPanelNombre.Dock = DockStyle.Fill;
            tableLayoutPanelNombre.Location = new Point(5, 5);
            tableLayoutPanelNombre.Name = "tableLayoutPanelNombre";
            tableLayoutPanelNombre.RowCount = 2;
            tableLayoutPanelNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelNombre.Size = new Size(453, 99);
            tableLayoutPanelNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Fill;
            labelNombre.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(447, 49);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "BUSCAR POR NOMBRE";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Dock = DockStyle.Fill;
            textBoxNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(3, 52);
            textBoxNombre.Multiline = true;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(447, 44);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // buttonDarBaja
            // 
            buttonDarBaja.Anchor = AnchorStyles.None;
            buttonDarBaja.BackColor = Color.Transparent;
            buttonDarBaja.FlatAppearance.BorderSize = 0;
            buttonDarBaja.FlatStyle = FlatStyle.Flat;
            buttonDarBaja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDarBaja.Image = Properties.Resources.deleteDM;
            buttonDarBaja.ImageAlign = ContentAlignment.MiddleRight;
            buttonDarBaja.Location = new Point(385, 120);
            buttonDarBaja.Name = "buttonDarBaja";
            buttonDarBaja.Size = new Size(161, 46);
            buttonDarBaja.TabIndex = 0;
            buttonDarBaja.Text = "DAR DE BAJA";
            buttonDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDarBaja.UseVisualStyleBackColor = false;
            buttonDarBaja.Click += buttonDarBaja_Click;
            // 
            // panelListaProductos
            // 
            panelListaProductos.Dock = DockStyle.Fill;
            panelListaProductos.Location = new Point(3, 175);
            panelListaProductos.Name = "panelListaProductos";
            panelListaProductos.Size = new Size(925, 283);
            panelListaProductos.TabIndex = 1;
            // 
            // UserControlAdminMod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelHeader);
            Name = "UserControlAdminMod";
            Size = new Size(931, 536);
            Load += UserControlAdminMod_Load;
            panelHeader.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelTextBox.ResumeLayout(false);
            tableLayoutPanelId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            tableLayoutPanelNombre.ResumeLayout(false);
            tableLayoutPanelNombre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitulo;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelTextBox;
        private Button buttonDarBaja;
        private TableLayoutPanel tableLayoutPanelNombre;
        private Label labelNombre;
        private TableLayoutPanel tableLayoutPanelId;
        private Label labelId;
        private NumericUpDown numericUpDownId;
        private TextBox textBoxNombre;
        private Panel panelListaProductos;
    }
}
