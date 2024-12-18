using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public partial class FormIntegrantes : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------

        private bool animacion; //Atributo para la animacion de entrada y salida
        private bool exitMenu;

        // ---------------------------- INICIALIZACIONES ---------------------------

        public FormIntegrantes()
        {
            InitializeComponent();
            InitializeWindow();
        }

        /// <summary>
        /// Método que, al cargar el formulario manda a llamar a dos métodos principales:
        /// y ComponentsTheme(). Aparte, Mueve el formulario 15 pixeles hacia 
        /// arriba e inicializa la animación de entrada del formulario,
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormIntegrantes_Load(object sender, EventArgs e)
        {
            InitializeComponents();


            this.Top = this.Top + 15;
            animacion = true;

            timerAnimacion.Start();
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

        private void InitializeComponents()
        {
            timerExitMenu.Stop();
            ComponentsTheme();
        }
        /// <summary>
        /// Establece los colores e imágenes de los componentes según el tema de la aplicación
        /// </summary>

        private void ComponentsTheme()
        {
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

            panelHeader.BackColor = AppTheme.header;
            buttonAtras.BackgroundImage = AppTheme.arrowBack;
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
        /// Button para regresar al formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        // -------------------------------- TIMERS --------------------------------

        /// <summary>
        /// Timer que, dependiendo del atributo "animacion", hace la animación de entrada o salida
        /// del formulario. Cambia la opacidad y mueve el formulario de cierta manera para simular
        /// la aparición y desaparición de este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (animacion)
            {
                if (this.Opacity == 1)
                {
                    timerAnimacion.Stop();
                    panelCentral.BackgroundImage = Properties.Resources.membersBackground;
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
                    this.Top += 3;
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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
