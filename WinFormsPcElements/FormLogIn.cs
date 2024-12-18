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

namespace WinFormsPcElements
{
    public partial class FormLogIn : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------
        bool animacion;                     // Atributo para la animacion de entrada y salida
        static public bool validacion;      // Atributo para validar si se cierra o no el form

        // ---------------------------- INICIALIZACIONES ---------------------------

        public FormLogIn()
        {
            InitializeComponent();
            InitializeWindow();
        }

        /// <summary>
        /// Método que, al cargar el formulario, llama a otros dos métodos principales:
        /// InitializeWindow() y ComponentsColor().
        /// Aparte, realiza la animación de entrada del formulario y establece el focus del formulario
        /// en la caja de texto donde se escribe la cuenta. De esta manera, el cargar el formulario, directamente
        /// se podrá escribir sobre esta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormLogIn_Load(object sender, EventArgs e)
        {

            this.Top = this.Top + 15;
            animacion = true;
            timerAnimacion.Start();

            ComponentsTheme();
        }

        /// <summary>
        /// Método que quita el borde de la ventana, la trae al frente y la pone sobre cualquier 
        /// otra cosa en el sistema
        /// </summary>

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BringToFront();
        }

        /// <summary>
        /// Método que inicializa los colores de los componentes según el tema de la aplicación
        /// </summary>

        private void ComponentsTheme()
        {
            // Paneles principales
            panelCentral.BackColor = AppTheme.background;
            panelHeader.BackColor = AppTheme.background;
            panelUser.BackgroundImage = AppTheme.backgroundInfo;

            // Botones - textbox
            textBoxUser.BackColor = AppTheme.textBox;
            buttonRegresar.BackgroundImage = AppTheme.arrowBack;
            buttonContinuar.ForeColor = AppTheme.buttonsFont;
            buttonContinuar.BackgroundImage = AppTheme.backgroundInfoInv;

            // Fuentes
            textBoxUser.ForeColor = AppTheme.font;
        }

        // ------------------------------- COMPONENTS -------------------------------

        /// <summary>
        /// Método que sirve para regresar al formulario principal, inicia la animación
        /// de salida del formLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        /// <summary>
        /// En caso de presionar el buttonSalir, se cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Método que determina si se presiona la tecla enter al momento de escribir en el textBox del 
        /// usuario. Al presionar la tecla enter, se manda a llamar al método buttonContinuar_Click(),
        /// que simula haber dado click al botón de continuar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonContinuar_Click(sender, e);
            }
        }

        // -------------------------------- TIMERS --------------------------------

        /// <summary>
        /// Timer que inicia la animación de entrada y de salida del formulario. Según el atributo
        /// "animacion", se determina si se realiza la animación de entrada o de salida.
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
                    textBoxUser.Focus();
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

        // ----------------------------- REDIRECCIONES ----------------------------

        /// <summary>
        /// Método que crea una instancia de la clase AdminBD, mediante esta instancia se realiza una petición
        /// a la base de datos de usuarios, en caso de que la petición retornara un valor nulo, se
        /// muestra el mensaje de que no se encontró el usuario en la tabla, de otra manera, crea una instancia
        /// del formulario en el que se introduce la contraseña, se reinicia el textBoxUser y, en caso de que
        /// el formulario de la contraseña retorne una validación correcta, se inicia la animación de cierre de este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text;
            AdminBD data = new AdminBD();
            Users usuario;

            usuario = data.PeticionUsuario(user);
            FormPortada.usuario = usuario;

            if (usuario == null)
            {
                MessageBox.Show("No se encontró el usuario, vuelve a intentar");
                textBoxUser.Text = "";
                textBoxUser.PlaceholderText = "USER";
            }
            else
            {
                FormPassword formularioPassword = new FormPassword();
                this.Opacity = .7;
                formularioPassword.ShowDialog();
                this.Opacity = 1;
                textBoxUser.Text = "";
                validacion = FormPassword.validacion;

                if (validacion)
                {
                    animacion = false;
                    timerAnimacion.Start();

                    FormTienda formularioTienda = new FormTienda();
                    formularioTienda.ShowDialog();
                }
            }
        }
    }
}
