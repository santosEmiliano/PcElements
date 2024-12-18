using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public partial class FormConfirmarBaja : Form
    {
        public FormConfirmarBaja()
        {
            InitializeComponent();
        }

        private void FormConfirmarBaja_Load(object sender, EventArgs e)
        {
            InitializeWindow();
            InitializeComponents();
        }

        private void InitializeWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
        }

        private void InitializeComponents()
        {
            // Paneles principales
            this.BackColor = AppTheme.header;
            tableLayoutPanelMain.BackColor = AppTheme.background;

            // Fuentes
            buttonConfirmar.ForeColor = AppTheme.buttonsFont;
            buttonCancelar.ForeColor = AppTheme.buttonsFont;
            labelSeguro.ForeColor = AppTheme.font;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            UserControlAdminMod.baja = true;
            this.Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            UserControlAdminMod.baja = false;
            this.Dispose();
        }
    }
}
