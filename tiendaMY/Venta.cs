using System;
using System.Drawing;
using System.Windows.Forms;

namespace tiendaMY
{
    internal class Venta
    {
        private string nombreCliente = "";
        private string metodoDePago = "";
        private string id = "";
        private decimal totalVenta = 0;
        private decimal ganancia = 0;
        private DateTime fecha;

        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public string MetodoDePago { get { return metodoDePago; } set {  metodoDePago = value; } }
        public string Id { get { return id; } set { id = value; } }
        public decimal TotalVenta { get { return totalVenta; } set { totalVenta = value; } }
        public decimal Ganancia { get { return ganancia; } set { ganancia = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

        public Venta (string _nombreCliente, string _metodoDePago, string _id, decimal _totalVenta, decimal _ganancia, DateTime _fecha)
        {
            NombreCliente = _nombreCliente;
            MetodoDePago = _metodoDePago;
            Id = _id;
            TotalVenta = _totalVenta;
            Ganancia = _ganancia;
            Fecha = _fecha;
        }

        public Venta()
        {

        }
    }
}