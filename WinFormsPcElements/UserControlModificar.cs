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
    public partial class UserControlModificar : UserControl
    {
        private Producto item;
        private string img;

        public UserControlModificar()
        {
            InitializeComponent();
        }

        private void UserControlModificar_Load(object sender, EventArgs e)
        {
            InitializeComponents();
            textBoxDescripcion.Visible = false;
            Limpiar();
            numericUpDownId_ValueChanged(sender, e);
            ActualizarCatalogo();
            textBoxDescripcion.Visible = true;
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            // Paneles principales
            tableLayoutPanelBackground.BackColor = AppTheme.extremo;

            // Fuentes
            buttonModificar.ForeColor = AppTheme.font;
            buttonAgregarImagen.ForeColor = AppTheme.font;

            textBoxDescripcion.ForeColor = AppTheme.buttonsFont;
            textBoxGama.ForeColor = AppTheme.buttonsFont;
            numericUpDownId.ForeColor = AppTheme.buttonsFont;
            textBoxNombre.ForeColor = AppTheme.buttonsFont;
            textBoxPrecio.ForeColor = AppTheme.buttonsFont;
            textBoxStock.ForeColor = AppTheme.buttonsFont;
            textBoxTipo.ForeColor = AppTheme.buttonsFont;

            labelDescripcion.ForeColor = AppTheme.font;
            labelGama.ForeColor = AppTheme.font;
            labelId.ForeColor = AppTheme.font;
            labelImagen.ForeColor = AppTheme.font;
            labelImg.ForeColor = AppTheme.font;
            labelNombre.ForeColor = AppTheme.font;
            labelPrecio.ForeColor = AppTheme.font;
            labelStock.ForeColor = AppTheme.font;
            labelTipo.ForeColor = AppTheme.font;

            // Bordes
            buttonModificar.FlatAppearance.BorderColor = AppTheme.header;
            buttonAgregarImagen.FlatAppearance.BorderColor = AppTheme.header;

            // TextBox
            textBoxDescripcion.BackColor = AppTheme.textBox;
            textBoxGama.BackColor = AppTheme.textBox;
            numericUpDownId.BackColor = AppTheme.textBox;
            textBoxNombre.BackColor = AppTheme.textBox;
            textBoxPrecio.BackColor = AppTheme.textBox;
            textBoxStock.BackColor = AppTheme.textBox;
            textBoxTipo.BackColor = AppTheme.textBox;

            // Botones
            buttonAgregarImagen.Image = AppTheme.addFIleIcon;
            buttonModificar.Image = AppTheme.addIcon;
        }

        private void ActualizarCatalogo()
        {
            panelListaProductos.Controls.Clear();

            bool agotado = false;

            List<Producto> lista = new List<Producto>();

            AdminBDProductos bd = new AdminBDProductos();

            panelListaProductos.Visible = false;

            lista = bd.PeticionProductos();

            lista.ForEach(p =>
            {

                if (p.Stock == 0)
                {
                    agotado = true;
                }
                else
                {
                    agotado = false;
                }

                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, true, false, agotado, null);
                producto.Dock = DockStyle.Top;

                panelListaProductos.Controls.Add(producto);
            });

            panelListaProductos.Visible = true;
            panelListaProductos.AutoScroll = true;
        }

        public void Limpiar()
        {
            numericUpDownId.Value = 1;
            textBoxGama.Text = "";
            textBoxStock.Text = "";
            textBoxTipo.Text = "";
            textBoxDescripcion.Text = "";
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
        }

        private void numericUpDownId_ValueChanged(object sender, EventArgs e)
        {
            List<Producto> lista = new List<Producto>();

            AdminBDProductos prod = new AdminBDProductos();

            FormTienda.filtro = "";
            FormTienda.filtroGama = "";

            lista = prod.PeticionProductos();

            if (numericUpDownId.Value > lista.Count)
            {
                numericUpDownId.Value = 1;
            }
            else if (numericUpDownId.Value < 1)
            {
                numericUpDownId.Value = lista.Count;
            }

            item = prod.Consulta((int)numericUpDownId.Value);

            img = item.Img;

            numericUpDownId.Value = item.Id;
            textBoxGama.Text = item.Gama.ToString();
            textBoxStock.Text = item.Stock.ToString();
            textBoxTipo.Text = item.Tipo.ToString();
            textBoxNombre.Text = item.Nombre;
            textBoxDescripcion.Text = item.Descripcion;
            textBoxPrecio.Text = Convert.ToString(item.Precio);
            pictureBoxImg.BackgroundImage = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "productos", item.Img));
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            AdminBDProductos obj = new AdminBDProductos();
            int id = (int)numericUpDownId.Value;
            string nombre = textBoxNombre.Text;
            string descripcion = textBoxDescripcion.Text;
            double precio = Convert.ToDouble(textBoxPrecio.Text);
            int gama = Convert.ToInt32(textBoxGama.Text);
            int tipo = Convert.ToInt32(textBoxTipo.Text);
            int stock = Convert.ToInt32(textBoxStock.Text);
            obj.Modificar(id, nombre, descripcion, precio, gama, tipo, stock, img);
            Limpiar();
            numericUpDownId_ValueChanged(sender, e);
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagenPath = openFileDialog.FileName;
                string nombreArchivo = Path.GetFileName(imagenPath);
                string rutaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "productos", nombreArchivo);
                File.Copy(imagenPath, rutaDestino, true); string rutaRelativa = "imagenes/" + nombreArchivo;
                img = nombreArchivo;
                pictureBoxImg.BackgroundImage = Image.FromFile(imagenPath);
            }
        }
    }
}
