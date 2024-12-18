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
    public partial class FormPassword : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------

        bool animacion;                     // Atributo para la animacion de entrada y salida
        bool showPassword = false;          // Atributo para la mostrar la contraseña 
        static public bool validacion;      // Atributo para determinar si la contraseña es correcta

        // ---------------------------- INICIALIZACIONES ---------------------------

        public FormPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que, al cargar el formulario manda a llamar a los métodos InitializeWindow y ComponentsColor().
        /// Aparte, desplaza el formulario a la izquierda para iniciar el timerAnimación para la animación de 
        /// entrada del formulario.
        /// El labelUser se inicializa con el nombre del usuario que se recibió en el constructor, y se establece
        /// el focus del formulario en el textBoxPassword.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormPassword_Load(object sender, EventArgs e)
        {
            InitializeWindow();
            ComponentsTheme();

            //TRANSICION PARA ENTRAR AL FORMULARIO
            this.Left = this.Left + 15;
            animacion = true;
            timerAnimacion.Start();

            textBoxPassword.Focus();
        }

        /// <summary>
        /// Método que elimina los bordes de la ventana, y la sobrepone por encima de todo el sistema operativo
        /// </summary>

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BringToFront();
        }

        /// <summary>
        /// Método que establece los controles según el tema de la aplicación
        /// </summary>

        private void ComponentsTheme()
        {
            // Paneles principales
            panelCentral.BackColor = AppTheme.background;
            panelHeader.BackColor = AppTheme.header;
            panelPassword.BackgroundImage = AppTheme.backgroundInfo;

            // Botones - textbox
            textBoxPassword.BackColor = AppTheme.textBox;
            buttonContinue.ForeColor = AppTheme.buttonsFont;
            buttonContinue.BackgroundImage = AppTheme.backgroundInfoInv;
            buttonShowPassword.BackgroundImage = AppTheme.passwordEyeC;

            // Fuentes
            labelBy.ForeColor = AppTheme.font;
            labelUser.ForeColor = AppTheme.font;
            textBoxPassword.ForeColor = AppTheme.font;

            // PictureBox
            pictureBoxLogoTeam.BackgroundImage = AppTheme.teamLogo;
        }

        // ------------------------------- COMPONENTS -------------------------------

        /// <summary>
        /// Método que determina si se presiona el buttonRegresar.
        /// se inicia la animación de salida del formulario, y la validación se vuelve falsa, para que el
        /// formulario del LogIn no se cierre e inicie el formulario de la tienda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            animacion = false;
            validacion = false;
            timerAnimacion.Start();
        }

        /// <summary>
        /// Método que determina si se presionó el buttonSalir, en caso de ser así, se cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Método que determina si se presiona la tecla enter, en caso de ser así, se manda a llamar al método
        /// buttonContinue_Click, para simular que se dio click en el botón de continuar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonContinue_Click(sender, e);
            }
        }

        /// <summary>
        /// Método que determina si se presionó el buttonShowPassword, en caso de ser así, se invierte
        /// el atributo showPassword, y dependiendo de su nuevo valor, muestra, o no, la contraseña.
        /// Este método muestra la contraseña como la escribe el usuario, o, por lo contrario, muestra puros
        /// "*******". 
        /// Al mismo tiempo, cambia la imágen del ojo, dependiendo de si se puede, o no, ver la contraseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                buttonShowPassword.BackgroundImage = AppTheme.passwordEyeO;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                buttonShowPassword.BackgroundImage = AppTheme.passwordEyeC;
            }

        }

        // -------------------------------- TIMERS --------------------------------

        /// <summary>
        /// Timer que, según el valor del atributo "animacion", realiza la animación de entrada o de
        /// salida del formulario.
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
                    this.Left += 3;
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
        /// Método que determina si la contraseña ingresada en el textBoxPassword es igual que la contraseña
        /// almacenada en la tabla de usuarios. En caso de estar correcta la contraseña, se instancia el formulario
        /// de bienvenida, y, al regresar a esta parte del código, se inicia la animación de salida del formulario,
        /// y la validación se hace true, de manera que el formulario del LogIn puede cerrarse para abrir el de la tienda.
        /// En caso de que la contraseña sea incorrecta, se muestra un mensaje de "Acceso Denegado", y se reinicia
        /// el texto del textBoxPassword.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void buttonContinue_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == FormPortada.usuario.Password)
            {
                FormBienvenida formularioBienvenida = new FormBienvenida();
                formularioBienvenida.ShowDialog();
                animacion = false;
                validacion = true;
                timerAnimacion.Start();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
                textBoxPassword.Text = "";
            }
        }
    }
}
