using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPcElements
{
    public class Venta
    {
        private int idUsuario;
        private int idProducto;


        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }

        public Venta(int idUsuario, int idProducto)
        {
            this.IdUsuario = idUsuario;
            this.IdProducto = idProducto;
        }
    }
}
