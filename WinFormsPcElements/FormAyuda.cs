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
    public partial class FormAyuda : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------
        private bool exitMenu;
        private bool animacion;

        // ------------------------------- INICIALIZACIONES -------------------------------
        public FormAyuda()
        {
            InitializeComponent();
            InitializeWindow();
        }

        /// <summary>
        /// Método que simula iniciar en pantalla completa el formulario.
        /// </summary>
        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BringToFront();
        }

        /// <summary>
        /// Método que, al cargar el formulario manda a llamar a dos métodos principales:
        /// y ComponentsTheme(). Aparte, Mueve el formulario 15 pixeles hacia 
        /// arriba e inicializa la animación de entrada del formulario,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAyuda_Load(object sender, EventArgs e)
        {
            InitializeComponents();

            this.Top = this.Top + 15;
            animacion = true;

            timerAnimacion.Start();
        }

        private void InitializeComponents()
        {
            timerExitMenu.Stop();

            ComponentsTheme();
            ComponentsSize();
        }

        private void ComponentsSize()
        {
            tableLayoutPanelExitMenu.Width = 0;
        }

        /// <summary>
        /// Establece los colores e imágenes de los componentes según el tema de la aplicación
        /// </summary>
        private void ComponentsTheme()
        {
            // Paneles principales
            this.BackColor = AppTheme.background;
            panelHeader.BackColor = AppTheme.header;

            exitMenu = true;

            if (exitMenu)
            {
                buttonAltExitMenu.BackgroundImage = AppTheme.arrowLeft;
                exitMenu = false;
            }
            else
            {
                buttonAltExitMenu.BackgroundImage = AppTheme.arrowRight;
                exitMenu = true;
            }
        }

        // ------------------------------- COMPONENTS -------------------------------



        private void buttonAltExitMenu_Click(object sender, EventArgs e)
        {
            if (exitMenu)
            {
                buttonAltExitMenu.BackgroundImage = AppTheme.arrowLeft;
            }
            else
            {
                buttonAltExitMenu.BackgroundImage = AppTheme.arrowRight;
            }

            timerExitMenu.Start();
        }

        /// <summary>
        /// Maneja el click del botón "buttonClose", esto termina la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Maneja el click del botón "buttonRegresar", esto regresa al form principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            pictureBoxAyuda.Image = Properties.Resources.FormPrincipalImage;
        }

        // ------------------------------- TIMERS -------------------------------

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

        private void timerExitMenu_Tick(object sender, EventArgs e)
        {
            if (exitMenu)
            {
                tableLayoutPanelExitMenu.Width -= 5;
                if (tableLayoutPanelExitMenu.Width <= 0)
                {
                    timerExitMenu.Stop();
                    exitMenu = false;
                }
            }
            else
            {
                tableLayoutPanelExitMenu.Width += 5;
                if (tableLayoutPanelExitMenu.Width >= 70)
                {
                    timerExitMenu.Stop();
                    exitMenu = true;
                }
            }
        }
    }
}
