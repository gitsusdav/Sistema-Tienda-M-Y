using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace tiendaMY
{
    public partial class Facturar : Form
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Producto> carrito;
        public decimal tasa;
        private bool clienteEncontrado;
       

        public Facturar()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            productos = new List<Producto>();
            carrito = new List<Producto>();
            facturaDGV.RowHeadersVisible = false;
            facturaDGV.ReadOnly = true;
            tasa = Configuracion.TasaDolar;
            puntoDeVentaRB.Checked = true;
            clienteEncontrado = false;
            // carga de los csv
            CargarCsvClientes();
            CargarCsvProductos();
            

        }



        private void Facturar_Load(object sender, EventArgs e)
        {
            RefrescarTotal();
        }

        private void nombreProductoLbl_Click(object sender, EventArgs e)
        {

        }


        private void CargarCsvProductos()
        {

            string nombreArchivo = "inventario.csv";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);

            if (File.Exists(rutaArchivo)){
                LeerArchivoInventario(rutaArchivo);
            }

            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        // Escribimos la primera línea con los encabezados (opcional)
                        writer.WriteLine("Codigo,Nombre,Descripcion,Cantidad,PrecioCompra,PrecioDeVenta");
                    }

                    Console.WriteLine($"Archivo CSV creado en: {rutaArchivo}");
                    LeerArchivoInventario(rutaArchivo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el archivo CSV: {ex.Message}");
                }
                
            }


            
        }

        private void LeerArchivoInventario(string rutaArchivo)
        {
            string[] lineasProductos = System.IO.File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineasProductos.Skip(1))
            {
                var line = linea;
                string[] valoresObjeto = linea.Split(',');
                Producto producto = new Producto();

                producto.Codigo = valoresObjeto[0];
                producto.Nombre = valoresObjeto[1];
                producto.Descripcion = valoresObjeto[2];
                producto.Cantidad = Convert.ToInt32(valoresObjeto[3]);
                producto.PrecioCompra = Convert.ToDouble(valoresObjeto[4]);
                producto.PrecioDeVenta = Convert.ToDouble(valoresObjeto[5]);
                productos.Add(producto);

            }
        }

        private void CargarCsvClientes()
        {
            string nombreArchivo = "clientes.csv";
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);

            if (File.Exists(rutaArchivo)) {
                LeerArchivoCliente(rutaArchivo);
            }

            else {
                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        // Escribimos la primera línea con los encabezados (opcional)
                        writer.WriteLine("Nombre,Cedula");
                    }

                    Console.WriteLine($"Archivo CSV creado en: {rutaArchivo}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el archivo CSV: {ex.Message}");
                }
                LeerArchivoCliente(rutaArchivo);
            }

            

        }

        private void LeerArchivoCliente(string rutaArchivo)
        {
            string[] filasClientes = System.IO.File.ReadAllLines(rutaArchivo);

            foreach (var fila in filasClientes.Skip(1))
            {
                string[] item = fila.Split(',');
                Cliente cliente = new Cliente();
                cliente.Nombre = item[0];
                cliente.Cedula = item[1];
                clientes.Add(cliente);
            }

        }

        private void facturarButton_Click(object sender, EventArgs e)
        {
            CrearFactura();
            GenerarVenta();
            ModificarCsv();
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            cedulaTB.Clear();
            nombreTB.Clear();
            codigoTB.Clear();
            cantidadTB.Text = "0";
            facturaDGV.Rows.Clear();
            RefrescarTotal();
        }

        private void ModificarCsv()
        {
            // modificar csv clientes
            if (!clienteEncontrado)
            {
                Cliente cliente = new Cliente();
                cliente.Cedula = cedulaTB.Text;
                cliente.Nombre = nombreTB.Text;
                clientes.Add(cliente);
                string pathClientes = "clientes.csv";
                System.IO.File.AppendAllText(pathClientes, $"\n{cliente.Nombre},{cliente.Cedula}");
            }

            //modificar csv productos
            string pathInventario = "inventario.csv";

            using (StreamWriter sw = new StreamWriter(pathInventario))
            {
                // Escribir encabezados al archivo CSV
                sw.WriteLine("Codigo,Nombre,Descripcion,Cantidad,Precio Compra,Precio Venta");

                // Escribir información actualizada de productos al archivo CSV
                foreach (Producto producto in productos)
                {
                    sw.WriteLine($"{producto.Codigo},{producto.Nombre},{producto.Descripcion},{producto.Cantidad},{producto.PrecioCompra},{producto.PrecioDeVenta}");
                }
            }
        }

        private void CrearFactura()
        {
            string fechaActual = DateTime.Now.ToString("dd-MM-yy");
            string horaActual = DateTime.Now.ToString("HH:mm");
            string metodoDePago = GetMetodoDePago();

            try
            {
                string pathFacturas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas");
                if (!Directory.Exists(pathFacturas))
                {
                    Directory.CreateDirectory(pathFacturas);
                }

                string nombreCliente = $"{nombreTB.Text}";
       

                string numeroFactura = LeerContador();

                
                string numeroFacturaString = numeroFactura.ToString().PadLeft(4, '0');
                string nombreArchivo = $"{numeroFacturaString}.pdf";
                string pathCompleto = Path.Combine(pathFacturas, nombreArchivo);

                Document doc = new Document(); // Create a new instance of Document

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pathCompleto, FileMode.Create));
                doc.Open();

           

                Paragraph tituloEmpresa = new Paragraph("PAPELERIA M&Y", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18));
                tituloEmpresa.Alignment = Element.ALIGN_CENTER;
                doc.Add(tituloEmpresa);

                Paragraph fecha = new Paragraph($"Fecha: {fechaActual}\nHora: {horaActual}\n\n");
                fecha.Alignment = Element.ALIGN_CENTER;
                doc.Add(fecha);

                Paragraph numeroFacturaParagraph = new Paragraph($"Factura N°: {numeroFactura}\n\n");
                numeroFacturaParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(numeroFacturaParagraph);

                Paragraph encabezado = new Paragraph("Factura de Compra\n\n");
                encabezado.Alignment = Element.ALIGN_CENTER;
                doc.Add(encabezado);

                Paragraph datosCliente = new Paragraph($"Nombre del cliente: {nombreCliente}\n\n\n");
                datosCliente.Alignment = Element.ALIGN_LEFT;
                doc.Add(datosCliente);

        

                PdfPTable table = new PdfPTable(5);
                table.AddCell("Código");
                table.AddCell("Nombre");
                table.AddCell("Cantidad");
                table.AddCell("Precio");
                table.AddCell("Total");

                foreach (DataGridViewRow fila in facturaDGV.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string codigo = fila.Cells["codigoC"].Value.ToString();
                        string nombre = fila.Cells["nombreColumn"].Value.ToString();
                        double cantidad = Convert.ToDouble(fila.Cells["cantidadColumn"].Value);
                        double precioUnitario = Convert.ToDouble(fila.Cells["precioUnitarioColumn"].Value);
                        double totalLinea = cantidad * precioUnitario;
            

                        table.AddCell(codigo);
                        table.AddCell(nombre);
                        table.AddCell(cantidad.ToString());
                        table.AddCell(precioUnitario.ToString("N2"));
                        table.AddCell(totalLinea.ToString("N2"));
                      
                    }
                }

                doc.Add(table);

                doc.Add(new Paragraph($"\n\n{totalBsTB.Text}\n"));
                doc.Add(new Paragraph(totalUSDTB.Text));
                doc.Add(new Paragraph($"Metodo de pago: {metodoDePago}"));


                doc.Close();
                writer.Close();

                MessageBox.Show($"Factura generada con éxito. Puede encontrarla en el panel de ventas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al generar la factura: {ex.Message}");
            }

        }

        private void ActualizarContador()
        {
            string rutaContador = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contador.txt");
            string[] contador = System.IO.File.ReadAllLines(rutaContador);
            int numero = Convert.ToInt32(contador[0]);
            int nuevoNumero = numero + 1;

            string nuevoNumero_string;

            if (nuevoNumero < 10)
            {
                nuevoNumero_string = $"000{nuevoNumero}";

            }

            else if (nuevoNumero > 10 && nuevoNumero < 100)
            {
                nuevoNumero_string = $"00{nuevoNumero}";
            }

            else if (nuevoNumero > 100 && nuevoNumero < 1000)
            {
                nuevoNumero_string = $"0{nuevoNumero}";
            }

            else 
            {
                nuevoNumero_string = $"{nuevoNumero}";
            }


            System.IO.File.WriteAllText(rutaContador, nuevoNumero_string);

        }

        private string GetMetodoDePago()
        {
            string metodoDePago = "";

            if (puntoDeVentaRB.Checked)
            {
                metodoDePago = puntoDeVentaRB.Text;
            }

            else if (pagoMovilRB.Checked)
            {
                metodoDePago = pagoMovilRB.Text;
            }

            else if (dolaresRB.Checked)
            {
                metodoDePago = pagoMovilRB.Text;
            }

            else if (zelleRB.Checked)
            {
                metodoDePago = zelleRB.Text;
            }

            else if (bsRB.Checked)
            {
                metodoDePago = bsRB.Text;
            }

            else
            {
                metodoDePago = "No definido";
            }


            return metodoDePago;
        }

        private string LeerContador()
        {
            string rutaContador = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contador.txt");
            string[] contador = System.IO.File.ReadAllLines(rutaContador);
            string numero = contador[0];
            return numero;
        }

        private void GenerarVenta()
        {
            decimal ganancia = 0;
            decimal total = 0;
            DateTime fecha = DateTime.Now;

            foreach (var producto in carrito)
            {
                ganancia += (decimal)(producto.PrecioDeVenta - producto.PrecioCompra);
                total += Convert.ToDecimal(producto.PrecioCompra);
            }

            Venta venta = new Venta();
            venta.NombreCliente = nombreTB.Text;
            venta.MetodoDePago = GetMetodoDePago();
            venta.Id = LeerContador();
            venta.TotalVenta = total;
            venta.Ganancia = ganancia;
            venta.Fecha = fecha;

            
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ventas.csv");

            // anadir venta al csv ventas para analizar ventas despues
            System.IO.File.AppendAllText(path, $"\n{venta.NombreCliente},{venta.MetodoDePago},{venta.Id},{venta.TotalVenta},{venta.Ganancia},{venta.Fecha}");
            ActualizarContador();

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            string clienteBuscado = cedulaTB.Text;

            foreach (var cliente in clientes)
            {
                if (clienteBuscado == cliente.Cedula)
                {
                    clienteEncontrado = true;
                    nombreTB.Text = cliente.Nombre;
                    break;
                }
            }

            if (!clienteEncontrado)
            {
                MessageBox.Show("Cliente no encontrado, se agregaran datos del nuevo cliente");
                clienteEncontrado = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            // uso un try catch para capturar si hay alguna excepcion por uso de caracteres no numericos
            // en la casilla cantidad
            try
            {
                string codigoProducto = codigoTB.Text;
                int cantidad = Convert.ToInt32(cantidadTB.Text);
                bool productoEncontrado = false;


                // verificar que la cantidad no sea 0
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad solicitada no puede ser un numero negativo o menor que 0");
                    productoEncontrado = true;
                    return;
                }

                /// busqueda de producto

                foreach (var producto in productos)
                {
                    if (codigoProducto != producto.Codigo)
                    {
                        continue;
                    }

                    else if (codigoProducto == producto.Codigo && producto.Cantidad < 1)
                    {
                        MessageBox.Show("El producto no esta disponible, comprar mas");
                        productoEncontrado = true;
                        break;

                    }

                    else if (codigoProducto == producto.Codigo && cantidad > producto.Cantidad)
                    {
                        MessageBox.Show("La cantidad solicitada es mayor al stock");
                        productoEncontrado = true;
                        break;
                    }

                    else if (codigoProducto == producto.Codigo)
                    {

                        // anadir a carrito para calcular ganancia, bucle for para andir segun cantidad
                        for (int i = 0; i < cantidad; i++)
                        {
                            carrito.Add(producto);
                        }

                        //calcular precio total
                        decimal precioTotal = (decimal)(producto.PrecioDeVenta * cantidad);
                        // anadir a datagridview
                        facturaDGV.Rows.Add(codigoProducto, producto.Nombre, producto.PrecioDeVenta, cantidad, precioTotal);
                        // marcar booleano como true
                        productoEncontrado = true;
                        //reducir stock segun la cantidad que haya seleccionado el cliente
                        producto.Cantidad -= cantidad;
                        break;
                    }

                }

                // mostrar mensaje si no se encontro el producto
                if (!productoEncontrado)
                {
                    MessageBox.Show("Producto no encontrado, revisa lista de productos si desconoce el codigo");
                }

                RefrescarTotal();
            }

            catch(Exception ex) 
            {
                MessageBox.Show("La casilla cantidad no puede estar vacia");
            }

        }

        private void RefrescarTotal()
        {
            
            decimal totalBs = 0;
            decimal totalUs = 0;

            foreach(DataGridViewRow fila in facturaDGV.Rows)
            {
                // Asegúrate de que no estás procesando la fila de encabezado
                if (!fila.IsNewRow)
                {
                    // verificamos que la fila no sea nula
                    if (fila.Cells["precioTotalColumn"].Value != null)
                    {
                        decimal precio = (decimal)(fila.Cells["precioTotalColumn"].Value);
                        totalUs += precio;
                    }
                }
            }

            totalBs = totalUs * tasa;

            totalBsTB.Text = $"Total en Bolivares: Bs.{totalBs:f2}";
            totalUSDTB.Text = $"Total en Dolares: ${totalUs:f2}";
        }

        private void facturaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == facturaDGV.Columns["eliminarPB"].Index)
            {
                // Obtén la fila que se va a eliminar
                DataGridViewRow row = facturaDGV.Rows[e.RowIndex];

                // Verifica si la fila no está vacía y no es la fila nueva sin confirmar
                if (row != null && !row.IsNewRow)
                {
                    
                    string codigo = facturaDGV.Rows[e.RowIndex].Cells["codigoC"].Value.ToString();
                    int cantidad = Convert.ToInt32(facturaDGV.Rows[e.RowIndex].Cells["cantidadColumn"].Value);

                    //remover producto del carrito
                    for (int i = carrito.Count - 1; i >= 0; i--)
                    {
                        if (carrito[i].Codigo == codigo)
                        {
                            carrito.RemoveAt(i);
                        }
                    }
                    // devuelve el producto al inventario
                    foreach (var producto in productos)
                    {
                        if (producto.Codigo == codigo)
                        {
                            producto.Cantidad += cantidad;
                        }
                    }

                    // Elimina la fila
                    facturaDGV.Rows.RemoveAt(e.RowIndex);
                }

                // eliminar del carrito

                
            }

            RefrescarTotal();

        }

        private void notasRTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void cantidadTB_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int cantidad = Convert.ToInt32(cantidadTB.Text);
                validacionLbl.Visible = false;
            }

            catch
            {
                cantidadTB.Clear();
                validacionLbl.Visible = true;

            }

        }

        private void pagoMovilRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zelleRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bsRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dolaresRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void puntoDeVentaRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metodosDePagolbl_Click(object sender, EventArgs e)
        {

        }

        private void busquedaLINQbutton_Click(object sender, EventArgs e)
        {
            FiltroLINQ filtroLINQ = new FiltroLINQ();
            filtroLINQ.ShowDialog();
        }

        private void Facturar_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void cedulaLbl_Click(object sender, EventArgs e)
        {

        }

        private void cedulaTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
