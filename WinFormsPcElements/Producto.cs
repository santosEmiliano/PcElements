using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPcElements
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string descripcion;
        private double precio;
        private int gama;
        private int tipo;
        private int stock;
        private string img;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Gama { get => gama; set => gama = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Img { get => img; set => img = value; }

        public Producto(int id, string nombre, string descripcion, double precio, int gama, int tipo, int stock, string img)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.gama = gama;
            this.tipo = tipo;
            this.stock = stock;
            this.img = img;
        }
    }
}
