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
    public partial class FormPagar : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------
        private double total;
        private bool animacion;

        public FormPagar()
        {
            InitializeComponent();
            InitializeWindow();
        }

        private void FormPagar_Load(object sender, EventArgs e)
        {
            InitializeComponents();


            this.Top = this.Top + 15;
            animacion = true;

            timerAnimacion.Start();

            actualizarCarrito();
        }

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BringToFront();
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {

            // Paneles principales
            panelHeader.BackColor = AppTheme.header;
            panelCentral.BackColor = AppTheme.background;
            panelProductos.BackgroundImage = AppTheme.backgroundInfo;

            // Fuentes
            buttonLimpiar.ForeColor = AppTheme.buttonsFont;
            buttonPagar.ForeColor = AppTheme.buttonsFont;
            labelTotal.ForeColor = AppTheme.font;

            // Botones
            buttonLimpiar.BackColor = AppTheme.button;
            buttonPagar.BackColor = AppTheme.button;
        }

        // ------------------------------- COMPONENTES -------------------------------

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {

            if (FormTienda.carrito.Count > 0)
            {
                AdminBD bd = new AdminBD();
                bd.ActualizarMonto(FormPortada.usuario.Id, total);

                AdminBDVentas bdV = new AdminBDVentas();

                AdminBDProductos bdP = new AdminBDProductos();

                FormTienda.carrito.ForEach(x =>
                {
                    Venta v = new Venta(FormPortada.usuario.Id, x.Id);

                    bdV.Agregar(v);

                    bdP.ActualizarStock(x.Id);
                });


                FormTicket formularioTicket = new FormTicket();
                this.Opacity = .7;
                formularioTicket.ShowDialog();
                this.Opacity = 1;

                FormTienda.carrito.Clear();
                actualizarCarrito();

                //Cerrar el formulario
                animacion = false;
                timerAnimacion.Start();
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito para comprar...");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            FormTienda.carrito.Clear();

            MessageBox.Show("Vaciando carrito...");

            animacion = false;
            timerAnimacion.Start();
        }

        // ------------------------------- ACCIONES -------------------------------

        private void actualizarCarrito()
        {
            panelProductos.Controls.Clear();

            FormTienda.carrito.ForEach(c =>
            {
                Panel separacion = new Panel();
                separacion.Dock = DockStyle.Top;
                separacion.Height = 20;

                UserControlPanelProducto panel = new UserControlPanelProducto(c, false, false, false, false, false, null);
                panel.Dock = DockStyle.Top;

                panelProductos.Controls.Add(separacion);
                panelProductos.Controls.Add(panel);

                total += c.Precio;
            });

            labelTotal.Text = $"${total.ToString()}";
        }

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


        // ------------------------------- TIMERS -------------------------------
    }
}
