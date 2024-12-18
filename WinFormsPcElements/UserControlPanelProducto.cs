using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public partial class UserControlPanelProducto : UserControl
    {
        private Producto producto;

        private int id;
        private string nombre;
        private string descripcion;
        private double precio;
        private string img;

        private FormTienda tienda;

        private bool agotado;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Img { get => img; set => img = value; }
        public int Id { get => id; set => id = value; }
        public Producto Producto { get => producto; set => producto = value; }

        public UserControlPanelProducto()
        {
            InitializeComponent();
        }

        public UserControlPanelProducto(Producto p, bool desc, bool btn, bool id, bool stock, bool agotado, FormTienda tienda)
        {
            InitializeComponent();

            this.tienda = tienda;
            this.id = p.Id;
            this.agotado = agotado;

            if (id)
            {
                this.nombre = $"{p.Nombre}   ID: {p.Id}";
            }
            else
            {
                this.nombre = p.Nombre;
            }

            if (stock)
            {
                if (FormTienda.prodStock != null)
                    this.nombre += $"    STOCK: {FormTienda.prodStock[p.Id - 1].Stock}";
                else
                    this.nombre += $"    STOCK: {p.Stock}";
            }

            if (desc)
            {
                this.descripcion = p.Descripcion;
            }
            else
            {
                labelDescripcion.Dispose();
            }

            if (!btn)
            {
                buttonAgregarCarrito.Dispose();
            }
            this.precio = p.Precio;
            this.img = p.Img;
            this.producto = p;

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            this.BackColor = AppTheme.background;

            // Buttons
            buttonAgregarCarrito.BackgroundImage = AppTheme.backgroundInfo;

            // Fuentes
            labelDescripcion.ForeColor = AppTheme.font;
            labelNombre.ForeColor = AppTheme.font;
            labelPrecio.ForeColor = AppTheme.font;

            if (FormTienda.prodStock != null)
            {
                if (FormTienda.prodStock[producto.Id - 1].Stock == 0)
                {
                    buttonAgregarCarrito.ForeColor = AppTheme.paleta[11];
                    buttonAgregarCarrito.Enabled = false;
                    buttonAgregarCarrito.Text = "Existencias Insuficientes";
                    buttonAgregarCarrito.BackgroundImage = AppTheme.backgroundAgotado;
                }
            }

            if (agotado)
            {
                buttonAgregarCarrito.ForeColor = AppTheme.paleta[11];
                buttonAgregarCarrito.Enabled = false;
                buttonAgregarCarrito.Text = "Existencias Agotadas";
                buttonAgregarCarrito.BackgroundImage = AppTheme.backgroundAgotado;
            }
            else
            {
                buttonAgregarCarrito.ForeColor = AppTheme.font;
            }

            if (FormPortada.usuario.Admin == true)
            {
                buttonAgregarCarrito.ForeColor = AppTheme.paleta[11];
                buttonAgregarCarrito.Enabled = false;
                buttonAgregarCarrito.Text = "Usuario Selecionado: Admin";
                buttonAgregarCarrito.BackgroundImage = AppTheme.backgroundAgotado;
            }
        }

        private void UserControlPanelProducto_Load(object sender, EventArgs e)
        {
            labelNombre.Text = nombre;
            labelDescripcion.Text = descripcion;
            labelPrecio.Text = $"${precio.ToString()}";

            pictureBoxProducto.BackgroundImage = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "productos", img));

        }

        private void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            FormTienda.prodStock[producto.Id - 1].Stock -= 1;

            FormTienda.carrito.Add(this.producto);

            MessageBox.Show("Producto agregado al carrito...");

            if (tienda != null)
            {
                tienda.ActualizarCatalogo(false);
            }
        }
    }
}