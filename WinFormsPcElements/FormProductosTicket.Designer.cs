namespace WinFormsPcElements
{
    partial class FormProductosTicket
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
            dGVProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGVProductos).BeginInit();
            SuspendLayout();
            // 
            // dGVProductos
            // 
            dGVProductos.BackgroundColor = Color.White;
            dGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVProductos.Location = new Point(42, 17);
            dGVProductos.Margin = new Padding(3, 2, 3, 2);
            dGVProductos.Name = "dGVProductos";
            dGVProductos.RowHeadersWidth = 51;
            dGVProductos.Size = new Size(600, 214);
            dGVProductos.TabIndex = 1;
            // 
            // FormProductosTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 68, 103);
            ClientSize = new Size(700, 338);
            Controls.Add(dGVProductos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProductosTicket";
            Text = "FormProductosTicket";
            Load += FormProductosTicket_Load;
            ((System.ComponentModel.ISupportInitialize)dGVProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dGVProductos;
    }
}