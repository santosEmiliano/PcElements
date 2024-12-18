namespace WinFormsPcElements
{
    partial class UserControlAdminEstadisticas
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
            tableLayoutPanelMain = new TableLayoutPanel();
            formsPlotUsuarios = new ScottPlot.WinForms.FormsPlot();
            labelUsuarios = new Label();
            labelProductos = new Label();
            formsPlotProductos = new ScottPlot.WinForms.FormsPlot();
            panelFooter = new Panel();
            labelTotal = new Label();
            tableLayoutPanelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Controls.Add(formsPlotUsuarios, 1, 1);
            tableLayoutPanelMain.Controls.Add(labelUsuarios, 1, 0);
            tableLayoutPanelMain.Controls.Add(labelProductos, 0, 0);
            tableLayoutPanelMain.Controls.Add(formsPlotProductos, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.60932F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 79.39068F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanelMain.Size = new Size(870, 484);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // formsPlotUsuarios
            // 
            formsPlotUsuarios.Anchor = AnchorStyles.None;
            formsPlotUsuarios.DisplayScale = 1F;
            formsPlotUsuarios.Location = new Point(438, 111);
            formsPlotUsuarios.Name = "formsPlotUsuarios";
            formsPlotUsuarios.Size = new Size(429, 361);
            formsPlotUsuarios.TabIndex = 0;
            // 
            // labelUsuarios
            // 
            labelUsuarios.Dock = DockStyle.Bottom;
            labelUsuarios.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsuarios.Location = new Point(438, 45);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(429, 54);
            labelUsuarios.TabIndex = 3;
            labelUsuarios.Text = "Ventas Totales Por Usuario";
            labelUsuarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProductos
            // 
            labelProductos.Dock = DockStyle.Bottom;
            labelProductos.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProductos.Location = new Point(3, 45);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(429, 54);
            labelProductos.TabIndex = 2;
            labelProductos.Text = "Ventas Totales Por Producto";
            labelProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formsPlotProductos
            // 
            formsPlotProductos.Anchor = AnchorStyles.None;
            formsPlotProductos.DisplayScale = 1F;
            formsPlotProductos.Location = new Point(3, 111);
            formsPlotProductos.Name = "formsPlotProductos";
            formsPlotProductos.Size = new Size(429, 361);
            formsPlotProductos.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(labelTotal);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 484);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(870, 74);
            panelFooter.TabIndex = 1;
            // 
            // labelTotal
            // 
            labelTotal.Dock = DockStyle.Fill;
            labelTotal.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic);
            labelTotal.Location = new Point(0, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(870, 74);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "Ventas Totales De La Empresa: $";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlAdminEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelFooter);
            Name = "UserControlAdminEstadisticas";
            Size = new Size(870, 558);
            Load += UserControlAdminEstadisticas_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private ScottPlot.WinForms.FormsPlot formsPlotProductos;
        private Label labelUsuarios;
        private Label labelProductos;
        private ScottPlot.WinForms.FormsPlot formsPlotUsuarios;
        private Panel panelFooter;
        private Label labelTotal;
    }
}
