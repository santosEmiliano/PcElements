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
    public partial class FormAdmin : Form
    {
        private bool inventario = false;
        private bool altas = false;
        private bool modificaciones = false;
        private bool bajas = false;
        private bool estadisticas = false;
        private bool ventas = false;

        private bool exitMenu;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            InitializeWindow();
            InitializeComponents();

            timerAltExitMenu.Stop();
        }

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
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            panelSideBar.BackColor = AppTheme.sideBar;
            panelHeader.BackColor = AppTheme.header;
            tableLayoutPanelHome.BackColor = AppTheme.background;
            panelMain.BackColor = AppTheme.background;

            // Fuentes
            labelFecha.ForeColor = AppTheme.buttonsFont;

            // Botones
            buttonInventario.BackgroundImage = AppTheme.clipBoard;
            buttonAltas.BackgroundImage = AppTheme.addIcon;
            buttonMod.BackgroundImage = AppTheme.editIcon;
            buttonBajas.BackgroundImage = AppTheme.deleteIcon;
            buttonGraficas.BackgroundImage = AppTheme.statsIcon;
            buttonVentas.BackgroundImage = AppTheme.ventas;
        }
        private void ComponentsSize()
        {
            tableLayoutPanelExitMenu.Width = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerAltExitMenu_Tick(object sender, EventArgs e)
        {
            if (exitMenu)
            {
                tableLayoutPanelExitMenu.Width -= 10;

                if (tableLayoutPanelExitMenu.Width == 0)
                {
                    exitMenu = false;
                    timerAltExitMenu.Stop();
                }
            }
            else
            {
                tableLayoutPanelExitMenu.Width += 10;

                if (tableLayoutPanelExitMenu.Width == 190)
                {
                    exitMenu = true;
                    timerAltExitMenu.Stop();
                }
            }
        }

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

            timerAltExitMenu.Start();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            if (!inventario)
            {
                buttonInventario.BackColor = AppTheme.background;
                buttonGraficas.BackColor = Color.Transparent;
                buttonAltas.BackColor = Color.Transparent;
                buttonBajas.BackColor = Color.Transparent;
                buttonMod.BackColor = Color.Transparent;
                buttonVentas.BackColor = Color.Transparent;

                inventario = true;

                altas = false;
                modificaciones = false;
                bajas = false;
                estadisticas = false;
                ventas = false;
            }
            else
            {
                buttonInventario.BackColor = Color.Transparent;
                inventario = false;
                panelMain.Controls.Clear();
            }

            bool agotado = false;

            panelMain.Controls.Clear();

            AdminBDProductos bd = new AdminBDProductos();
            List<Producto> productos = new List<Producto>();

            FormTienda.filtroGama = FormTienda.filtro = "";
            productos = bd.PeticionProductosByStock();

            Panel panelInventario = new Panel();
            panelInventario.Dock = DockStyle.Fill;
            panelInventario.Visible = false;

            productos.ForEach(p =>
            {
                if (p.Stock == 0)
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

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, true, true, agotado, null);
                producto.Dock = DockStyle.Top;

                panelInventario.Controls.Add(separacion);
                panelInventario.Controls.Add(producto);
            });

            panelMain.Controls.Add(panelInventario);
            panelInventario.Visible = true;
            panelInventario.AutoScroll = true;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

            if (!modificaciones)
            {
                buttonInventario.BackColor = Color.Transparent;
                buttonGraficas.BackColor = Color.Transparent;
                buttonAltas.BackColor = Color.Transparent;
                buttonBajas.BackColor = Color.Transparent;
                buttonMod.BackColor = AppTheme.background;
                buttonVentas.BackColor = Color.Transparent;
                modificaciones = true;

                inventario = false;
                altas = false;
                bajas = false;
                estadisticas = false;
                ventas = false;
            }
            else
            {
                buttonMod.BackColor = Color.Transparent;
                modificaciones = false;
                panelMain.Controls.Clear();
            }

            panelMain.Controls.Clear();

            panelMain.Visible = false;

            UserControlModificar modificar = new UserControlModificar();
            modificar.Dock = DockStyle.Fill;

            panelMain.Controls.Add(modificar);

            panelMain.Visible = true;
        }

        private void buttonBajas_Click(object sender, EventArgs e)
        {

            if (!bajas)
            {
                buttonInventario.BackColor = Color.Transparent;
                buttonGraficas.BackColor = Color.Transparent;
                buttonAltas.BackColor = Color.Transparent;
                buttonBajas.BackColor = AppTheme.background;
                buttonMod.BackColor = Color.Transparent;
                buttonVentas.BackColor = Color.Transparent;
                bajas = true;

                inventario = false;
                altas = false;
                modificaciones = false;
                estadisticas = false;
                ventas = false;
            }
            else
            {
                buttonBajas.BackColor = Color.Transparent;
                bajas = false;
                panelMain.Controls.Clear();
            }

            panelMain.Controls.Clear();

            UserControlAdminMod baja = new UserControlAdminMod();
            baja.Dock = DockStyle.Fill;

            panelMain.Controls.Add(baja);
        }

        private void buttonAltas_Click(object sender, EventArgs e)
        {

            if (!altas)
            {
                buttonInventario.BackColor = Color.Transparent;
                buttonGraficas.BackColor = Color.Transparent;
                buttonAltas.BackColor = AppTheme.background;
                buttonBajas.BackColor = Color.Transparent;
                buttonMod.BackColor = Color.Transparent;
                buttonVentas.BackColor = Color.Transparent;
                altas = true;

                inventario = false;
                modificaciones = false;
                bajas = false;
                estadisticas = false;
                ventas = false;
            }
            else
            {
                buttonAltas.BackColor = Color.Transparent;
                altas = false;
                panelMain.Controls.Clear();
            }

            panelMain.Controls.Clear();
            panelMain.Visible = false;
            UserControlAdminAltas alta = new UserControlAdminAltas();

            alta.Dock = DockStyle.Fill;

            panelMain.Controls.Add(alta);
            panelMain.Visible = true;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormPortada.usuario = null;
            this.Dispose();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            if (!ventas)
            {
                buttonInventario.BackColor = Color.Transparent;
                buttonGraficas.BackColor = Color.Transparent;
                buttonAltas.BackColor = Color.Transparent;
                buttonBajas.BackColor = Color.Transparent;
                buttonMod.BackColor = Color.Transparent;
                buttonVentas.BackColor = AppTheme.background;
                ventas = true;

                inventario = false;
                modificaciones = false;
                bajas = false;
                estadisticas = false;
                altas = false;
            }
            else
            {
                buttonVentas.BackColor = Color.Transparent;
                ventas = false;
                panelMain.Controls.Clear();
            }

            panelMain.Controls.Clear();
            panelMain.Visible = false;
            UserControlAdminVentas panelVentas = new UserControlAdminVentas();

            panelVentas.Dock = DockStyle.Fill;

            panelMain.Controls.Add(panelVentas);
            panelMain.Visible = true;
        }

        private void buttonGraficas_Click(object sender, EventArgs e)
        {
            if (!estadisticas)
            {
                buttonInventario.BackColor = Color.Transparent;
                buttonGraficas.BackColor = AppTheme.background;
                buttonAltas.BackColor = Color.Transparent;
                buttonBajas.BackColor = Color.Transparent;
                buttonMod.BackColor = Color.Transparent;
                buttonVentas.BackColor = Color.Transparent;
                estadisticas = true;

                inventario = false;
                modificaciones = false;
                bajas = false;
                ventas = false;
                altas = false;
            }
            else
            {
                buttonGraficas.BackColor = Color.Transparent;
                estadisticas = false;
                panelMain.Controls.Clear();
            }

            panelMain.Controls.Clear();
            panelMain.Visible = false;
            UserControlAdminEstadisticas panelGraficas = new UserControlAdminEstadisticas();

            panelGraficas.Dock = DockStyle.Fill;

            panelMain.Controls.Add(panelGraficas);
            panelMain.Visible = true;
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString();
        }
    }
}
