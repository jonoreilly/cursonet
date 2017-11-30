using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWPF
{
    class Cliente
    {
        //definiciones
        private int idCliente;
        private string nombre, apellido1, apellido2,
                       direccion, provincia, pais,
                       email, telefono, codigoCliente;
        private List<Pedido> PedidosCliente;

        //metodos
        public int GetPedidos()
        {
            //var pedidos = (from p in Pedidos.HistoricoPedidos
            //              where p.CodigoCliente == codigoCli
            //              select p).ToList();
            List<Pedido> misPedidos = new List<Pedido>()
            {
                new Pedido()
                {
                    IdPedido = 1,
                    CodigoCliente = codigoCliente,
                    Monto = 37
                },
                new Pedido()
                {
                    IdPedido = 2,
                    CodigoCliente = codigoCliente,
                    Monto = 12
                },
                new Pedido()
                {
                    IdPedido = 3,
                    CodigoCliente = codigoCliente,
                    Monto = 78
                }
            };
            return Pedidos.HistoricoPedidos.Count;
        }
        public void SetPedido(string codigoCli)
        {
            Pedido nuevoPedido = new Pedido();
            PedidosCliente.Add(nuevoPedido);
        }
        public void SetCodigoCliente(string nombreCliente, string apellidoCliente)
        {
            codigoCliente = string.Concat(nombreCliente.Substring(0, 1), apellidoCliente.Substring(0, 2)).ToUpper();
        }
    }

    public class Pedido
    {
        static int idPedido = 0;

        public Pedido()
        {
            IdPedido = idPedido++;
        }

        public int IdPedido { get; set; }
        public string CodigoCliente { get; set; }
        public decimal Monto { get; set; }
    }

    public class Pedidos
    {
        public Pedidos()
        {
            historicoPedidos = new List<Pedido>();
        }
        private static List<Pedido> historicoPedidos;
        public static List<Pedido> HistoricoPedidos
        {
            get
            {
                return historicoPedidos;
            }
            set
            {
                historicoPedidos = value;
            }
        }
    }
}
