using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;

namespace WinFormsPcElements
{
    public class AdminBD
    {
        private MySqlConnection connection;

        public AdminBD()
        {
            this.Connect();
        }

        /// <summary>
        /// Método para conectar a la base de datos del usuario root, maneja una excepción que manda
        /// un mensaje de error en caso de no poder conectarse a la base de datos.
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
        /// Método que retorna un usuario. Consulta en la tabla usuarios de la base de datos, el usuario que
        /// contenga la cuenta que se recibió como parámetro.
        /// Maneja dos excepciones, la primera determina si el usuario existe en la tabla, en caso de que no,
        /// retorna el usuario que, para ese punto equivale a null.
        /// La segunda lee el usuario y lo retorna, en caso de que surga algún fallo, manda un mensaje de error.
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>

        public Users PeticionUsuario(string _user)
        {
            Users usuario = null;

            int id;
            string name;
            string account;
            string password;
            bool admin;
            string query;

            try
            {
                try
                {
                    query = "SELECT * FROM usuarios where account='" + _user + "';";
                }
                catch (Exception ex)
                {
                    return usuario;
                }

                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"] ?? "");
                    account = Convert.ToString(reader["account"] ?? "");
                    password = Convert.ToString(reader["password"] ?? "");
                    admin = Convert.ToBoolean(reader["admin"]);

                    usuario = new Users(id, name, account, password, admin);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla");
                this.Disconnect();
            }

            return usuario;
        }

        /// <summary>
        /// Método que recibe un id y un monto. Este método hace una petición a la tabla para
        /// guardar el monto actual del usuario, y le suma el precio de su compra, para luego actualizarlo en
        /// la tabla. Aparte, hace la misma acción con el usuario pcelements para llevar un total de ventas
        /// </summary>
        /// <param name="id_"></param>
        /// <param name="precio"></param>

        public void ActualizarMonto(int id_, double precio)
        {

            int id;
            string name;
            string account;
            string password;
            bool admin;
            double monto;

            double total = 0, totalEmpresa = 0;

            Users usuario = null;

            string query = $"SELECT * FROM usuarios WHERE id={id_};";

            MySqlCommand command = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                name = Convert.ToString(reader["name"] ?? "");
                account = Convert.ToString(reader["account"] ?? "");
                password = Convert.ToString(reader["password"] ?? "");
                admin = Convert.ToBoolean(reader["admin"]);
                monto = Convert.ToDouble(reader["amount"]);

                total = monto + precio;
            }
            reader.Close();

            query = $"SELECT * FROM usuarios WHERE id=7;";

            command = new MySqlCommand(query, this.connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id"]);
                name = Convert.ToString(reader["name"] ?? "");
                account = Convert.ToString(reader["account"] ?? "");
                password = Convert.ToString(reader["password"] ?? "");
                admin = Convert.ToBoolean(reader["admin"]);
                monto = Convert.ToDouble(reader["amount"]);

                totalEmpresa = monto + precio;
            }
            reader.Close();

            try
            {
                query = $"UPDATE `usuarios` SET `amount` = '{total}' WHERE `usuarios`.`id` = {id_};";

                command = new MySqlCommand(query, this.connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Compra exitosa ;)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                query = $"UPDATE `usuarios` SET `amount` = '{totalEmpresa}' WHERE `usuarios`.`id` = 7;";

                command = new MySqlCommand(query, this.connection);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Método que desconecta el programa con la base de datos.
        /// </summary>

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}