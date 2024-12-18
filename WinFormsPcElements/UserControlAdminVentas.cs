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
    public partial class UserControlAdminVentas : UserControl
    {
        public UserControlAdminVentas()
        {
            InitializeComponent();
        }

        private void UserControlAdminVentas_Load(object sender, EventArgs e)
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            tableLayoutPanelHeader.BackColor = AppTheme.header;
            panelCompras.BackColor = AppTheme.background;

            // Fuentes
            labelComprado.ForeColor = AppTheme.font;
            labelErick.ForeColor = AppTheme.font;
            labelGina.ForeColor = AppTheme.font;
            labelGuest.ForeColor = AppTheme.font;
            labelHarim.ForeColor = AppTheme.font;
            labelSantos.ForeColor = AppTheme.font;
            labelTotal.ForeColor = AppTheme.font;

            // PictureBox
            pictureBoxErick.BackgroundImage = AppTheme.user;
            pictureBoxGina.BackgroundImage = AppTheme.user;
            pictureBoxGuest.BackgroundImage = AppTheme.user;
            pictureBoxHarim.BackgroundImage = AppTheme.user;
            pictureBoxSantos.BackgroundImage = AppTheme.user;
        }

        private void pictureBoxGuest_Click(object sender, EventArgs e)
        {
            double total = 0;

            panelCompras.Controls.Clear();

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentasByUserId(5);

            AdminBDProductos bdP = new AdminBDProductos();

            panelCompras.Visible = false;

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, false, false, false, null);
                producto.Dock = DockStyle.Top;

                panelCompras.Controls.Add(producto);

                total += p.Precio;
            });

            labelTotal.Text = $"$ {total.ToString()}";
            panelCompras.Visible = true;
            panelCompras.AutoScroll = true;
        }

        private void pictureBoxErick_Click(object sender, EventArgs e)
        {
            double total = 0;

            panelCompras.Controls.Clear();

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentasByUserId(2);

            AdminBDProductos bdP = new AdminBDProductos();

            panelCompras.Visible = false;

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, false, false, false, null);
                producto.Dock = DockStyle.Top;

                panelCompras.Controls.Add(producto);

                total += p.Precio;
            });

            labelTotal.Text = $"$ {total.ToString()}";
            panelCompras.Visible = true;
            panelCompras.AutoScroll = true;
        }

        private void pictureBoxSantos_Click(object sender, EventArgs e)
        {
            double total = 0;

            panelCompras.Controls.Clear();

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentasByUserId(4);

            AdminBDProductos bdP = new AdminBDProductos();

            panelCompras.Visible = false;

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, false, false, false, null);
                producto.Dock = DockStyle.Top;

                panelCompras.Controls.Add(producto);

                total += p.Precio;
            });

            labelTotal.Text = $"$ {total.ToString()}";
            panelCompras.Visible = true;
            panelCompras.AutoScroll = true;
        }

        private void pictureBoxHarim_Click(object sender, EventArgs e)
        {
            double total = 0;

            panelCompras.Controls.Clear();

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentasByUserId(3);

            AdminBDProductos bdP = new AdminBDProductos();

            panelCompras.Visible = false;

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, false, false, false, null);
                producto.Dock = DockStyle.Top;

                panelCompras.Controls.Add(producto);

                total += p.Precio;
            });

            labelTotal.Text = $"$ {total.ToString()}";

            panelCompras.Visible = true;
            panelCompras.AutoScroll = true;
        }

        private void pictureBoxGina_Click(object sender, EventArgs e)
        {
            double total = 0;

            panelCompras.Controls.Clear();

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentasByUserId(6);

            AdminBDProductos bdP = new AdminBDProductos();

            panelCompras.Visible = false;

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, false, false, false, null);
                producto.Dock = DockStyle.Top;

                panelCompras.Controls.Add(producto);

                total += p.Precio;
            });

            labelTotal.Text = $"$ {total.ToString()}";
            panelCompras.Visible = true;
            panelCompras.AutoScroll = true;
        }
    }
}
