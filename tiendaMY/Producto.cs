namespace tiendaMY
{
    internal class Producto
    {
        private string codigo = "";
        private string nombre = "";
        private string descripcion = "";
        private int cantidad;
        private double precioCompra;
        private double precioVenta;

        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = (int)value; } }
        public double PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public double PrecioDeVenta { get { return precioVenta; } set { precioVenta = value; } }

        public Producto(double _cantidad, int _cantidadMinima, string _unidadDeMedida, double _precioCompra, double _precioDeVenta, bool _iva, string _codigo, string _nombre)
        {
            Cantidad = _cantidad;
            PrecioCompra = _precioCompra;
            PrecioDeVenta = _precioDeVenta;
            Codigo = _codigo;
            Nombre = _nombre;
        }

        public Producto()
        {
        }
    }
}