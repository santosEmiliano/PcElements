using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Plottables;

namespace WinFormsPcElements
{
    public partial class UserControlAdminEstadisticas : UserControl
    {
        public UserControlAdminEstadisticas()
        {
            InitializeComponent();
        }

        private void UserControlAdminEstadisticas_Load(object sender, EventArgs e)
        {
            GraficaCircular();
            GraficaPie();
            CalcularTotal();

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            ComponentsTheme();
        }

        private void ComponentsTheme()
        {
            // Fuentes
            labelProductos.ForeColor = AppTheme.font;
            labelUsuarios.ForeColor = AppTheme.font;
            labelTotal.ForeColor = AppTheme.font;

            // Paneles principales
            tableLayoutPanelMain.BackColor = AppTheme.background;
        }

        private void CalcularTotal()
        {
            double total = 0;

            List<Venta> ventas = new List<Venta>();
            AdminBDVentas bdV = new AdminBDVentas();
            AdminBDProductos bdP = new AdminBDProductos();

            ventas = bdV.PeticionVentas();

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                total += p.Precio;
            });

            labelTotal.Text = $"Ventas Totales De La Empresa: ${total}";
        }

        private void GraficaCircular()
        {
            double mB = 0, ram = 0, grafica = 0, fuente = 0, procesador = 0;

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentas();

            AdminBDProductos bdP = new AdminBDProductos();

            ventas.ForEach(x =>
            {
                Producto p = bdP.Consulta(x.IdProducto);

                switch (p.Tipo)
                {
                    case 0:
                        mB += p.Precio;
                        break;
                    case 1:
                        procesador += p.Precio;
                        break;
                    case 2:
                        grafica += p.Precio;
                        break;
                    case 3:
                        fuente += p.Precio;
                        break;
                    case 4:
                        ram += p.Precio;
                        break;
                }
            });

            double[] values = { 0, mB, ram, grafica, fuente, procesador };

            bool flag = false;

            var radialGaugePlot = formsPlotProductos.Plot.Add.RadialGaugePlot(values);

            radialGaugePlot.Labels = new string[] { "", "MotherBoards", "RAMs", "Gráficas", "Fuentes", "Procesadores" };

            radialGaugePlot.LabelPositionFraction = 0.5;

            formsPlotProductos.Refresh();
        }

        private void GraficaPie()
        {
            double[] usuarios = { 0, 0, 0, 0, 0 };

            AdminBDVentas bdV = new AdminBDVentas();
            List<Venta> ventas = bdV.PeticionVentas();

            AdminBDProductos bdP = new AdminBDProductos();

            ventas.ForEach(v =>
            {
                Producto p = bdP.Consulta(v.IdProducto);

                switch (v.IdUsuario)
                {
                    case 2:
                        usuarios[0] += p.Precio;
                        break;
                    case 3:
                        usuarios[1] += p.Precio;
                        break;
                    case 4:
                        usuarios[2] += p.Precio;
                        break;
                    case 5:
                        usuarios[3] += p.Precio;
                        break;
                    case 6:
                        usuarios[4] += p.Precio;
                        break;
                }
            });

            List<PieSlice> slices =
            [
                new PieSlice() { Value = usuarios[0], FillColor = Colors.Red, Label = $"Erick Calderón: ${usuarios[0]}", LegendText = "EK" },
                new PieSlice() { Value = usuarios[1], FillColor = Colors.Orange, Label = $"Enrique Dueñas: ${usuarios[1]}", LegendText = "ED" },
                new PieSlice() { Value = usuarios[2], FillColor = Colors.Gold, Label = $"Emiliano Santos: ${usuarios[2]}", LegendText = "ES" },
                new PieSlice() { Value = usuarios[3], FillColor = Colors.Green, Label = $"Invitado: ${usuarios[3]}", LegendText = "Inv" },
                new PieSlice() { Value = usuarios[4], FillColor = Colors.Blue, Label = $"Georgina Salazar: ${usuarios[4]}", LegendText = "GS" },
            ];

            var pie = formsPlotUsuarios.Plot.Add.Pie(slices);

            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 1.4;

            formsPlotUsuarios.Plot.ShowLegend();

            formsPlotUsuarios.Plot.Axes.Frameless();
            formsPlotUsuarios.Plot.HideGrid();

            formsPlotUsuarios.Refresh();
        }
    }
}
