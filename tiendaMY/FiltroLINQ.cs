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
    public partial class FiltroLINQ : Form
    {
        private List<Producto> inventario;

        public FiltroLINQ()
        {
            InitializeComponent();
            inventario = new List<Producto>();
            listaProductos.RowHeadersVisible = false;
            listaProductos.ReadOnly = true;

            string rutaArchivo = "inventario.csv";
            string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);
            string[] lineasProductos = File.ReadAllLines(rutaCompleta);

            foreach (string linea in lineasProductos.Skip(1))
            {
                string[] valoresObjeto = linea.Split(',');
                Producto producto = new Producto();

                producto.Codigo = valoresObjeto[0];
                producto.Nombre = valoresObjeto[1];
                producto.Descripcion = valoresObjeto[2];
                producto.Cantidad = Convert.ToInt32(valoresObjeto[3]);
                producto.PrecioCompra = Convert.ToDouble(valoresObjeto[4]);
                producto.PrecioDeVenta = Convert.ToDouble(valoresObjeto[5]);

                inventario.Add(producto);
            }

            foreach (Producto producto in inventario)
            {
                listaProductos.Rows.Add(
                    producto.Nombre,
                    producto.Codigo
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaProductos.RowHeadersVisible = false;
            

        }

        private void busquedaTB_TextChanged(object sender, EventArgs e)
        {
            // Obtén el texto de búsqueda del TextBox
            string textoBusqueda = busquedaTB.Text.ToLower();

            // Filtra la lista de productos usando LINQ
            var productosFiltrados = inventario
                .Where(producto => producto.Nombre.ToLower().Contains(textoBusqueda) || producto.Codigo.ToLower().Contains(textoBusqueda))
                .ToList();

            // Actualiza el DataGridView con los productos filtrados
            MostrarProductosEnDataGridView(productosFiltrados);
        }

        private void MostrarProductosEnDataGridView(List<Producto> productosFiltrados)
        {
            listaProductos.Rows.Clear();

            // Agrega las filas correspondientes a los productos filtrados
            foreach (Producto producto in productosFiltrados)
            {
                listaProductos.Rows.Add(
                    producto.Nombre,
                    producto.Codigo
                );
            }
        }
    }
}
