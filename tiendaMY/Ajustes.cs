using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiendaMY
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
            tasaTB.Text = Configuracion.TasaDolar.ToString();
            alerta.Visible = false;
        }

        private void tasaTB_TextChanged(object sender, EventArgs e)
        {
            decimal temp = Configuracion.TasaDolar;

            try 
            {
                Configuracion.TasaDolar = Convert.ToDecimal(tasaTB.Text);
                alerta.Visible = false;
            }
            catch (Exception ex) 
            {
                alerta.Visible = true;
                Configuracion.TasaDolar = temp;
            }
        }
    }
}
