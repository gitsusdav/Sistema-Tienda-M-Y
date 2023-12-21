using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tiendaMY
{
    public partial class Panel : Form
    {
        private decimal dineroFacturado;
        private decimal ganancias;
        private List<Venta> ventas;
        private List<Venta> ventasFiltradas;

        public Panel()
        {
            InitializeComponent();

            // cargar ventas
            ventas = new List<Venta>();
            CargarVentasCSV();
            CargarVentasAlDataGridView(ventas);
            ventasFiltradas = new List<Venta>(ventas);
            Calcular(ventasFiltradas);

            // inicializar combobox
            filtroFecha.Text = "Hoy";
            filtroMoneda.Text = "USD";

            //inicializar cantidades
            dineroFacturado = 0;
            ganancias = 0;


            // configurar combobox para que no se puedad editar
            filtroFecha.DropDownStyle = ComboBoxStyle.DropDownList;
           filtroMoneda.DropDownStyle = ComboBoxStyle.DropDownList;

            //quitar indice del datagridview y ponerlo readonly
            ventasDGV.RowHeadersVisible = false;
            ventasDGV.ReadOnly = true;
        }

        private void Calcular(List<Venta> ventas)
        {
            dineroFacturado = 0;
            ganancias = 0;

            // calcular datos
            foreach(Venta venta in ventas) 
            {
                dineroFacturado += venta.TotalVenta;
                ganancias += venta.Ganancia;
                
            }

            int cantidadVentas = ventas.Count;
            ventasLbl.Text = cantidadVentas.ToString();

            if (filtroMoneda.Text == "Bs.D")
            {
                MostrarDatosEnBsD();
            }

            else if (filtroMoneda.Text == "USD")
            {
                MostrarDatosEnUSD();
            }



        }

        private void CargarVentasAlDataGridView(List <Venta> ventas)
        {
            ventasDGV.Rows.Clear();

            if (filtroMoneda.Text == "Bs.D")
            {
                foreach (var venta in ventas)
                {
                    ventasDGV.Rows.Add(
                        venta.NombreCliente,
                        venta.MetodoDePago,
                        venta.Id,
                        $"Bs.D {venta.TotalVenta * Configuracion.TasaDolar:f2}",
                        $"Bs.D {venta.Ganancia * Configuracion.TasaDolar:f2}",
                        venta.Fecha,
                        "PDF"
                    );
                }
            }

            else
            {
                foreach (var venta in ventas)
                {
                    ventasDGV.Rows.Add(
                        venta.NombreCliente,
                        venta.MetodoDePago,
                        venta.Id,
                        $"${venta.TotalVenta}",
                        $"${venta.Ganancia}",
                        venta.Fecha,
                        "PDF"
                    );
                }
            }
        }

        private void CargarVentasCSV()
        {
            // NombreCliente,MetodoDePago,Id,TotalVenta,Ganancia,Fecha
            string ruta = "ventas.csv";
            string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
            string [] lineasVentas = File.ReadAllLines(rutaCompleta);

            foreach(string linea in lineasVentas.Skip(1))
            {
                string[] atributos = linea.Split(',');
                Venta venta = new Venta();
                venta.NombreCliente = atributos[0];
                venta.MetodoDePago = atributos[1];
                venta.Id = atributos[2];
                venta.TotalVenta = Convert.ToDecimal(atributos[3]);
                venta.Ganancia = Convert.ToDecimal((atributos[4]));
                venta.Fecha = DateTime.Parse(atributos[5]);
                ventas.Add(venta);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ventasDGV.Columns["verFacturaLink"].Index)
            {
                // Obtén el valor del enlace en la celda
                string codigoVenta = ventasDGV.Rows[e.RowIndex].Cells["idVentaColumn"].Value.ToString();

                // Construye la ruta completa al archivo PDF
                string rutaPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "facturas", $"{codigoVenta}.pdf");

                // Verifica si el archivo PDF existe antes de intentar abrirlo
                if (File.Exists(rutaPDF))
                {
                    // Abre el archivo PDF con la aplicación predeterminada
                    Process.Start(rutaPDF);
                }
                else
                {
                    MessageBox.Show($"El archivo PDF no existe. Ruta: {rutaPDF}");
                }
            }
        }


        private void Panel_Load(object sender, EventArgs e)
        {
            
        }

        private void filtroMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarVentasAlDataGridView(ventasFiltradas);

            if (filtroMoneda.Text == "Bs.D")
            {
                MostrarDatosEnBsD();
            }

            else if (filtroMoneda.Text == "USD")
            {
                MostrarDatosEnUSD();
            }
        }

        private void MostrarDatosEnUSD()
        {
            cantidadFacturadoLbl.Text = $"${dineroFacturado:f2}";
            gananciaLbl.Text = $"${ganancias:f2}";
        }

        private void MostrarDatosEnBsD()
        {
            decimal dineroFacturadoEnBsD = dineroFacturado * Configuracion.TasaDolar;
            decimal gananciasEnBsD = ganancias * Configuracion.TasaDolar;

            cantidadFacturadoLbl.Text = $"Bs.D {dineroFacturadoEnBsD:f2}";
            gananciaLbl.Text = $"Bs.D {gananciasEnBsD:f2}";
        }

        private void filtroFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el valor seleccionado del ComboBox
            string opcionSeleccionada = filtroFecha.SelectedItem.ToString();

            // Obtén el rango de fechas según la opción seleccionada
            Tuple<DateTime, DateTime> rangoFechas = ObtenerRangoFechas(opcionSeleccionada);

            // Filtra la lista de ventas usando LINQ
            ventasFiltradas = ventas
                .Where(venta => venta.Fecha.Date >= rangoFechas.Item1.Date && venta.Fecha.Date <= rangoFechas.Item2.Date)
                .ToList();
            // Actualiza tu interfaz (puedes mostrar las ventas filtradas en un DataGridView, por ejemplo)


            CargarVentasAlDataGridView(ventasFiltradas);
            Calcular(ventasFiltradas);
        }

        private Tuple<DateTime, DateTime> ObtenerRangoFechas(string opcionSeleccionada)
        {
            DateTime fechaInicio, fechaFin;

            switch (opcionSeleccionada)
            {
                case "Hoy":
                    fechaInicio = DateTime.Today.Date;
                    fechaFin = DateTime.Today.Date;
                    break;
                case "Ayer":
                    fechaInicio = DateTime.Today.AddDays(-1).Date;
                    fechaFin = DateTime.Today.AddDays(-1).Date;
                    break;
                case "Esta semana":
                    fechaInicio = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek).Date;
                    fechaFin = fechaInicio.AddDays(6).Date;
                    break;
                case "Ultimos 15 dias":
                    fechaInicio = DateTime.Today.AddDays(-15).Date;
                    fechaFin = DateTime.Today.Date;
                    break;
                case "Este mes":
                    fechaInicio = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).Date;
                    fechaFin = fechaInicio.AddMonths(1).AddDays(-1).Date;
                    break;
                case "Este año":
                    fechaInicio = new DateTime(DateTime.Today.Year, 1, 1).Date;
                    fechaFin = new DateTime(DateTime.Today.Year, 12, 31).Date;
                    break;
                case "Historicas":
                    // Puedes establecer esta fecha según tus necesidades
                    fechaInicio = DateTime.MinValue.Date;
                    fechaFin = DateTime.MaxValue.Date;
                    break;
                default:
                    // En caso de una opción no reconocida
                    fechaInicio = DateTime.MinValue.Date;
                    fechaFin = DateTime.MaxValue.Date;
                    break;
            }

            return Tuple.Create(fechaInicio, fechaFin);
        }
    }
}
