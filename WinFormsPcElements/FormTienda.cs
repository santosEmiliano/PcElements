using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsPcElements
{
    public partial class FormTienda : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------

        public static List<Producto> carrito = new List<Producto>();
        public static List<Producto> catalogo = new List<Producto>();
        private List<Producto> catalogoCompleto; //Lista auxiliar para guardar el valor maximo del producto
        public static List<Producto> prodStock;

        public static bool act;

        private bool animacion;         //Atributo para la animacion de entrada y salida
        private bool sideBarExpand;
        private bool comprarExpand;
        private bool exitMenu;
        private double maxValor;

        public static string filtro = "";
        public static string filtroGama = "";

        private bool[] filtroGamaIndex = new bool[3];


        // ---------------------------- INICIALIZACIONES ---------------------------

        public FormTienda()
        {
            InitializeComponent();
            InitializeWindow();
        }


        /// <summary>
        /// Método que manda a llamar al método InitializeWindow, e inicia la animación de entrada del
        /// formulario.
        /// Inicializamos el metodo ComponetsSize()
        /// Inicializamos el metodo ComponetsLocation()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void FormTienda_Load(object sender, EventArgs e)
        {
            InitializeComponents();

            this.Left = this.Top + 15;
            animacion = true;
            timerAnimacion.Start();
            timerExitMenu.Stop();
            timerComprar.Stop();
            timerSideBar.Stop();

            prodStock = null;
        }

        /// <summary>
        /// Método que elimina el borde de la ventana, y la superpone encima de todo el sistema operativo
        /// </summary>

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
            ComponentsSize();
            ComponentsLocation();
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            panelMain.BackColor = AppTheme.background;
            panelHeader.BackColor = AppTheme.header;
            flowLayoutPanelSideBar.BackColor = AppTheme.sideBar;

            // Componentes
            trackBarPrecio.BackColor = AppTheme.sideBar;
            buttonPagar.BackColor = AppTheme.paleta[3];

            // Fuentes
            buttonArmarPc.ForeColor = AppTheme.font;
            buttonComprar.ForeColor = AppTheme.font;
            buttonPagar.ForeColor = AppTheme.buttonsFont;
            labelLema.ForeColor = AppTheme.font;

            buttonMotherBoard.ForeColor = AppTheme.font;
            buttonRAM.ForeColor = AppTheme.font;
            buttonGrafica.ForeColor = AppTheme.font;
            buttonProcesador.ForeColor = AppTheme.font;
            buttonFuente.ForeColor = AppTheme.font;

            labelFiltros.ForeColor = AppTheme.font;
            labelGama.ForeColor = AppTheme.font;
            labelPrecio.ForeColor = AppTheme.font;
            labelHora.ForeColor = AppTheme.font;

            checkBoxGamaAlta.ForeColor = AppTheme.font;
            checkBoxGamaMedia.ForeColor = AppTheme.font;
            checkBoxGamaBaja.ForeColor = AppTheme.font;

            // Botones
            buttonPagar.BackColor = AppTheme.button;
        }

        /// <summary>
        /// Método que adapta el tamaño de los controles del formulario a la resolución de la
        /// pantalla.
        /// </summary>

        private void ComponentsSize()
        {
            int Width = 0;
            int Height = 0;

            //EXITMENU
            tableLayoutPanelExitMenu.Width = Width;

            //FLOW LYOUT PANEL SIDE BAR
            Width = buttonMenu.Width;
            flowLayoutPanelSideBar.Width = Width;

            // FLOW LAYOUT PANEL COMPRAR
            Height = 81;
            flowLayoutPanelComprar.Height = Height;

            Width = 65;

            //BOTON MOTHER BOARD
            buttonMotherBoard.Width = Width;
            buttonMotherBoard.Text = "";

            //BOTON PROCESADOR
            buttonProcesador.Width = Width;
            buttonProcesador.Text = "";

            //BOTON TARJETA GRAFICA
            buttonGrafica.Width = Width;
            buttonGrafica.Text = "";

            //BOTON FUENTE DE PODER
            buttonFuente.Width = Width;
            buttonFuente.Text = "";

            //BOTON MEMORIA RAM
            buttonRAM.Width = Width;
            buttonRAM.Text = "";
        }

        private void ComponentsLocation()
        {

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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

            timerSideBar.Start();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            timerComprar.Start();

            if (!comprarExpand)
            {
                buttonMenu.Enabled = false;

                buttonMotherBoard.Enabled = true;
                buttonRAM.Enabled = true;
                buttonFuente.Enabled = true;
                buttonGrafica.Enabled = true;
                buttonProcesador.Enabled = true;

                filtro = "";
                filtroGama = "";
                AdminBDProductos.maxPrecio = 99999999;

                ActualizarCatalogo(false);

                maxValor = catalogoCompleto.Max(p => p.Precio);
                trackBarPrecio_ValueChanged(sender, e);
            }
            else
            {
                buttonMenu.Enabled = true;

                buttonMotherBoard.BackColor = AppTheme.header;
                buttonGrafica.BackColor = AppTheme.header;
                buttonProcesador.BackColor = AppTheme.header;
                buttonFuente.BackColor = AppTheme.header;
                buttonRAM.BackColor = AppTheme.header;

                buttonMotherBoard.Enabled = false;
                buttonRAM.Enabled = false;
                buttonFuente.Enabled = false;
                buttonGrafica.Enabled = false;
                buttonProcesador.Enabled = false;

                ActualizarCatalogo(true);
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            FormUser formularioUser = new FormUser();
            Form blackout = new Form();

            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            formularioUser.ShowDialog();
            if (FormPortada.usuario == null)
            {
                animacion = false;
                timerAnimacion.Start();
            }
            else
            {
                animacion = true;
                timerAnimacion.Start();
            }
        }

        //Presionar botones
        private void buttonMotherBoard_Click(object sender, EventArgs e)
        {
            buttonRAM.BackColor = AppTheme.header;
            buttonGrafica.BackColor = AppTheme.header;
            buttonProcesador.BackColor = AppTheme.header;
            buttonFuente.BackColor = AppTheme.header;

            if (filtro == "AND tipo=0")
            {
                buttonMotherBoard.BackColor = AppTheme.header;
                filtro = "";
            }
            else
            {
                buttonMotherBoard.BackColor = AppTheme.background;
                filtro = "AND tipo=0";
            }

            AdminBDProductos.query = filtro;
            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void buttonProcesador_Click(object sender, EventArgs e)
        {
            buttonMotherBoard.BackColor = AppTheme.header;
            buttonRAM.BackColor = AppTheme.header;
            buttonGrafica.BackColor = AppTheme.header;
            buttonFuente.BackColor = AppTheme.header;

            if (filtro == "AND tipo=1")
            {
                buttonProcesador.BackColor = AppTheme.header;
                filtro = "";
            }
            else
            {
                buttonProcesador.BackColor = AppTheme.background;
                filtro = "AND tipo=1";
            }

            AdminBDProductos.query = filtro;
            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void buttonGrafica_Click(object sender, EventArgs e)
        {
            buttonMotherBoard.BackColor = AppTheme.header;
            buttonRAM.BackColor = AppTheme.header;
            buttonProcesador.BackColor = AppTheme.header;
            buttonFuente.BackColor = AppTheme.header;

            if (filtro == "AND tipo=2")
            {
                buttonGrafica.BackColor = AppTheme.header;
                filtro = "";
            }
            else
            {
                buttonGrafica.BackColor = AppTheme.background;
                filtro = "AND tipo=2";
            }

            AdminBDProductos.query = filtro;
            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void buttonFuente_Click(object sender, EventArgs e)
        {
            buttonMotherBoard.BackColor = AppTheme.header;
            buttonRAM.BackColor = AppTheme.header;
            buttonGrafica.BackColor = AppTheme.header;
            buttonProcesador.BackColor = AppTheme.header;

            if (filtro == "AND tipo=3")
            {
                buttonFuente.BackColor = AppTheme.header;
                filtro = "";
            }
            else
            {
                buttonFuente.BackColor = AppTheme.background;
                filtro = "AND tipo=3";
            }

            AdminBDProductos.query = filtro;
            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void buttonRAM_Click(object sender, EventArgs e)
        {
            buttonMotherBoard.BackColor = AppTheme.header;
            buttonGrafica.BackColor = AppTheme.header;
            buttonProcesador.BackColor = AppTheme.header;
            buttonFuente.BackColor = AppTheme.header;

            if (filtro == "AND tipo=4")
            {
                buttonRAM.BackColor = AppTheme.header;
                filtro = "";
            }
            else
            {
                buttonRAM.BackColor = AppTheme.background;
                filtro = "AND tipo=4";
            }

            AdminBDProductos.query = filtro;
            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            FormPagar formularioPagar = new FormPagar();

            Form blackout = new Form();
            blackout.BackColor = Color.Black;
            blackout.WindowState = FormWindowState.Maximized;
            blackout.FormBorderStyle = FormBorderStyle.None;

            formularioPagar.ShowDialog();

            if (carrito.Count == 0 && comprarExpand == true)
            {
                prodStock = null;
                ActualizarCatalogo(true);

                buttonMotherBoard.BackColor = AppTheme.header;
                buttonGrafica.BackColor = AppTheme.header;
                buttonProcesador.BackColor = AppTheme.header;
                buttonFuente.BackColor = AppTheme.header;
                buttonRAM.BackColor = AppTheme.header;

                timerComprar.Start();
            }

            this.Show();
        }


        // ------------------------------- ACCIONES -------------------------------

        public void ActualizarCatalogo(bool limpiar)
        {
            if (limpiar)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(tableLayoutPanelHome);

                return;
            }

            bool agotado = false;

            panelMain.Controls.Clear();

            Panel panelCatalogo = new Panel();
            panelCatalogo.Dock = DockStyle.Fill;
            panelCatalogo.Visible = false;

            AdminBDProductos bd = new AdminBDProductos();

            List<Producto> productos = bd.PeticionProductos();

            if (catalogoCompleto == null)
            {
                catalogoCompleto = new List<Producto>(productos);
            }

            catalogo = productos;

            productos.ForEach(p =>
            {

                if (p.Stock == 0 || FormPortada.usuario.Admin == true)
                {
                    agotado = true;
                }
                else
                {
                    agotado = false;
                }

                Panel separacion = new Panel();
                separacion.Dock = DockStyle.Top;
                separacion.Height = 20;

                UserControlPanelProducto panel = new UserControlPanelProducto(p, true, true, false, true, agotado, this);
                panel.Dock = DockStyle.Top;


                panelCatalogo.Controls.Add(separacion);
                panelCatalogo.Controls.Add(panel);
            });

            panelMain.Controls.Add(panelCatalogo);
            panelCatalogo.Visible = true;
            panelCatalogo.AutoScroll = true;

            if (prodStock == null)
            {
                prodStock = productos;
                prodStock = prodStock.OrderBy(x => x.Id).ToList();
            }
        }

        private void checkBoxGamaAlta_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxGamaAlta.Checked)
            {
                filtroGamaIndex[0] = true;
            }
            else if (!checkBoxGamaAlta.Checked)
            {
                filtroGamaIndex[0] = false;
            }
            filtroGamaMetodo();
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void checkBoxGamaMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGamaMedia.Checked == true)
            {
                filtroGamaIndex[1] = true;
            }
            else if (!checkBoxGamaMedia.Checked)
            {
                filtroGamaIndex[1] = false;
            }
            filtroGamaMetodo();
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void checkBoxGamaBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGamaBaja.Checked == true)
            {
                filtroGamaIndex[2] = true;
            }
            else if (!checkBoxGamaBaja.Checked)
            {
                filtroGamaIndex[2] = false;
            }
            filtroGamaMetodo();
            trackBarPrecio.Value = 5;
            trackBarPrecio_ValueChanged(sender, e);
        }

        private void filtroGamaMetodo()
        {

            if (filtroGamaIndex[0] && filtroGamaIndex[1] && filtroGamaIndex[2])
            {
                filtroGama = "";
            }
            else if (!filtroGamaIndex[0] && !filtroGamaIndex[1] && !filtroGamaIndex[2])
            {
                filtroGama = "";
            }
            else if (filtroGamaIndex[0] && filtroGamaIndex[2])
            {
                filtroGama = "AND (gamma=0 OR gamma=2)";
            }
            else if (filtroGamaIndex[0] && filtroGamaIndex[1])
            {
                filtroGama = $"AND gamma BETWEEN 0 AND 1";
            }
            else if (filtroGamaIndex[1] && filtroGamaIndex[2])
            {
                filtroGama = $"AND gamma BETWEEN 1 AND 2";
            }
            else if (filtroGamaIndex[0])
            {
                filtroGama = "AND gamma=0";
            }
            else if (filtroGamaIndex[1])
            {
                filtroGama = "AND gamma=1";
            }
            else if (filtroGamaIndex[2])
            {
                filtroGama = "AND gamma=2";
            }

            ActualizarCatalogo(false);
            maxValor = catalogoCompleto.Max(p => p.Precio);
        }


        // -------------------------------- TIMERS --------------------------------

        /// <summary>
        /// Timer que, segpun el valor del atributo "animacion", inicia la animación de salida, o de entrada
        /// del formulario.
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
        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                flowLayoutPanelSideBar.Width -= 7;
                if (flowLayoutPanelSideBar.Width <= buttonMenu.Width)
                {
                    sideBarExpand = false;
                    flowLayoutPanelSideBar.Enabled = false;
                    buttonPagar.Visible = false;
                    timerSideBar.Stop();

                }
            }
            else
            {
                flowLayoutPanelSideBar.Width += 7;
                if (flowLayoutPanelSideBar.Width >= (buttonMenu.Width + buttonUser.Width))
                {
                    sideBarExpand = true;
                    flowLayoutPanelSideBar.Enabled = true;
                    buttonPagar.Visible = true;
                    timerSideBar.Stop();
                }
            }
        }


        private void timerComprar_Tick(object sender, EventArgs e)
        {
            if (comprarExpand)
            {
                flowLayoutPanelComprar.Height -= 10;
                if (flowLayoutPanelComprar.Height <= 81)
                {
                    comprarExpand = false;
                    timerComprar.Stop();
                }
            }
            else
            {
                flowLayoutPanelComprar.Height += 10;
                if (flowLayoutPanelComprar.Height >= this.Height / 2 - 50)
                {
                    comprarExpand = true;
                    timerComprar.Stop();
                }
            }
        }

        private void timerMotherBoard_Tick(object sender, EventArgs e)
        {
            buttonMotherBoard.Width += 10;

            if (buttonMotherBoard.Width >= 134)
            {
                buttonMotherBoard.Text = "Placa Madre";
                timerMotherBoard.Stop();
            }
        }

        private void timerProcesador_Tick(object sender, EventArgs e)
        {
            buttonProcesador.Width += 10;

            if (buttonProcesador.Width >= 182)
            {
                buttonProcesador.Text = "Procesador";
                timerProcesador.Stop();
            }
        }

        private void timerGrafica_Tick(object sender, EventArgs e)
        {
            buttonGrafica.Width += 10;

            if (buttonGrafica.Width >= 152)
            {
                buttonGrafica.Text = "Tarjeta Grafica";
                timerGrafica.Stop();
            }
        }

        private void timerFuente_Tick(object sender, EventArgs e)
        {
            buttonFuente.Width += 10;

            if (buttonFuente.Width >= 172)
            {
                buttonFuente.Text = "Fuente de Poder";
                timerFuente.Stop();
            }
        }

        private void timerRAM_Tick(object sender, EventArgs e)
        {
            buttonRAM.Width += 10;

            if (buttonRAM.Width >= 165)
            {
                buttonRAM.Text = "Memoria RAM";
                timerRAM.Stop();
            }
        }

        private void trackBarPrecio_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBarPrecio.Value)
            {
                case 0:
                    AdminBDProductos.maxPrecio = catalogo[0].Precio + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${catalogo[0].Precio}";
                    break;
                case 1:
                    AdminBDProductos.maxPrecio = (maxValor * .2) + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${(maxValor * .2)}";
                    break;
                case 2:
                    AdminBDProductos.maxPrecio = (maxValor * .4) + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${(maxValor * .4)}";
                    break;
                case 3:
                    AdminBDProductos.maxPrecio = (maxValor * .6) + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${(maxValor * .6)}";
                    break;
                case 4:
                    AdminBDProductos.maxPrecio = (maxValor * .8) + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${(maxValor * .8)}";
                    break;
                case 5:
                    AdminBDProductos.maxPrecio = maxValor + 1;
                    ActualizarCatalogo(false);
                    labelPrecio.Text = $"Precio: $0 - ${maxValor}";
                    break;
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
        }


        // ----------------------------- REDIRECCIONES ----------------------------


    }
}
