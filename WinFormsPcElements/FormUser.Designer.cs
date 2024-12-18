namespace WinFormsPcElements
{
    partial class FormUser
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
            buttonRegreso = new Button();
            panelFooter = new Panel();
            buttonLogOut = new Button();
            buttonAdmin = new Button();
            labelCuenta = new Label();
            tableLayoutPanelMain = new TableLayoutPanel();
            labelNombre = new Label();
            pictureBoxUser = new PictureBox();
            timerAnimacion = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(buttonRegreso);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(790, 57);
            panelHeader.TabIndex = 0;
            // 
            // buttonRegreso
            // 
            buttonRegreso.BackgroundImage = Properties.Resources.arrow_backDM;
            buttonRegreso.BackgroundImageLayout = ImageLayout.Center;
            buttonRegreso.Dock = DockStyle.Left;
            buttonRegreso.FlatAppearance.BorderSize = 0;
            buttonRegreso.FlatStyle = FlatStyle.Flat;
            buttonRegreso.Location = new Point(0, 0);
            buttonRegreso.Name = "buttonRegreso";
            buttonRegreso.Size = new Size(63, 57);
            buttonRegreso.TabIndex = 1;
            buttonRegreso.UseVisualStyleBackColor = true;
            buttonRegreso.Click += buttonRegreso_Click;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(buttonLogOut);
            panelFooter.Controls.Add(buttonAdmin);
            panelFooter.Controls.Add(labelCuenta);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 378);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(790, 71);
            panelFooter.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Transparent;
            buttonLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Right;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonLogOut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Image = Properties.Resources.Log_outDM;
            buttonLogOut.Location = new Point(691, 0);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(99, 71);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.Transparent;
            buttonAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdmin.Cursor = Cursors.Hand;
            buttonAdmin.Dock = DockStyle.Left;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Image = Properties.Resources.bdIconDM;
            buttonAdmin.Location = new Point(0, 0);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Padding = new Padding(0, 10, 0, 10);
            buttonAdmin.Size = new Size(125, 71);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "ADMIN";
            buttonAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // labelCuenta
            // 
            labelCuenta.Dock = DockStyle.Fill;
            labelCuenta.Font = new Font("Times New Roman", 24F, FontStyle.Italic);
            labelCuenta.ForeColor = Color.White;
            labelCuenta.Location = new Point(0, 0);
            labelCuenta.Name = "labelCuenta";
            labelCuenta.Size = new Size(790, 71);
            labelCuenta.TabIndex = 2;
            labelCuenta.Text = "Account_";
            labelCuenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(labelNombre, 0, 1);
            tableLayoutPanelMain.Controls.Add(pictureBoxUser, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 57);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 69.4704056F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5295944F));
            tableLayoutPanelMain.Size = new Size(790, 321);
            tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.Dock = DockStyle.Top;
            labelNombre.Font = new Font("Times New Roman", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(3, 223);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(784, 63);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Name_";
            labelNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Anchor = AnchorStyles.None;
            pictureBoxUser.BackgroundImage = Properties.Resources.UserDM;
            pictureBoxUser.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxUser.Location = new Point(310, 34);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(170, 154);
            pictureBoxUser.TabIndex = 0;
            pictureBoxUser.TabStop = false;
            // 
            // timerAnimacion
            // 
            timerAnimacion.Enabled = true;
            timerAnimacion.Interval = 20;
            timerAnimacion.Tick += timerAnimacion_Tick;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 104, 84);
            ClientSize = new Size(790, 449);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUser";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUser";
            Load += FormUser_Load;
            panelHeader.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonRegreso;
        private Panel panelFooter;
        private TableLayoutPanel tableLayoutPanelMain;
        private PictureBox pictureBoxUser;
        private Label labelCuenta;
        private Button buttonLogOut;
        private Button buttonAdmin;
        private Label labelNombre;
        private System.Windows.Forms.Timer timerAnimacion;
    }
}