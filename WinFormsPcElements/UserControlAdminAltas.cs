using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public partial class UserControlAdminAltas : UserControl
    {
        private string img = "";

        public UserControlAdminAltas()
        {
            InitializeComponent();
        }

        private void UserControlAdminAltas_Load(object sender, EventArgs e)
        {
            textBoxDescripcion.Visible = false;
            InitializeComponents();
            Limpiar();
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
            tableLayoutPanelBackgroud.BackColor = AppTheme.extremo;

            // Fuentes
            buttonAgregar.ForeColor = AppTheme.font;
            buttonImg.ForeColor = AppTheme.font;

            textBoxDescripcion.ForeColor = AppTheme.buttonsFont;
            textBoxGama.ForeColor = AppTheme.buttonsFont;
            textBoxId.ForeColor = AppTheme.buttonsFont;
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
            buttonAgregar.FlatAppearance.BorderColor = AppTheme.header;
            buttonImg.FlatAppearance.BorderColor = AppTheme.header;

            // TextBox
            textBoxDescripcion.BackColor = AppTheme.textBox;
            textBoxGama.BackColor = AppTheme.textBox;
            textBoxId.BackColor = AppTheme.textBox;
            textBoxNombre.BackColor = AppTheme.textBox;
            textBoxPrecio.BackColor = AppTheme.textBox;
            textBoxStock.BackColor = AppTheme.textBox;
            textBoxTipo.BackColor = AppTheme.textBox;

            // Botones
            buttonImg.Image = AppTheme.addFIleIcon;
            buttonAgregar.Image = AppTheme.addIcon;
        }

        public void Limpiar()
        {
            textBoxDescripcion.Text = "";
            textBoxId.Text = "";
            textBoxTipo.Text = "";
            textBoxGama.Text = "";
            textBoxNombre.Text = "";
            textBoxStock.Text = "";
            textBoxPrecio.Text = "";
            pictureBoxImg.BackgroundImage = null;
        }

        private void ActualizarCatalogo()
        {
            panelListaProductos.Controls.Clear();

            List<Producto> lista = new List<Producto>();

            AdminBDProductos bd = new AdminBDProductos();

            panelListaProductos.Visible = false;

            lista = bd.PeticionProductos();

            lista.ForEach(p =>
            {
                UserControlPanelProducto producto = new UserControlPanelProducto(p, true, false, true, false, false, null);
                producto.Dock = DockStyle.Top;

                panelListaProductos.Controls.Add(producto);
            });

            panelListaProductos.Visible = true;
            panelListaProductos.AutoScroll = true;
        }

        private void buttonImg_Click(object sender, EventArgs e)
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

        private bool ValidarTextBox()
        {
            if (
                textBoxDescripcion.Text == "" ||
                textBoxGama.Text == "" ||
                textBoxId.Text == "" ||
                textBoxNombre.Text == "" ||
                textBoxPrecio.Text == "" ||
                textBoxStock.Text == "" ||
                textBoxTipo.Text == ""
            )
            {
                return false;
            }

            return true;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool flag = ValidarTextBox();



            if (flag)
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                string descripcion = textBoxDescripcion.Text;
                double precio = Convert.ToDouble(textBoxPrecio.Text);
                int gama = Convert.ToInt32(textBoxGama.Text);
                int tipo = Convert.ToInt32(textBoxTipo.Text);
                int stock = Convert.ToInt32(textBoxStock.Text);


                AdminBDProductos bd = new AdminBDProductos();

                bd.Agregar(id, nombre, descripcion, precio, gama, tipo, stock, img);

                Limpiar();
                ActualizarCatalogo();
            }
            else
            {
                if (pictureBoxImg.BackgroundImage == null)
                {
                    MessageBox.Show("Debes ingresar una imágen para el producto...");
                }
                else
                {
                    MessageBox.Show("Debes llenar todos los campos...");
                }
            }
        }
    }
}
