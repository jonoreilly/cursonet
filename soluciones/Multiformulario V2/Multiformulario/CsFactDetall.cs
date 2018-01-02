using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsFactDetall
    {
        private int idFactura;
        private int linea;
        private int cantidad;
        private int idProducto;
        private string nombreProducto;
        private double importe;
        private double iva;
        private double totalLinea;

        public CsFactDetall() { }

        public CsFactDetall(int idFactura, int linea, int cantidad, int idProducto, string nombreProducto, double importe, double iva, double totalLinea)
        {
            IdFactura = idFactura;
            Linea = linea;
            Cantidad = cantidad;
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Importe = importe;
            Iva = iva;
            TotalLinea = totalLinea;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Linea { get => linea; set => linea = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double Importe { get => importe; set => importe = value; }
        public double Iva { get => iva; set => iva = value; }
        public double TotalLinea { get => totalLinea; set => totalLinea = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
    }
}
