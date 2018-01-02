using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsClientes
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string nif;
        private string localidad;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nif { get => nif; set => nif = value; }
        public string Localidad { get => localidad; set => localidad = value; }
    }
}
