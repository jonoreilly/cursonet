using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsFacturas
    {
        private int idFactura;
        private int idUsuario;
        private int idCliente;        
        private DateTime fecha_factura;
        private double baseImponible;
        private double iva;
        private double totalFactura;

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime Fecha_factura { get => fecha_factura; set => fecha_factura = value; }
        public double BaseImponible { get => baseImponible; set => baseImponible = value; }
        public double Iva { get => iva; set => iva = value; }
        public double TotalFactura { get => totalFactura; set => totalFactura = value; }
    }
}
