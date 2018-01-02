using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Multiformulario
{
    public partial class FrmFacturas : Form
        
    {
        List<CsClientes> listaClientes = new List<CsClientes>();
        List<CsProductos> listaProductos = new List<CsProductos>();
        List<CsFacturas> listaFacturas = new List<CsFacturas>();
        List<CsFactDetall> listaLinFact = new List<CsFactDetall>();

        int Idfact;
        int lin;
        int idprod;
        int idcli;
        int cntd_calc;
        double prcalc;
        string nomprod;
        double ivalin;
        double totlin;
        double ImpLin = 0;
        double IVA = 0;
        double Total = 0;



        public FrmFacturas()
        {
            InitializeComponent();
        }       

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            //Abrimos Clientes y hacemos una lista
            if (File.Exists("Clientes.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsClientes>));
                FileStream lector = File.OpenRead("Clientes.xml");
                listaClientes = (List<CsClientes>)serializador.Deserialize(lector);
                lector.Close();
            }
            cmb_IdCliente.DataSource = listaClientes;
            cmb_IdCliente.ValueMember = "IdCliente";
            cmb_IdCliente.DisplayMember = "Nombre";
            //Abrimos Productos y hacemos una lista
            if (File.Exists("Productos.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsProductos>));
                FileStream lector = File.OpenRead("Productos.xml");
                listaProductos = (List<CsProductos>)serializador.Deserialize(lector);
                lector.Close();
            }
            cmb_IdProducto.DataSource = listaProductos;
            cmb_IdProducto.ValueMember = "IdProducto";
            cmb_IdProducto.DisplayMember = "NombreProducto";
            //Abrimos facturas y hacemos una lista
            if (File.Exists("Facturas.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsFacturas>));
                FileStream lector = File.OpenRead("Facturas.xml");
                listaFacturas = (List<CsFacturas>)serializador.Deserialize(lector);
                lector.Close();
            }


            cmb_IdProducto.SelectedValue = "0";
            cmb_IdCliente.SelectedValue = "0";
            txt_idFactura.Text = Convert.ToString(calc_ID_max());
            txt_linea.Text = Convert.ToString(calc_Lin_max());
        }
        private int calc_ID_max()
        {
            int miId = 0;

            foreach (CsFacturas miFactura in listaFacturas)
            {
                if (miFactura.IdFactura > miId) miId = miFactura.IdFactura;
            }

            return miId + 1;
        }
        private int calc_Lin_max()
        {
            int miLm = 0;

            foreach (CsFactDetall miLinDetall in listaLinFact)
            {
                if (miLinDetall.Linea > miLm) miLm = miLinDetall.Linea;
            }

            return miLm + 1;
        }
        private CsProductos GetProducto(int IdProducto)
        {
            foreach (CsProductos miProducto in listaProductos)
            {
                if (miProducto.IdProducto == IdProducto) return miProducto;
            }
            return null;
        }
        
        private void calcular_Parciales()
        {
            CsFactDetall miLinDetallini = new  CsFactDetall();
            Idfact = Convert.ToInt32(txt_idFactura.Text);
            lin = Convert.ToInt32(txt_linea.Text);
            if (cmb_IdProducto.SelectedIndex > 0)
            {
                idprod = (int)cmb_IdProducto.SelectedValue;
            }
            else
            { idprod = 0; }
            cntd_calc = Convert.ToInt32(nup_cntd.Value);
            prcalc = Convert.ToDouble(GetProducto(idprod).Precio) * cntd_calc;
            nomprod = (GetProducto(idprod).NombreProducto);
            ivalin = prcalc * 0.21;
            totlin = prcalc + ivalin;
            txt_preciolinea.Text = Convert.ToString(prcalc);
            txt_ivalin.Text = Convert.ToString(ivalin);
            txt_totlin.Text = Convert.ToString(totlin);
        }

       

        private void suma()
        {

            Total = 0;
            ImpLin = 0;
            IVA = 0;

            foreach (CsFactDetall miSuma in listaLinFact)
                {
                ImpLin += miSuma.Importe;
                IVA += miSuma.Iva;
                Total += miSuma.TotalLinea;
                }
            txt_baseImponible.Text = ImpLin.ToString();
            txt_IVA.Text = IVA.ToString();
            txt_Totfact.Text = Total.ToString();         
            
        }

        private void btn_nuProd_Click(object sender, EventArgs e)
        {
           calcular_Parciales();
            CsFactDetall miLinea = new CsFactDetall();
            miLinea.IdFactura = Idfact;
            miLinea.Linea = lin;
            miLinea.IdProducto = idprod;
            miLinea.Cantidad = cntd_calc;
            miLinea.NombreProducto = nomprod;
            miLinea.Importe = prcalc;
            miLinea.Iva = ivalin;
            miLinea.TotalLinea = totlin;
            listaLinFact.Add(miLinea);
            dgv_lineas.DataSource = null;
            dgv_lineas.DataSource = listaLinFact;
            suma();
           vaciarlinea();
           txt_linea.Text = Convert.ToString(calc_Lin_max());

        }
        private void vaciarlinea()
        {
            txt_ivalin.Text = "0";
            txt_preciolinea.Text = "0";
            txt_totlin.Text = "0";
            cmb_IdProducto.SelectedValue = "0";
        }        
        private void cmb_IdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           calcular_Parciales();
        }
        private void nup_cntd_ValueChanged(object sender, EventArgs e)
        {
            calcular_Parciales();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cmb_IdCliente.SelectedIndex > 0)
            {
                idcli = (int)cmb_IdCliente.SelectedValue;
            }
            else
            { idcli = 0; }            
            CsFacturas mifactura = new CsFacturas();
            mifactura.IdFactura = Idfact;
            mifactura.IdCliente = idcli;
            mifactura.Fecha_factura = dtp_fecha.Value;
            mifactura.BaseImponible = ImpLin;
            mifactura.Iva = IVA;
            mifactura.TotalFactura = Total;
            listaFacturas.Add(mifactura);
            Guardar_LineasFactura();
            Guardar_Factura();
            this.Close();

        }
        private void Guardar_LineasFactura()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsFactDetall>));
            TextWriter escritor = new StreamWriter("FacturasDetalladas.xml");
            serializador.Serialize(escritor, listaLinFact);
            escritor.Close();
        }
        private void Guardar_Factura()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsFacturas>));
            TextWriter escritor = new StreamWriter("Facturas.xml");
            serializador.Serialize(escritor, listaFacturas);
            escritor.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
