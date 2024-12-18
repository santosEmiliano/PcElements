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
    public partial class FormTicket : Form
    {
        // ------------------------------- ATRIBUTOS -------------------------------

        private bool animacion;
        public static int folio;

        // ------------------------------- INICIALIZACIONES -------------------------------

        public FormTicket()
        {
            InitializeComponent();
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            InitializeComponents();

            this.Top = this.Top + 15;
            animacion = true;

            cambiarLabels();
            cambiarDGV();

            timerAnimacion.Start();
            InitializeWindow();
        }

        private void InitializeWindow()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            //PANELES PRINCIPALES
            panelMain.BackColor = AppTheme.background;
            panelCentral.BackgroundImage = AppTheme.backgroundInfo;

            //COMPONENTS
            buttonTicket.BackgroundImage = AppTheme.backgroundInfoInv;
            buttonTicket.ForeColor = AppTheme.font;

            buttonRegresar.BackgroundImage = AppTheme.backgroundInfoInv;
            buttonRegresar.ForeColor = AppTheme.font;

            //DATA GRID VIEW
            dGVProductos.BackgroundColor = AppTheme.header;

            dGVProductos.ColumnHeadersDefaultCellStyle.BackColor = AppTheme.header;
            dGVProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dGVProductos.DefaultCellStyle.BackColor = AppTheme.filaImpar;
            dGVProductos.DefaultCellStyle.ForeColor = Color.White;
            dGVProductos.DefaultCellStyle.SelectionBackColor = AppTheme.filaImpar;
            dGVProductos.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        //------------------------------ COMPONENTS -------------------------------

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            FormProductosTicket ticket = new FormProductosTicket();
            ticket.ShowDialog();
            animacion = false;
            timerAnimacion.Start();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            animacion = false;
            timerAnimacion.Start();
        }

        // ------------------------------- ACCIONES -------------------------------
        private void cambiarLabels()
        {
            Random rnd = new Random(); //variable para generar numeros aleatorios
            folio = rnd.Next(1, 999999); //Variable para almacenar los numeros aleatorios

            labelNombreAdd.Text = FormPortada.usuario.Name;
            labelFolioAdd.Text = folio.ToString();
        }
        private void cambiarDGV()
        {
            string tipo = string.Empty;
            double importe = 0;
            double total = 0;

            columnasProductos();
            // Agrupamos los productos por Id y contamos cuántas veces aparece cada producto // Obtiene el primer producto de cada grupo y cuenta la cantidad
            var productosAgrupados = FormTienda.carrito.GroupBy(p => p.Id).Select(g => new { Producto = g.First(), Cantidad = g.Count() }).ToList();

            // Esto no es necesario Pero si lo quieren ordenar todo bien 
            //productosAgrupados = productosAgrupados.OrderBy(p => p.Producto.Id).ToList();

            foreach (var grupo in productosAgrupados)
            {
                Producto producto = grupo.Producto;
                int cont = grupo.Cantidad;


                int n = dGVProductos.Rows.Add();
                DataGridViewRow fila = dGVProductos.Rows[n];

                fila.Cells["Cantidad"].Value = cont.ToString();
                fila.Cells["NombreProducto"].Value = producto.Nombre;

                tipo = tipoProducto(producto);
                fila.Cells["TipoProducto"].Value = tipo;

                // Precio unitario del producto
                fila.Cells["PrecioUnitario"].Value = $"${producto.Precio}";

                // Calculamos el importe (precio * cantidad)
                importe = cont * producto.Precio;
                fila.Cells["Importe"].Value = $"${importe}";
                total += importe; 
            }

            total *= 1.6;
            labelTotalAdd.Text = $"${total.ToString()}";
        }
        private void columnasProductos()
        {
            //Nombre Colum //Text Colum
            dGVProductos.Columns.Add("Cantidad", "Cantidad");
            dGVProductos.Columns.Add("NombreProducto", "Nombre del Producto");
            dGVProductos.Columns.Add("TipoProducto", "Tipo de Producto");
            dGVProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dGVProductos.Columns.Add("Importe", "Importe");
        }

        private string tipoProducto(Producto producto)
        {
            string tipo = string.Empty;
            switch (producto.Tipo)
            {
                case 0:
                    tipo = "MotherBoard";
                    break;
                case 1:
                    tipo = "Procesador";
                    break;
                case 2:
                    tipo = "Tarjeta Grafica";
                    break;
                case 3:
                    tipo = "Fuente de Poder";
                    break;
                case 4:
                    tipo = "RAM";
                    break;
            }
            return tipo;
        }

        // ------------------------------- TIMERS -------------------------------

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (animacion)
            {
                if (this.Opacity >= 1)
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
                if (this.Opacity <= 0)
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


        private void timerHora_Tick(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            labelFechaAdd.Text = ahora.ToString();
        }
    }
}