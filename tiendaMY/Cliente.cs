namespace tiendaMY
{
    internal class Cliente
    {
        private string nombre = "";
        private string cedula = "";

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Cedula { get { return cedula; } set { cedula = value; } }


        public Cliente(string _nombre, string _cedula)
        {
            Nombre = _nombre;
        }

        public Cliente()
        {
        }
    }
}