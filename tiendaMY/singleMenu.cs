using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;


namespace tiendaMY
{
    public partial class form : Form
    {
        private decimal tasa;




        public form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            GetTasaBCVAsync();
            IniciarPaneles();

        }

        private void IniciarPaneles()
        {

            // 0 - Dashboard
            // 1 - Facturar
            // 2 - Inventario
            // 3 - Ajustes
            // 4 - Deudores

            Dashboard dashboard = new Dashboard() { TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            Facturar facturar = new Facturar() { TopLevel = false, TopMost = true };
            facturar.FormBorderStyle = FormBorderStyle.None;
            Inventario inventario = new Inventario() { TopLevel = false, TopMost = true };
            inventario.FormBorderStyle = FormBorderStyle.None;
            listaDeudores listaDeudores = new listaDeudores() { TopLevel = false, TopMost = true };
            listaDeudores.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Add(dashboard);
            panel1.Controls.Add(facturar);
            panel1.Controls.Add(inventario);
            panel1.Controls.Add(listaDeudores);
        }

        private async Task GetTasaBCVAsync()
        {
            string url = "https://www.bcv.org.ve";
            // Crear una instancia de HtmlWeb
            HtmlWeb web = new HtmlWeb();

            try
            {
                Configuracion.TasaDolar = 35;
                // Cargar el documento HTML desde la URL
                HtmlDocument doc = await Task.Run(() => web.Load(url));

                // Utilizar XPath para encontrar el elemento que contiene el precio del dólar
                // En este caso, se utiliza la clase del div que mencionaste
                HtmlNode nodoPrecioDolar = doc.DocumentNode.SelectSingleNode("//div[@id='dolar']//div[@class='col-sm-6 col-xs-6 centrado']/strong");

                // Obtener el contenido del nodo (en este caso, el precio del dólar)
                string precioDolar = nodoPrecioDolar.InnerText;

                decimal precioDolarDecimal = Convert.ToDecimal(precioDolar);

                // Puedes utilizar el precio del dólar como desees en tu aplicación
                Configuracion.TasaDolar = Convert.ToDecimal(precioDolarDecimal);
                MessageBox.Show($"Tasa del dolar cargada, tasa: {Configuracion.TasaDolar:f2}");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con el BCV, puedes modificar la tasa en ajustes");
                Configuracion.TasaDolar = 35;
            }
        }

        // click on facturarr button panel access
        private void button1_Click(object sender, EventArgs e)
        {
            AccederAPanel("Dashboard");
        }

        private void AccederAPanel(string key)
        {
            // Como el panel es una lista de forms, podemos acceder a cada form del panel segun su indice.
            switch (key)
            {

                // 0 - Dashboard
                // 1 - Facturar
                // 2 - Inventario
                // 3 - Ajustes
                // 4 - Deudores

                case "Dashboard":
                    ShowPanel("Dashboard");
                    break;

                case "Facturacion":
                    ShowPanel("Facturacion");
                    break;

                case "Inventario":
                    ShowPanel("Inventario");
                    break;

                case "Ajustes":
                    ShowPanel("Ajustes");
                    break;

                case "Lista deudores":
                    ShowPanel("Lista deudores");
                    break;


            }
        }

        private void ShowPanel(string key)
        {
            panel1.Controls[0].Hide();

            foreach(Form form in panel1.Controls) { 

               if (form.Text == key)
                {
                    form.Show();
                    form.BringToFront();
                }

            }
        }

        private void VerificarGuardado(Form form)
        { 
            //agregar form sin verificar, ya que controls esta vacio porque es una nueva sesion

            if (panel1.Controls.Count == 0) 
            {
                panel1.Controls.Clear();
                form.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Add(form);
                form.Show();
                form.BringToFront();
            }

            // ahora cuando hay un form en la lista controls del panel, verificar si es inventario o lista deudores

            else
            {
                if (panel1.Controls[0].Text == "Inventario" || panel1.Controls[0].Text == "Lista deudores")
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de salir? Se borraran los datos no guardados", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        panel1.Controls.Clear();
                        form.FormBorderStyle = FormBorderStyle.None;
                        panel1.Controls.Add(form);
                        form.Show();
                        form.BringToFront();
                    }
                    // si  DialogResult es no, permanecer en el form
                }
                // si no es  ni inventario o Lista deudores, iniciar sin mas
                else
                {
                    panel1.Controls.Clear();
                    form.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Add(form);
                    form.Show();
                    form.BringToFront();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccederAPanel("Facturacion");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccederAPanel("Inventario");
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            AccederAPanel("Lista deudores");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes() { TopLevel = false, TopMost = true };
            ajustes.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(ajustes);
            AccederAPanel("Ajustes");
            
        }
    }
}
