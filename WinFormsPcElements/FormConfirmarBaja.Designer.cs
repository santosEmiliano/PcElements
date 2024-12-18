namespace WinFormsPcElements
{
    partial class FormConfirmarBaja
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
            tableLayoutPanelMain = new TableLayoutPanel();
            labelSeguro = new Label();
            tableLayoutPanelButtons = new TableLayoutPanel();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(labelSeguro, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelButtons, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(10, 10);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(549, 251);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelSeguro
            // 
            labelSeguro.Dock = DockStyle.Fill;
            labelSeguro.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic);
            labelSeguro.Location = new Point(3, 0);
            labelSeguro.Name = "labelSeguro";
            labelSeguro.Size = new Size(543, 125);
            labelSeguro.TabIndex = 0;
            labelSeguro.Text = "¿Seguro que deseas realizar la baja?";
            labelSeguro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(buttonCancelar, 1, 0);
            tableLayoutPanelButtons.Controls.Add(buttonConfirmar, 0, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(3, 128);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Size = new Size(543, 120);
            tableLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BackgroundImage = Properties.Resources.BackgroundInfoLM;
            buttonCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(338, 30);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(138, 59);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Anchor = AnchorStyles.None;
            buttonConfirmar.BackgroundImage = Properties.Resources.BackgroundInfoLM;
            buttonConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonConfirmar.Cursor = Cursors.Hand;
            buttonConfirmar.FlatAppearance.BorderSize = 0;
            buttonConfirmar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonConfirmar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonConfirmar.FlatStyle = FlatStyle.Flat;
            buttonConfirmar.Location = new Point(66, 30);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(138, 59);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "CONFIRMAR";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // FormConfirmarBaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 271);
            Controls.Add(tableLayoutPanelMain);
            Name = "FormConfirmarBaja";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmarBaja";
            TopMost = true;
            Load += FormConfirmarBaja_Load;
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private Label labelSeguro;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button buttonConfirmar;
        private Button buttonCancelar;
    }
}