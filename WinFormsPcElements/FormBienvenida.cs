using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tsp;

namespace WinFormsPcElements
{
    public partial class FormBienvenida : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------

        private bool animacion;     // Atributo para la animacion de entrada y salida

        // ------------------------------- INICIALIZACIONES -------------------------------

        public FormBienvenida()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que, al cargar el formulario, manda a llamar al método InitializeWindow.
        /// Aparte, inicializa el labelBienvenida, de manera que le da la bienvenida al nombre del usuario.
        /// Inicia las animaciones de entrada del formulario, la animación de la barra de progreso, y
        /// el timer del cierre del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            InitializeWindow();
            ComponentsTheme();

            labelBienvenida.Text = $"Bienvenido {FormPortada.usuario.Name}";

            this.Left = this.Top + 15;
            animacion = true;
            timerAnimacion.Start();

            timerProgressBar.Start();

            timerCerrarFormulario.Start();
        }

        /// <summary>
        /// Método que quita los bordes de la ventana del formulario, y lo sobrepone por encima del sistema operativo
        /// </summary>

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BringToFront();
        }

        /// <summary>
        /// Método que inicializa el color del fondo según el tema de la aplicación.
        /// </summary>

        private void ComponentsTheme()
        {
            // Paneles principales
            tableLayoutPanelMain.BackgroundImage = AppTheme.backgroundInfo;
            panelFondo.BackColor = AppTheme.background;

            // Fuentes
            labelBienvenida.ForeColor = AppTheme.font;
            labelFinalizado.ForeColor = AppTheme.font;
            labelProgreso.ForeColor = AppTheme.font;
        }

        // ------------------------------- TIMERS -------------------------------

        /// <summary>
        /// Timer que ejecuta la animación de entrada o de salida del formulario dependiendo del
        /// atributo "animacion". Según su valor realiza una animación u otra.
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
                    this.Close();
                    timerAnimacion.Stop();

                }
                else
                {
                    this.Opacity -= .15;
                    this.Left += 3;
                }
            }
        }

        /// <summary>
        /// Timer que, cada 15 milisegundos aumenta en una unidad el progreso de la barra de progreso.
        /// Aparte, actualiza el labelProgreso para que en todo momento pueda verse el porcentaje de progreso.
        /// Al ejecutarse 100 veces el timer, se cumple su condición principal, y se muestra el labelFinalizado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarBienvenida.Increment(1);

            if (progressBarBienvenida.Value == 100)
            {
                labelFinalizado.Visible = true;
            }

            labelProgreso.Text = $"{Convert.ToString(progressBarBienvenida.Value)}%";
        }

        /// <summary>
        /// Timer que, al pasar tres segundos, invierte el atributo "animacion", de manera que, al iniciar
        /// el timerAnimacion, se ejecute la animación de salida del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timerCerrarFormulario_Tick(object sender, EventArgs e)
        {
            animacion = false;
            timerCerrarFormulario.Interval = 20;
            timerAnimacion.Start();
        }
    }
}
