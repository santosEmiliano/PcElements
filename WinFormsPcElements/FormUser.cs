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

    public partial class FormUser : Form
    {
        // -------------------------------- ATRIBUTOS --------------------------------
        private bool animacion;                     // Atributo para la animacion de entrada y salida
        // -------------------------------- INICIALIZACIONES --------------------------------
        public FormUser()
        {
            InitializeComponent();
            InitializeWindow();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            InitializeComponents();

            this.Top = this.Top + 15;
            animacion = true;
            timerAnimacion.Start();
        }

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void InitializeComponents()
        {
            if (FormPortada.usuario.Admin == false)
            {
                buttonAdmin.Enabled = false;
            }

            labelNombre.Text = FormPortada.usuario.Name;
            labelCuenta.Text = FormPortada.usuario.Account;

            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            panelHeader.BackColor = AppTheme.header;
            panelFooter.BackColor = AppTheme.footer;
            tableLayoutPanelMain.BackColor = AppTheme.background;

            // Buttons
            buttonAdmin.BackgroundImage = AppTheme.backgroundInfoInv;
            buttonAdmin.Image = AppTheme.bdIcon;
            buttonLogOut.BackgroundImage = AppTheme.backgroundInfoInv;

            pictureBoxUser.BackgroundImage = AppTheme.user;

            // Fuentes
            buttonAdmin.ForeColor = AppTheme.buttonsFont;
        }

        // -------------------------------- COMPONENTS --------------------------------
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormPortada.usuario = null;
            animacion = false;
            timerAnimacion.Start();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Dispose();
        }

        private void buttonRegreso_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        // -------------------------------- TIMERS --------------------------------
        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (animacion)
            {
                if (this.Opacity == 1)
                {
                    timerAnimacion.Stop();
                }
                else
                {
                    this.Opacity += .15;
                    this.Top += 3;
                }
            }
            else
            {
                if (this.Opacity == 0)
                {
                    this.Dispose();
                    timerAnimacion.Stop();
                }
                else
                {
                    this.Opacity -= .15;
                    this.Left += 3;
                }
            }
        }
    }
}
