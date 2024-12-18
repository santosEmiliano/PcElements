using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//IMPORTAR PARA LA CREACION DE PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml;
using System.IO;
using System.Runtime.InteropServices;

namespace WinFormsPcElements
{
    public partial class FormProductosTicket : Form
    {
        //------------------------------ ATRIBUTOS -------------------------------

        //------------------------------ INICIALIZACIONES -------------------------------
        public FormProductosTicket()
        {
            InitializeComponent();
        }

        private void FormProductosTicket_Load(object sender, EventArgs e)
        {
            string tipo = string.Empty;
            double importe = 0;

            columnasProductos();

            // Agrupamos los productos por Id y contamos cuántas veces aparece cada producto // Obtiene el primer producto de cada grupo y cuenta la cantidad
            var productosAgrupados = FormTienda.carrito.GroupBy(p => p.Id).Select(g => new { Producto = g.First(), Cantidad = g.Count() }).ToList();

            // Esto no es necesario Pero si lo quieren ordenar todo bien 
            //productosAgrupados = productosAgrupados.OrderBy(p => p.Producto.Id).ToList();

            // Recorremos los productos agrupados y los agregamos al DataGridView
            foreach (var grupo in productosAgrupados)
            {
                Producto producto = grupo.Producto;  
                int cont = grupo.Cantidad;


                int n = dGVProductos.Rows.Add();
                DataGridViewRow fila = dGVProductos.Rows[n];

                fila.Cells["Cantidad"].Value = cont.ToString();
                fila.Cells["NombreProducto"].Value = producto.Nombre;

                tipo = tipoProducto(producto);
                fila.Cells["TipoProducto"].Value = tipo; 

                // Precio unitario del producto
                fila.Cells["PrecioUnitario"].Value = producto.Precio;

                // Calculamos el importe (precio * cantidad)
                importe = cont * producto.Precio;
                fila.Cells["Importe"].Value = importe;
            }

            generarPDF();

            this.Dispose();
        }



        //------------------------------ ACCIONES -------------------------------

        private void columnasProductos()
        {
            //Nombre Colum //Text Colum
            dGVProductos.Columns.Add("Cantidad", "Cantidad");
            dGVProductos.Columns.Add("NombreProducto", "Nombre del Producto");
            dGVProductos.Columns.Add("TipoProducto", "Tipo de Producto");
            dGVProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dGVProductos.Columns.Add("Importe", "Importe");
        }

        private string tipoProducto(Producto producto)
        {
            string tipo = string.Empty;
            switch (producto.Tipo)
            {
                case 0:
                    tipo = "MotherBoard";
                    break;
                case 1:
                    tipo = "Procesador";
                    break;
                case 2:
                    tipo = "Tarjeta Grafica";
                    break;
                case 3:
                    tipo = "Fuente de Poder";
                    break;
                case 4:
                    tipo = "RAM";
                    break;
            }
            return tipo;
        }

        private void generarPDF()
        {
            SaveFileDialog pdf = new SaveFileDialog();
            pdf.FileName = $"Ticket {FormTicket.folio.ToString()}.pdf";

            string html = Properties.Resources.ticket.ToString(); //Variable para acceder a html



            html = html.Replace("000001", FormTicket.folio.ToString());
            html = html.Replace("dd/mm/aaaa", DateTime.Now.ToString("dd/MM/yyyy"));
            html = html.Replace("Nom_Cliente", FormPortada.usuario.Name);

            string filas = "";
            double subTotal = 0;
            double total = 0;

            foreach (DataGridViewRow row in dGVProductos.Rows)
            {
                filas += "<tr>";
                filas += $"<td> {row.Cells["Cantidad"].Value} </td>";
                filas += $"<td> {row.Cells["NombreProducto"].Value} </td>";
                filas += $"<td> {row.Cells["TipoProducto"].Value} </td>";
                filas += $"<td> {row.Cells["PrecioUnitario"].Value} </td>";
                filas += $"<td> {"$" + row.Cells["Importe"].Value} </td>";
                filas += "</tr>";

                if (row.Cells["Importe"].Value != null)
                {
                    subTotal += Convert.ToDouble(row.Cells["Importe"].Value);
                }

            }

            total = (float)subTotal * 1.6;
            html = html.Replace("_FILAS", filas);
            html = html.Replace("_SubTotal", subTotal.ToString());
            html = html.Replace("_Total", total.ToString());


            //Si el cuadro de dialogo si se pudo ejecutar hacer la condicion
            if (pdf.ShowDialog() == DialogResult.OK)
            {
                //Creamos un archivo de memoria 
                using (FileStream stream = new FileStream(pdf.FileName, FileMode.Create))
                {
                    //Creamos el documento
                    Document pdfDocument = new Document(PageSize.A4, 25, 25, 25, 25);

                    //Cada cambio que se haga en el pdf se guardara en la memoria
                    PdfWriter writer = PdfWriter.GetInstance(pdfDocument, stream);

                    //Abrimos el pdf
                    pdfDocument.Open();

                    //Añadimos el html
                    pdfDocument.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.circlePcElementsLogo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDocument.LeftMargin, pdfDocument.Top - 60);
                    pdfDocument.Add(img);



                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocument, sr);
                    }

                    //Cerramos el pdf
                    pdfDocument.Close();
                    //Cerramos la memoria en donde se creo el archivo
                    stream.Close();
                }
            }
        }
    }
}