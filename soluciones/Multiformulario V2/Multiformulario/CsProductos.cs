using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsProductos
    {
        private int idProducto;
        private string nombreProducto;        
        private double precio;

        public CsProductos()
        {
        }

        public CsProductos(int idProducto, string descripcion, double precio)
        {
            this.idProducto = idProducto;
            this.nombreProducto = descripcion;
            this.precio = precio;
        }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
