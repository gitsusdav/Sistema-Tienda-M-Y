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
                decimal precioDolarRecortado = precioDolarDecimal / 100000000;

                // Puedes utilizar el precio del dólar como desees en tu aplicación
                Configuracion.TasaDolar = Convert.ToDecimal(precioDolarRecortado);
                MessageBox.Show($"Tasa del dolar cargada, tasa: {Configuracion.TasaDolar}");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion con el BCV, puedes modificar la tasa en ajustes");
                Configuracion.TasaDolar = 35;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel dashboard = new Panel() { TopLevel = false, TopMost = true };
            VerificarGuardado(dashboard);
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
             Facturar facturar = new Facturar() { TopLevel = false, TopMost = true };
             VerificarGuardado(facturar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario() { TopLevel = false, TopMost = true };
            VerificarGuardado(inventario);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            listaDeudores listaDeudores = new listaDeudores() { TopLevel = false, TopMost = true };
            VerificarGuardado(listaDeudores);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes() { TopLevel = false, TopMost = true };
            VerificarGuardado(ajustes);
        }
    }
}
