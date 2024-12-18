using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPcElements
{
    public class AdminBDVentas
    {
        private MySqlConnection connection;

        public AdminBDVentas()
        {
            Connect();
        }

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

        public List<Venta> PeticionVentasByUserId(int idUsuario_)
        {
            List<Venta> ventas = new List<Venta>();

            int idUsuario;
            int idProducto;

            string query = "";

            try
            {
                query = $"SELECT * FROM ventas WHERE idUsuario = {idUsuario_}";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idUsuario = Convert.ToInt32(reader["idUsuario"]);
                    idProducto = Convert.ToInt32(reader["idProducto"]);

                    Venta v = new Venta(idUsuario, idProducto);
                    ventas.Add(v);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return ventas;
        }

        public List<Venta> PeticionVentas()
        {
            List<Venta> ventas = new List<Venta>();

            int idUsuario;
            int idProducto;

            string query = "";

            try
            {
                query = $"SELECT * FROM ventas";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idUsuario = Convert.ToInt32(reader["idUsuario"]);
                    idProducto = Convert.ToInt32(reader["idProducto"]);

                    Venta v = new Venta(idUsuario, idProducto);
                    ventas.Add(v);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return ventas;
        }

        public void Agregar(Venta v)
        {
            string query = "";
            try
            {
                query = $"INSERT INTO `ventas`(`idUsuario`, `idProducto`) VALUES " +
                    $"('" + v.IdUsuario + "', " + "'" + v.IdProducto + "')";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar ");
            }
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
