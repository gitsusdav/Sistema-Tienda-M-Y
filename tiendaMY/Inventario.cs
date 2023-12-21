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

namespace tiendaMY
{
    public partial class Inventario : Form
    {
        private List<Producto> listaProductos;
        private List<Producto> listaProductosTest;
        private List<Producto> listaProductosTest2;
        private bool nuloEnLaLista;




        public Inventario()
        {

            InitializeComponent();
            //inventarioDGV.RowHeadersVisible = false;
            listaProductos = new List<Producto>();
           
            string rutaArchivo = "inventario.csv";  
            string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
            inventarioDGV.RowPostPaint += inventarioDGV_RowPostPaint;
            


            string[] lineasProductos = File.ReadAllLines(rutaCompleta);

            foreach(string linea in lineasProductos.Skip(1)) 
            {
                string[] valoresObjeto = linea.Split(',');
                Producto producto = new Producto();

                producto.Codigo = valoresObjeto[0];
                producto.Nombre = valoresObjeto[1];
                producto.Descripcion = valoresObjeto[2];
                producto.Cantidad = Convert.ToInt32(valoresObjeto[3]);
                producto.PrecioCompra = Convert.ToDouble(valoresObjeto[4]);
                producto.PrecioDeVenta = Convert.ToDouble(valoresObjeto[5]);

                listaProductos.Add(producto);
            }
            
            foreach (Producto producto in listaProductos)
            {
                inventarioDGV.Rows.Add(
                    producto.Codigo,
                    producto.Nombre,
                    producto.Descripcion,
                    producto.Cantidad,
                    producto.PrecioCompra,
                    producto.PrecioDeVenta
                );
            }

        }


        private void inventarioDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Obtener el número de fila actual
            string numeroFila = (e.RowIndex + 1).ToString();

            // Crear un objeto Font para el número de fila
            Font font = new Font(inventarioDGV.DefaultCellStyle.Font.FontFamily, 8.0f, FontStyle.Regular, GraphicsUnit.Point);

            // Crear un objeto Brush para el color del número de fila
            Brush brush = SystemBrushes.ControlText;

            // Calcular la posición para el número de fila
            float x = e.RowBounds.Location.X + 20; // Puedes ajustar la posición según tus necesidades
            float y = e.RowBounds.Location.Y + ((e.RowBounds.Height - font.Height) / 2);

            // Dibujar el número de fila en el DataGridView
            e.Graphics.DrawString(numeroFila, font, brush, x, y);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            bool nuloEnLaLista = false;
            bool casillaEsNull = false;
            // Limpiar la lista de productos
            int i = 0;
            int j = 0;
            listaProductos.Clear();

            try
            {
               
                // Recorrer las filas del DataGridView y agregar cada producto a la lista
                foreach (DataGridViewRow row in inventarioDGV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        casillaEsNull = false;

                        for (int columnIndex = 0; columnIndex < row.Cells.Count; columnIndex++)
                        {
                            // Saltar la celda en la posición 6
                            if (columnIndex == 6)
                            {
                                j++;
                                continue;
                            }

                            DataGridViewCell cell = row.Cells[columnIndex];

                            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            {
                                casillaEsNull = true;
                                nuloEnLaLista = true;
                                break;
                            }

                            
                        }

                        Producto producto = new Producto
                        {
                            Nombre = row.Cells["nombreColumn"].Value.ToString(),
                            Descripcion = row.Cells["descripcionColumn"].Value.ToString(),
                            PrecioDeVenta = double.Parse(row.Cells["precioVentaColumn"].Value.ToString()),
                            PrecioCompra = double.Parse(row.Cells["precioCompraColumn"].Value.ToString()),
                            Cantidad = int.Parse(row.Cells["cantidadColumn"].Value.ToString()),
                            Codigo = row.Cells["codigoColumn"].Value.ToString()
                        };
                        listaProductos.Add(producto);

                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error al añadir productos. Ninguna casilla puede ser nula o incluir letras en cantidad y precio. Celda {i +1}");
                listaProductos.Clear();
            }


            if (listaProductos.Count != 0) 
            {
                string rutaArchivo = "inventario.csv";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
                // Guardar la lista de productos en el archivo CSV
                try
                {
                    // Escribir la información actualizada de productos al archivo CSV
                    using (StreamWriter sw = new StreamWriter(rutaCompleta))
                    {
                        // Escribir encabezados al archivo CSV
                        sw.WriteLine("Codigo,NombreCliente,Descripcion,Cantidad,Precio Compra,Precio Venta");

                        // Escribir información actualizada de productos al archivo CSV
                        foreach (Producto producto in listaProductos)
                        {
                            sw.WriteLine($"{producto.Codigo},{producto.Nombre},{producto.Descripcion},{producto.Cantidad},{producto.PrecioCompra},{producto.PrecioDeVenta}");
                        }
                    }

                    MessageBox.Show("Productos guardados correctamente en el archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar productos en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
        }

        private void inventarioDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == inventarioDGV.Columns["eliminarPB"].Index)
            {
                // Obtén la fila que se va a eliminar
                DataGridViewRow row = inventarioDGV.Rows[e.RowIndex];

                // Verifica si la fila no está vacía y no es la fila nueva sin confirmar
                if (row != null && !row.IsNewRow)
                {
                    // Elimina la fila
                    inventarioDGV.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
