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
    public partial class listaDeudores : Form
    {
        private List<ClienteDeudor> deudores;
        public listaDeudores()
        {
            InitializeComponent();
            deudores = new List<ClienteDeudor>();

            CargarCsv();
            EnviarADataGridView();

        }

        private void EnviarADataGridView()
        {
            foreach (ClienteDeudor deudor in  deudores) 
            {
                deudoresDGV.Rows.Add(
                    deudor.Nombre,
                    deudor.Cantidad,
                    deudor.Notas);
            }
        }

        private void CargarCsv()
        {
           
            string rutaArchivo = "listaDeudores.csv";
            string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);

            if (File.Exists(rutaCompleta))
            {
                string[] lineasDeudores = System.IO.File.ReadAllLines(rutaCompleta);

                foreach (string linea in lineasDeudores.Skip(1))
                {
                    string[] items = linea.Split(',');
                    ClienteDeudor clienteDeudor = new ClienteDeudor();

                    clienteDeudor.Nombre = items[0];
                    clienteDeudor.Cantidad = items[1];
                    clienteDeudor.Notas = items[2];
                    deudores.Add(clienteDeudor);
                }
            }

            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo))
                    {
                        // Escribimos la primera línea con los encabezados (opcional)
                        writer.WriteLine("Nombre,Cantidad,Notas");
                    }

                    Console.WriteLine($"Archivo CSV creado en: {rutaArchivo}");
                    CargarCsv();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el archivo CSV: {ex.Message}");
                }
            }
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            ExtraerDeudoresDelDGV();
            GuardarDeudoresEnCSV();
        }

        private void ExtraerDeudoresDelDGV()
        {
            deudores.Clear();

            foreach (DataGridViewRow fila in deudoresDGV.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Obtener datos de cada celda en la fila
                    string nombre = fila.Cells["nombreColumn"].Value.ToString();
                    string cantidad = fila.Cells["cantidadColumn"].Value.ToString();
                    string notas = fila.Cells["notasColumn"].Value.ToString();

                    // Crear un nuevo cliente deudor y agregarlo a la lista
                    ClienteDeudor clienteDeudor = new ClienteDeudor
                    {
                        Nombre = nombre,
                        Cantidad = cantidad,
                        Notas = notas
                    };

                    deudores.Add(clienteDeudor);
                }
            }
        }

        private void GuardarDeudoresEnCSV()
        {
            try
            {
                string rutaArchivo = "listaDeudores.csv";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaArchivo);

                using (StreamWriter writer = new StreamWriter(rutaCompleta))
                {
                    // Escribir el encabezado
                    writer.WriteLine("Nombre,Cantidad,Notas");

                    // Escribir cada deudor
                    foreach (ClienteDeudor deudor in deudores)
                    {
                        writer.WriteLine($"{deudor.Nombre},{deudor.Cantidad},{deudor.Notas}");
                    }
                }

                MessageBox.Show("Lista de deudores guardada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la lista de deudores: {ex.Message}");
            }
        }

        private void deudoresDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == deudoresDGV.Columns["eliminarIB"].Index)
            {
                // Obtén la fila que se va a eliminar
                DataGridViewRow row = deudoresDGV.Rows[e.RowIndex];

                // Verifica si la fila no está vacía y no es la fila nueva sin confirmar
                if (row != null && !row.IsNewRow)
                {
                    // Elimina la fila
                    deudoresDGV.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
