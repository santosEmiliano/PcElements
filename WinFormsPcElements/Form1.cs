using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace WinFormsPcElements
{
    public partial class FormPortada : Form
    {

        // ------------------------------- ATRIBUTOS -------------------------------
        static public Users usuario;
        private bool exitMenu, optionsMenu; // VARIABLES PARA DETERMINAR SI LOS MENUS ESTAN DESPLEGADOS
        private bool theme;                 // TRUE = LIGHTMODE - FALSE = DARKMODE

        // ---------------------------- INICIALIZACIONES ---------------------------

        public FormPortada()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que surge al cargar el formulario. Dentro de este método se llaman a dos métodos
        /// principales: InitializeWindow() e InitializeComponents(). Aparte, se establece el focus
        /// del formulario en el buttonLogoPc, para que, sin mover el mouse, al presionar enter, o espacio
        /// simule el click del botón del logo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormPortada_Load(object sender, EventArgs e)
        {
            InitializeWindow();
            InitializeComponents();

            buttonLogoPc.Focus();
        }

        /// <summary>
        /// Este método maximiza la ventana, quita los bordes, y la superpone a todo el windows,
        /// de manera que simula estar en pantalla completa.
        /// </summary>

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Inicialización de los componentes del formulario. Este método manda a llamar a tres métodos
        /// principales: ComponentsLocation(), ComponentsSize() y ComponentsColor().
        /// Aparte, detiene los timers para que no se inicien conforme se abre el formulario.
        /// </summary>

        private void InitializeComponents()
        {
            timerExitMenu.Stop();
            timerOptionsMenu.Stop();

            ComponentsTheme();
            ComponentsSize();
            ComponentsLocation();
        }

        /// <summary>
        /// Método utilizado para manejar el AppTheme. Iguala cada control del formulario al color
        /// que le respecta según el tema de la aplicación. Cada que se cambia el tema entre claro y oscuro,
        /// se actualizan los valores del Apptheme, de manera que constantemente se llama a este método,
        /// modificando los controles al color que les respecta.
        /// </summary>

        private void ComponentsTheme()
        {
            // HEADER, FOOTER Y PANEL CENTRAL
            panelHeader.BackColor = AppTheme.header;
            panelFooter.BackColor = AppTheme.footer;
            panelCentral.BackColor = AppTheme.background;

            tableLayoutPanelInfo.BackgroundImage = AppTheme.backgroundInfo;

            // OPTIONS MENU
            panelOptionsMenu.BackColor = AppTheme.footer;

            // BUTTONS BACKCOLOR
            buttonAltTheme.BackColor = AppTheme.background;
            buttonHelp.BackColor = AppTheme.background;

            // BUTTONS FORECOLOR
            buttonAltTheme.ForeColor = AppTheme.font;
            buttonHelp.ForeColor = AppTheme.font;
            buttonIniciar.ForeColor = AppTheme.buttonsFont;

            // BUTTONS BACKGROUND IMAGE
            buttonAltOptionsMenu.BackgroundImage = AppTheme.settingsIcon;
            buttonInstagram.BackgroundImage = AppTheme.instagramIcon;
            buttonTwitter.BackgroundImage = AppTheme.twitterIcon;
            buttonYoutube.BackgroundImage = AppTheme.youtubeIcon;
            buttonIniciar.BackgroundImage = AppTheme.backgroundInfoInv;
            buttonTeamLogo.BackgroundImage = AppTheme.teamLogo;

            // BUTTONS IMAGE
            buttonHelp.Image = AppTheme.helpIcon;
            buttonAltTheme.Image = AppTheme.themeIcon;
            buttonAltTheme.Image = AppTheme.themeIcon;

            // LABELS
            labelTitulo.ForeColor = AppTheme.font;
            labelHora.ForeColor = AppTheme.font;
            labelLemaUaa.ForeColor = AppTheme.font;

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

        /// <summary>
        /// Método que adapta el tamaño de los controles del formulario a la resolución de la
        /// pantalla.
        /// </summary>

        private void ComponentsSize()
        {
            int height, width;
            float fontSize;

            // LOGO UAA
            height = flowLayoutPanelUaa.Height - 12;
            pictureBoxUaaLogo.Size = new Size(height, height);

            // LOGO PC<Elements>
            height = this.Width / 5;
            buttonLogoPc.Size = new Size(height, height);

            // EXIT MENU
            tableLayoutPanelExitMenu.Width = 0;
            height = buttonClose.Height;
            buttonClose.Size = new Size(height, height);
            buttonMinimize.Size = new Size(height, height);

            // SOCIAL MEDIA
            width = buttonInstagram.Height;
            buttonInstagram.Size = new Size(width, width);
            buttonYoutube.Size = new Size(width, width);
            buttonTwitter.Size = new Size(width, width);

            // TITULO
            fontSize = tableLayoutPanelInfo.Height / 8;
            labelTitulo.Font = new Font("Times New Roman", fontSize, FontStyle.Bold, GraphicsUnit.Point, 0);

            // BUTTON TEAM LOGO
            height = buttonTeamLogo.Height;
            buttonTeamLogo.Size = new Size(height, height);

            // OPTIONS MENU
            panelOptionsMenu.Width = 0;

        }

        /// <summary>
        /// Método que inicializa la localización de los controles del formulario.
        /// </summary>

        private void ComponentsLocation()
        {
            int x;
            int y;
            // LABEL HORA
            x = (this.Width / 2) - (labelHora.Width / 2);
            labelHora.Location = new Point(x, labelHora.Location.Y);

            //OPCIONS MENU
            y = (this.Height - panelOptionsMenu.Height - panelOptionsMenu.Height - 18);
            panelOptionsMenu.Location = new Point(0, y);

        }

        // ------------------------------- COMPONENTS -------------------------------

        /// <summary>
        /// Método que permite que al pasar el mouse encima del logo de la uaa, se despliegue su lema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pictureBoxUaaLogo_MouseHover(object sender, EventArgs e)
        {
            labelLemaUaa.Visible = true;
        }

        /// <summary>
        /// Método que oculta el lema de la uaa cuando el mouse deja de estar por encima del logo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pictureBoxUaaLogo_MouseLeave(object sender, EventArgs e)
        {
            labelLemaUaa.Visible = false;
        }

        /// <summary>
        /// Método que controla el despliegue y pliegue del menú de salida. Consulta el atributo
        /// booleano "exitMenu", y según su valor, cambia el ícono de la flecha para simular el despliegue
        /// o pliegue, e inicia el timer para la animación de los botones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// Maneja el click del botón "buttonMinimize", esto minimiza la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maneja el click del botón "buttonClose", esto termina la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Método que maneja el click del botón "buttonAltOptionsMenu", únicamente inicializa
        /// el timer del menú de opciones para desplegar o plegar el menú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAltOptionsMenu_Click(object sender, EventArgs e)
        {
            timerOptionsMenu.Start();
        }

        /// <summary>
        /// Método que maneja el click del botón "buttonAltTheme", consulta el valor del atributo
        /// "theme", y según su valor manda a llamar al método respectivo DarkMode() o LighrMode() del
        /// AppTheme. Después manda a llamar al método ComponentsColor() para realizar los cambios hechos
        /// en los colores de los controles del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAltTheme_Click(object sender, EventArgs e)
        {
            if (theme)
            {
                AppTheme.DarkMode();
                buttonAltTheme.Text = "Oscuro";
                theme = false;
            }
            else
            {
                AppTheme.LightMode();
                buttonAltTheme.Text = "Claro";
                theme = true;
            }

            ComponentsTheme();
        }

        /// <summary>
        /// Los siguientes tres métodos manejan la redirección al navegador predeterminado del sistema
        /// operativo, y abre los links a las redes sociales respectivas de la empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonInstagram_Click(object sender, EventArgs e)
        {
            string url = "www.instagram.com";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            WindowState = FormWindowState.Minimized;
        }

        private void buttonYoutube_Click(object sender, EventArgs e)
        {
            string url = "www.youtube.com";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            WindowState = FormWindowState.Minimized;
        }

        private void buttonTwitter_Click(object sender, EventArgs e)
        {
            string url = "www.twitter.com";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            WindowState = FormWindowState.Minimized;
        }

        // ------------------------------- ACCIONES -------------------------------





        // -------------------------------- TIMERS --------------------------------

        /// <summary>
        /// Según el valor del atributo "exitMenu", alterna entre plegar y desplegar el menu. Para ello,
        /// por cada tick del timer, aumenta o disminuye en 5 el ancho del panel, de manera que realiza la
        /// animación. Por otro lado, cuenta con condiciones de paro en caso de llegar al ancho deseado, en caso
        /// de ser así, el timer termina, y se invierte la variable "exitMenu" para que en la siguiente ocasión
        /// haga lo contrario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                if (tableLayoutPanelExitMenu.Width >= 140)
                {
                    timerExitMenu.Stop();
                    exitMenu = true;
                }
            }
        }

        /// <summary>
        /// Timer que, cada 1000 milisegundos (1 segundo), actualiza el labelHora, de manera que
        /// aparece la hora y fecha actual en el label. Aparte, vuelve a posicionar el texto al centro de la pantalla
        /// para que no se recorra al momento de mostrar otra hora y fecha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timerHora_Tick(object sender, EventArgs e)
        {
            int x;

            DateTime ahora = DateTime.Now;
            labelHora.Text = ahora.ToString();

            x = (this.Width / 2) - (labelHora.Width / 2);
            labelHora.Location = new Point(x, labelHora.Location.Y);
        }

        /// <summary>
        /// Timer que se inicia al presionar el buttonAltOptionsMenu, verifica el valor del atributo
        /// optionsMenu, según sea el caso, despliega o pliega el panel del menú de opciones aumentando
        /// o disminuyendo en 7 su ancho. En caso de llegar al tamaño necesario, el timer para, y 
        /// el atributo optionsMenu se invierta para que en la próxima ocasión se haga lo contrario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timerOptionsMenu_Tick(object sender, EventArgs e)
        {
            if (optionsMenu)
            {
                panelOptionsMenu.Width -= 7;
                if (panelOptionsMenu.Width <= 0)
                {
                    timerOptionsMenu.Stop();
                    optionsMenu = false;
                }
            }
            else
            {
                panelOptionsMenu.Width += 7;
                if (panelOptionsMenu.Width >= buttonAltOptionsMenu.Width)
                {
                    timerOptionsMenu.Stop();
                    optionsMenu = true;
                }
            }
        }

        // ----------------------------- REDIRECCIONES ----------------------------

        /// <summary>
        /// Botón que redirecciona al formulario del Log-In, aparte crea un formulario llamado Blackout
        /// para servir como fondo y poder simular una opacidad en la portada mientras el Log-In está de fondo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonLogoPc_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            Form blackout = new Form();

            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            blackout.Show();
            this.Opacity = .7;
            formLogIn.ShowDialog();
            blackout.Dispose();
            this.Show();
            this.Opacity = 1;
        }

        /// <summary>
        /// Botón que redirecciona al formulario del Log-In, aparte crea un formulario llamado Blackout
        /// para servir como fondo y poder simular una opacidad en la portada mientras el Log-In está de fondo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            Form blackout = new Form();

            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            blackout.Show();
            this.Opacity = .7;
            formLogIn.ShowDialog();
            blackout.Dispose();
            this.Opacity = 1;
        }

        /// <summary>
        /// Botón que redirecciona al formulario de los integrantes, aparte, instancia otro formulario
        /// que sirve como fondo para simular una opacidad en la portada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonTeamLogo_Click(object sender, EventArgs e)
        {
            FormIntegrantes formIntegrantes = new FormIntegrantes();
            Form blackout = new Form();

            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            blackout.Show();
            this.Opacity = .7;
            formIntegrantes.ShowDialog();
            blackout.Dispose();
            this.Opacity = 1;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAyuda formularioAyuda = new FormAyuda();
            Form blackout = new Form();

            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            blackout.Show();
            this.Opacity = .7;
            formularioAyuda.ShowDialog();
            blackout.Dispose();
            this.Show();
            this.Opacity = 1;
        }

    }
}