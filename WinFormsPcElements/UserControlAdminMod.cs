using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public partial class UserControlAdminMod : UserControl
    {
        public static bool baja;
        private string filtro;

        public UserControlAdminMod()
        {
            InitializeComponent();
        }

        private void UserControlAdminMod_Load(object sender, EventArgs e)
        {
            InitializeComponents();
            ActualizarLista();

        }
        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            if (AppTheme.LM == true)
            {
                AppTheme.DarkMode();
            }
            else
            {
                AppTheme.LightMode();
            }

            // Paneles principales
            panelHeader.BackColor = AppTheme.header;
            tableLayoutPanelMain.BackColor = AppTheme.background;

            // Fuentes
            labelNombre.ForeColor = AppTheme.font;
            labelTitulo.ForeColor = AppTheme.font;
            labelId.ForeColor = AppTheme.font;
            buttonDarBaja.ForeColor = AppTheme.buttonsFont;

            // Botones
            buttonDarBaja.BackColor = AppTheme.header;

            if (AppTheme.LM == true)
            {
                AppTheme.DarkMode();
            }
            else
            {
                AppTheme.LightMode();
            }

            buttonDarBaja.ForeColor = AppTheme.font;
        }

        private void ActualizarLista()
        {
            panelListaProductos.Controls.Clear();

            AdminBDProductos bd = new AdminBDProductos();

            List<Producto> productos = new List<Producto>();

            panelListaProductos.Visible = false;

            productos = bd.PeticionProductosLike(filtro);

            productos.ForEach(p =>
            {
                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, true, false, false, null);
                producto.Dock = DockStyle.Top;
                panelListaProductos.Controls.Add(producto);
            });

            panelListaProductos.Visible = true;
            panelListaProductos.AutoScroll = true;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            filtro = textBoxNombre.Text;

            ActualizarLista();
        }

        private void buttonDarBaja_Click(object sender, EventArgs e)
        {
            FormConfirmarBaja confirmar = new FormConfirmarBaja();
            confirmar.ShowDialog();

            if (baja)
            {
                AdminBDProductos bd = new AdminBDProductos();
                List<Producto> lista = new List<Producto>();

                AdminBDProductos.maxPrecio = 999999;
                FormTienda.filtro = "";
                FormTienda.filtroGama = "";

                //lista = bd.PeticionProductos();
                lista = bd.Peticion10Productos();

                if (lista.Count == 6)
                {
                    MessageBox.Show("No se puede tener menos de 6 productos...");
                }
                else
                {
                    //bd.Baja((int)numericUpDownId.Value);
                    bd.Baja10P((int)numericUpDownId.Value);
                }

                textBoxNombre.Text = "";

                ActualizarLista();
            }
        }
    }
}