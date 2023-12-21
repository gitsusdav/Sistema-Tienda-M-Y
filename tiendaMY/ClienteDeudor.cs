using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaMY
{
    internal class ClienteDeudor
    {
        private string nombre = "";
        private string cantidad = "";
        private string notas = "";

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string Notas { get { return notas; } set { notas = value; } }


        public ClienteDeudor(string _nombre, string _cantidad, string notas)
        {
            Nombre = _nombre;
            Cantidad = _cantidad;
            Notas = notas;  
        }

        public ClienteDeudor()
        {
        }
    }
}
