using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic;

namespace WinFormsPcElements
{
    public class AdminBDProductos
    {
        private MySqlConnection connection;
        public static double maxPrecio = 9999999;
        public static string query;

        public AdminBDProductos()
        {
            Connect();
        }

        /// <summary>
        /// Método que conecta la base de datos
        /// </summary>

        public void Connect()
        {
            string cadena = "Server=localhost; Database=pcelements2024; User=root; Password=; SslMode=none";

            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al conectar a la base de datos...");
            }
        }

        /// <summary>
        /// Método que retorna la lista de productos de la tabla según sus filtros.
        /// </summary>
        /// <returns></returns>

        public List<Producto> PeticionProductos()
        {
            List<Producto> productos = new List<Producto>();

            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;

            try
            {
                query = $"SELECT * FROM productos WHERE precio BETWEEN 0 AND {maxPrecio} {FormTienda.filtro} {FormTienda.filtroGama} ORDER BY precio";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"] ?? "");
                    descripcion = Convert.ToString(reader["descripcion"] ?? "");
                    precio = Convert.ToDouble(reader["precio"]);
                    gama = Convert.ToInt32(reader["gamma"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    stock = Convert.ToInt32(reader["stock"]);
                    img = Convert.ToString(reader["imagen"] ?? "");

                    Producto p = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                    productos.Add(p);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return productos;
        }

        /// <summary>
        /// Método que retorna una lista de productos ordenada por stock
        /// </summary>
        /// <returns></returns>

        public List<Producto> PeticionProductosByStock()
        {
            List<Producto> productos = new List<Producto>();

            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;

            try
            {
                query = $"SELECT * FROM productos ORDER BY stock DESC";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"] ?? "");
                    descripcion = Convert.ToString(reader["descripcion"] ?? "");
                    precio = Convert.ToDouble(reader["precio"]);
                    gama = Convert.ToInt32(reader["gamma"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    stock = Convert.ToInt32(reader["stock"]);
                    img = Convert.ToString(reader["imagen"] ?? "");

                    Producto p = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                    productos.Add(p);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return productos;
        }

        public List<Producto> PeticionProductosLike(string filtro_)
        {
            List<Producto> productos = new List<Producto>();

            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;



            try
            {
                query = $"SELECT * FROM productos WHERE nombre LIKE '%{filtro_}%' ORDER BY precio";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"] ?? "");
                    descripcion = Convert.ToString(reader["descripcion"] ?? "");
                    precio = Convert.ToDouble(reader["precio"]);
                    gama = Convert.ToInt32(reader["gamma"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    stock = Convert.ToInt32(reader["stock"]);
                    img = Convert.ToString(reader["imagen"] ?? "");

                    Producto p = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                    productos.Add(p);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return productos;
        }

        public void ActualizarStock(int id_)
        {

            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;

            int nuevoStock = 0;

            string query = $"SELECT * FROM productos WHERE id={id_};";

            MySqlCommand command = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                nombre = Convert.ToString(reader["nombre"] ?? "");
                descripcion = Convert.ToString(reader["descripcion"] ?? "");
                precio = Convert.ToDouble(reader["precio"]);
                gama = Convert.ToInt32(reader["gamma"]);
                tipo = Convert.ToInt32(reader["tipo"]);
                stock = Convert.ToInt32(reader["stock"]);
                img = Convert.ToString(reader["imagen"] ?? "");

                Producto p = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                nuevoStock = p.Stock - 1;
            }
            reader.Close();

            try
            {
                query = $"UPDATE `productos` SET `stock` = '{nuevoStock}' WHERE `productos`.`id` = {id_};";

                command = new MySqlCommand(query, this.connection);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Baja(int id)
        {
            string query;

            try
            {
                query = $"DELETE FROM productos WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto dado de baja...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo eliminar el producto :(");
            }
        }

        public void Baja10P(int id)
        {
            string query;

            try
            {
                query = $"DELETE FROM diezproductos WHERE id = {id}";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Producto dado de baja...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo eliminar el producto :(");
            }
        }

        public void Agregar(int id_, string nombre_, string descripcion_, double precio_, int gama_, int tipo_, int stock_, string img_)
        {
            string query = "";
            try
            {
                query = $"INSERT INTO `productos`(`id`, `nombre`, `descripcion`, `precio`, `gamma`, `tipo`, `stock`, `imagen`) VALUES " +
                    $"(" + "'" + id_ + "', " + "'" + nombre_ + "', " + "'" + descripcion_ + "', " + "'" + precio_ + "', " + "'" + gama_ + "', " + "'" + tipo_ + "', " + "'" + stock_ + "', " + "'" + img_ + "')";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto...");
            }
        }
        public void Modificar(int id_, string nombre_, string descripcion_, double precio_, int gama_, int tipo_, int stock_, string img_)
        {
            try
            {
                string query = $"UPDATE `productos` SET `id`= '{id_}', `nombre`= '{nombre_}', `descripcion`= '{descripcion_}', `precio`= '{precio_}', " +
                    $"`gamma`= '{gama_}', `tipo`= '{tipo_}', `stock`= '{stock_}', `imagen`= '{img_}' WHERE `id` = {id_}";


                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Acutalizado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto...");

            }

        }

        public Producto Consulta(int id_)
        {
            Producto item = null;
            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;
            try
            {
                string query = $"SELECT * FROM `productos` WHERE `id` = {id_}";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToDouble(reader["precio"]);
                    gama = Convert.ToInt32(reader["gamma"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    stock = Convert.ToInt32(reader["stock"]);
                    img = Convert.ToString(reader["imagen"]) ?? "";

                    item = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            return item;
        }

        public List<Producto> Peticion10Productos()
        {
            List<Producto> productos = new List<Producto>();

            int id;
            string nombre;
            string descripcion;
            double precio;
            int gama;
            int tipo;
            int stock;
            string img;

            try
            {
                query = $"SELECT * FROM diezproductos WHERE precio BETWEEN 0 AND {maxPrecio} {FormTienda.filtro} {FormTienda.filtroGama} ORDER BY precio";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"] ?? "");
                    descripcion = Convert.ToString(reader["descripcion"] ?? "");
                    precio = Convert.ToDouble(reader["precio"]);
                    gama = Convert.ToInt32(reader["gamma"]);
                    tipo = Convert.ToInt32(reader["tipo"]);
                    stock = Convert.ToInt32(reader["stock"]);
                    img = Convert.ToString(reader["imagen"] ?? "");

                    Producto p = new Producto(id, nombre, descripcion, precio, gama, tipo, stock, img);
                    productos.Add(p);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return productos;
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
