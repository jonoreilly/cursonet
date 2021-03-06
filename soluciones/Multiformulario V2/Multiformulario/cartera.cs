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
    public partial class FrmCartera : Form
    {
        List<CsFacturas> listaFacturas = new List<CsFacturas>();
        List<CsFactDetall> listaLinFact = new List<CsFactDetall>();
        List<CsClientes> listaClientes = new List<CsClientes>();
        List<CsProductos> listaProductos = new List<CsProductos>();

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
        private TabControl tabControl1;
        private TabPage tabpEncabezado;
        private SplitContainer splitContainer1;
        private TextBox tbEncabezadoFactura;
        private Label label5;
        private IContainer components;
        private TabPage tabDesgloses;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private ComboBox cmb_IdCliente;
        private TextBox txt_Total;
        private TextBox txt_Iva;
        private TextBox txt_BaseImp;
        private TextBox txt_usuarioSel;
        private TextBox txt_idfac_desg;
        private Label lblTotalFactura;
        private Label lblIVAFact;
        private Label lblBaseImp;
        private Label lblIDCli;
        private Label lblUsuSel;
        private Label lblFactSel;
        private TextBox txt_LTotal;
        private Label label4;
        private TextBox txt_LIVA;
        private Label label3;
        private Button btn_modificar;
        private TextBox txt_LBaseImp;
        private Label lblBaseImpLinea;
        private Label label2;
        private NumericUpDown nud_Cantidad;
        private ComboBox cmb_IdProducto;
        private Label label1;
        private TextBox txt_LinSel;
        private Label lblLinSel;
        private DataGridView dgv_LinFact;
        private DataGridView dgv_Facturas;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_BuscarFactura;
        private ToolStripButton tsb_BorrarFactura;
        private ToolStripButton tsb_CerrarFactura;
        private Button btnBuscar;
        double Total = 0;

        public FrmCartera()
        {
            InitializeComponent();
        }

        public void FrmCartera_Load(object sender, EventArgs e)
        {
            if (File.Exists("Facturas.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsFacturas>));
                FileStream lector = File.OpenRead("Facturas.xml");
                listaFacturas = (List<CsFacturas>)serializador.Deserialize(lector);
                lector.Close();
            }
            dgv_Facturas.DataSource = null;
            dgv_Facturas.DataSource = listaFacturas;

            if (File.Exists("FacturasDetalladas.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsFactDetall>));
                FileStream lector = File.OpenRead("FacturasDetalladas.xml");
                listaLinFact = (List<CsFactDetall>)serializador.Deserialize(lector);
                lector.Close();
            }
            //Abrimos Clientes y hacemos una lista
            if (File.Exists("Clientes.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsClientes>));
                FileStream lector = File.OpenRead("Clientes.xml");
                listaClientes = (List<CsClientes>)serializador.Deserialize(lector);
                lector.Close();
            }

            //Abrimos Productos y hacemos una lista
            if (File.Exists("Productos.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsProductos>));
                FileStream lector = File.OpenRead("Productos.xml");
                listaProductos = (List<CsProductos>)serializador.Deserialize(lector);
                lector.Close();
            }
            //Cargamos los combos
            dgv_LinFact.DataSource = listaLinFact;
            cmb_IdCliente.DataSource = listaClientes;
            cmb_IdCliente.ValueMember = "IdCliente";
            cmb_IdCliente.DisplayMember = "Nombre";
            //---------
            cmb_IdProducto.DataSource = listaProductos;
            cmb_IdProducto.ValueMember = "IdProducto";
            cmb_IdProducto.DisplayMember = "NombreProducto";
            //---------
            cmb_IdProducto.SelectedValue = "0";
            cmb_IdCliente.SelectedValue = "0";
        }

        //private void tsb_borrar_Click(object sender, EventArgs e)
        //{
        //    if (!ValidarID()) return;
        //    DialogResult rta = MessageBox.Show(this, "¿Está seguro de borrar el Factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        //    if (rta == DialogResult.No) return;

        //    if (GetFactura(Convert.ToInt32(txt_idfac_desg.Text)) == null)
        //    {
        //        errorProvider1.SetError(txt_idfac_desg, "Factura no existe");
        //        txt_idfac_desg.Focus();
        //        return;
        //    }
        //    foreach (CsFactDetall miLinea in listaLinFact)
        //    {
        //        if (miLinea.IdFactura == Convert.ToInt32(txt_idfac_desg.Text))
        //        {
        //            //DialogResult rta = MessageBox.Show(this, "¿Está seguro de borrar el Factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        //            listaLinFact.Remove(miLinea);
        //            break;
        //        }
        //    }
        //    foreach (CsFacturas miFactura in listaFacturas)
        //    {
        //        if (miFactura.IdFactura == Convert.ToInt32(txt_idfac_desg.Text))
        //        {
        //            listaFacturas.Remove(miFactura);
        //            break;
        //        }
        //    }
        //    dgv_Facturas.DataSource = null;
        //    dgv_Facturas.DataSource = listaFacturas;
        //}

        //private bool ValidarID()
        //{
        //    {
        //        if (txt_idfac_desg.Text == "")
        //        {
        //            errorProvider1.SetError(txt_idfac_desg, "Introduce un ID");
        //            txt_idfac_desg.Focus();
        //            return false;
        //        }
        //        errorProvider1.SetError(txt_idfac_desg, "");
        //        return true;
        //    }
        //}

        //private bool ValidarLinea()
        //{
        //    {
        //        if (txt_LinSel.Text == "")
        //        {
        //            errorProvider1.SetError(txt_LinSel, "Introduce la linea que deseas modificar");
        //            txt_LinSel.Focus();
        //            return false;
        //        }
        //        errorProvider1.SetError(txt_LinSel, "");
        //        return true;
        //    }
        //}

        //private CsFacturas GetFactura(int IdFactura)
        //{
        //    foreach (CsFacturas miFactura in listaFacturas)
        //    {
        //        if (miFactura.IdFactura == IdFactura) return miFactura;
        //    }
        //    return null;
        //}

        //private CsFactDetall GetLineaFactura(int Linea)
        //{
        //    foreach (CsFactDetall miLinea in nulistaLinFact)
        //    {
        //        if (miLinea.Linea == Linea) return miLinea;
        //    }
        //    return null;
        //}

        //private CsProductos GetProducto(int IdProducto)
        //{
        //    foreach (CsProductos miProducto in listaProductos)
        //    {
        //        if (miProducto.IdProducto == IdProducto) return miProducto;
        //    }
        //    return null;
        //}

        //private void tsb_buscar_Click(object sender, EventArgs e)
        //{
        //    txt_idfac_desg.Text = txt_idfac_desg.Text;
        //    CsFacturas miFactura = GetFactura(Convert.ToInt32(txt_idfac_desg.Text));
        //    if (miFactura == null)
        //    {
        //        errorProvider1.SetError(txt_idfac_desg, "El Factura no existe");
        //        txt_idfac_desg.Focus();
        //        return;
        //    }
        //    errorProvider1.SetError(txt_idfac_desg, "");
        //    cmb_IdCliente.SelectedValue = miFactura.IdCliente;
        //    txt_BaseImp.Text = Convert.ToString(miFactura.BaseImponible);
        //    txt_Iva.Text = Convert.ToString(miFactura.Iva);
        //    txt_Total.Text = Convert.ToString(miFactura.TotalFactura);
        //    Filtra_desgfact();
        //    dgv_LinFact.DataSource = null;
        //    dgv_LinFact.DataSource = nulistaLinFact;
        //    this.tabControl1.SelectedTab = tabDesgloses;

        //}

        //private void Filtra_desgfact()
        //{
        //    foreach (CsFactDetall miLinea in listaLinFact)
        //    {
        //        if (miLinea.IdFactura == Convert.ToInt32(txt_idfac_desg.Text))
        //        {
        //            MessageBox.Show("Hola");
        //            nulistaLinFact.Add(miLinea);
        //        }
        //    }
        //}

        //private void btn_buscar_Click(object sender, EventArgs e)
        //{
        //    if (!ValidarLinea()) return;
        //    CsFactDetall miLinea = GetLineaFactura(Convert.ToInt32(txt_LinSel.Text));
        //    if (miLinea == null)
        //    {
        //        errorProvider1.SetError(txt_LinSel, "No existe esta línea");
        //        txt_LinSel.Focus();
        //        return;
        //    }
        //    errorProvider1.SetError(txt_LinSel, "");
        //    cmb_IdProducto.SelectedValue = miLinea.IdProducto;
        //    nud_Cantidad.Value = miLinea.Cantidad;
        //    calcular_Parciales();
        //}

        //private void tsb_modFact_Click(object sender, EventArgs e)
        //{
        //    if (!ValidarLinea()) return;
        //    CsFactDetall miLinea = GetLineaFactura(Convert.ToInt32(txt_LinSel.Text));
        //    if (miLinea == null)
        //    {
        //        errorProvider1.SetError(txt_LinSel, "No existe esta línea");
        //        txt_LinSel.Focus();
        //        return;
        //    }
        //    errorProvider1.SetError(txt_LinSel, "");
        //    cmb_IdProducto.SelectedValue = miLinea.IdProducto;
        //    nud_Cantidad.Value = miLinea.Cantidad;
        //}

        //private void calcular_Parciales()
        //{
        //    CsFactDetall miLinDetallini = new CsFactDetall();
        //    Idfact = Convert.ToInt32(txt_idfac_desg.Text);
        //    lin = Convert.ToInt32(txt_LinSel.Text);
        //    if (cmb_IdProducto.SelectedIndex > 0)
        //    {
        //        idprod = (int)cmb_IdProducto.SelectedValue;
        //    }
        //    else
        //    { idprod = 0; }
        //    cntd_calc = Convert.ToInt32(nud_Cantidad.Value);
        //    prcalc = Convert.ToDouble(GetProducto(idprod).Precio) * cntd_calc;
        //    nomprod = (GetProducto(idprod).NombreProducto);
        //    ivalin = prcalc * 0.21;
        //    totlin = prcalc + ivalin;
        //    txt_LBaseImp.Text = Convert.ToString(prcalc);
        //    txt_LIVA.Text = Convert.ToString(ivalin);
        //    txt_LTotal.Text = Convert.ToString(totlin);
        ////}

        //private void cmb_IdProducto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    calcular_Parciales();
        //}

        //private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        //{
        //    calcular_Parciales();
        //}



        //private void btn_modificar_Click(object sender, EventArgs e)
        //{
        //    if (!ValidarLinea()) return;
        //    Borra_linea();
        //}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartera));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpEncabezado = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbEncabezadoFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.tabDesgloses = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cmb_IdCliente = new System.Windows.Forms.ComboBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_Iva = new System.Windows.Forms.TextBox();
            this.txt_BaseImp = new System.Windows.Forms.TextBox();
            this.txt_usuarioSel = new System.Windows.Forms.TextBox();
            this.txt_idfac_desg = new System.Windows.Forms.TextBox();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblIVAFact = new System.Windows.Forms.Label();
            this.lblBaseImp = new System.Windows.Forms.Label();
            this.lblIDCli = new System.Windows.Forms.Label();
            this.lblUsuSel = new System.Windows.Forms.Label();
            this.lblFactSel = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt_LTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LIVA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_LBaseImp = new System.Windows.Forms.TextBox();
            this.lblBaseImpLinea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.cmb_IdProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LinSel = new System.Windows.Forms.TextBox();
            this.lblLinSel = new System.Windows.Forms.Label();
            this.dgv_LinFact = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_BuscarFactura = new System.Windows.Forms.ToolStripButton();
            this.tsb_BorrarFactura = new System.Windows.Forms.ToolStripButton();
            this.tsb_CerrarFactura = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabpEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).BeginInit();
            this.tabDesgloses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LinFact)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabpEncabezado);
            this.tabControl1.Controls.Add(this.tabDesgloses);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpEncabezado
            // 
            this.tabpEncabezado.Controls.Add(this.splitContainer1);
            this.tabpEncabezado.Location = new System.Drawing.Point(4, 22);
            this.tabpEncabezado.Name = "tabpEncabezado";
            this.tabpEncabezado.Padding = new System.Windows.Forms.Padding(3);
            this.tabpEncabezado.Size = new System.Drawing.Size(790, 430);
            this.tabpEncabezado.TabIndex = 1;
            this.tabpEncabezado.Text = "Encabezado";
            this.tabpEncabezado.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbEncabezadoFactura);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Facturas);
            this.splitContainer1.Size = new System.Drawing.Size(784, 424);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbEncabezadoFactura
            // 
            this.tbEncabezadoFactura.Location = new System.Drawing.Point(495, 70);
            this.tbEncabezadoFactura.Name = "tbEncabezadoFactura";
            this.tbEncabezadoFactura.Size = new System.Drawing.Size(100, 20);
            this.tbEncabezadoFactura.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Factura seleccionada ................";
            // 
            // dgv_Facturas
            // 
            this.dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Facturas.Location = new System.Drawing.Point(0, 0);
            this.dgv_Facturas.Name = "dgv_Facturas";
            this.dgv_Facturas.Size = new System.Drawing.Size(784, 263);
            this.dgv_Facturas.TabIndex = 0;
            this.dgv_Facturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Facturas_CellClick);
            // 
            // tabDesgloses
            // 
            this.tabDesgloses.Controls.Add(this.splitContainer3);
            this.tabDesgloses.Location = new System.Drawing.Point(4, 22);
            this.tabDesgloses.Name = "tabDesgloses";
            this.tabDesgloses.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesgloses.Size = new System.Drawing.Size(790, 430);
            this.tabDesgloses.TabIndex = 2;
            this.tabDesgloses.Text = "Desgloses";
            this.tabDesgloses.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgv_LinFact);
            this.splitContainer3.Size = new System.Drawing.Size(784, 424);
            this.splitContainer3.SplitterDistance = 162;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.cmb_IdCliente);
            this.splitContainer4.Panel1.Controls.Add(this.txt_Total);
            this.splitContainer4.Panel1.Controls.Add(this.txt_Iva);
            this.splitContainer4.Panel1.Controls.Add(this.txt_BaseImp);
            this.splitContainer4.Panel1.Controls.Add(this.txt_usuarioSel);
            this.splitContainer4.Panel1.Controls.Add(this.txt_idfac_desg);
            this.splitContainer4.Panel1.Controls.Add(this.lblTotalFactura);
            this.splitContainer4.Panel1.Controls.Add(this.lblIVAFact);
            this.splitContainer4.Panel1.Controls.Add(this.lblBaseImp);
            this.splitContainer4.Panel1.Controls.Add(this.lblIDCli);
            this.splitContainer4.Panel1.Controls.Add(this.lblUsuSel);
            this.splitContainer4.Panel1.Controls.Add(this.lblFactSel);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnBuscar);
            this.splitContainer4.Panel2.Controls.Add(this.txt_LTotal);
            this.splitContainer4.Panel2.Controls.Add(this.label4);
            this.splitContainer4.Panel2.Controls.Add(this.txt_LIVA);
            this.splitContainer4.Panel2.Controls.Add(this.label3);
            this.splitContainer4.Panel2.Controls.Add(this.btn_modificar);
            this.splitContainer4.Panel2.Controls.Add(this.txt_LBaseImp);
            this.splitContainer4.Panel2.Controls.Add(this.lblBaseImpLinea);
            this.splitContainer4.Panel2.Controls.Add(this.label2);
            this.splitContainer4.Panel2.Controls.Add(this.nud_Cantidad);
            this.splitContainer4.Panel2.Controls.Add(this.cmb_IdProducto);
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.Controls.Add(this.txt_LinSel);
            this.splitContainer4.Panel2.Controls.Add(this.lblLinSel);
            this.splitContainer4.Size = new System.Drawing.Size(784, 162);
            this.splitContainer4.SplitterDistance = 92;
            this.splitContainer4.TabIndex = 0;
            // 
            // cmb_IdCliente
            // 
            this.cmb_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_IdCliente.FormattingEnabled = true;
            this.cmb_IdCliente.Location = new System.Drawing.Point(235, 33);
            this.cmb_IdCliente.Name = "cmb_IdCliente";
            this.cmb_IdCliente.Size = new System.Drawing.Size(252, 21);
            this.cmb_IdCliente.TabIndex = 11;
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total.Location = new System.Drawing.Point(663, 33);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 10;
            // 
            // txt_Iva
            // 
            this.txt_Iva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Iva.Location = new System.Drawing.Point(583, 33);
            this.txt_Iva.Name = "txt_Iva";
            this.txt_Iva.ReadOnly = true;
            this.txt_Iva.Size = new System.Drawing.Size(74, 20);
            this.txt_Iva.TabIndex = 9;
            // 
            // txt_BaseImp
            // 
            this.txt_BaseImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BaseImp.Location = new System.Drawing.Point(493, 33);
            this.txt_BaseImp.Name = "txt_BaseImp";
            this.txt_BaseImp.ReadOnly = true;
            this.txt_BaseImp.Size = new System.Drawing.Size(84, 20);
            this.txt_BaseImp.TabIndex = 8;
            // 
            // txt_usuarioSel
            // 
            this.txt_usuarioSel.Location = new System.Drawing.Point(129, 33);
            this.txt_usuarioSel.Name = "txt_usuarioSel";
            this.txt_usuarioSel.ReadOnly = true;
            this.txt_usuarioSel.Size = new System.Drawing.Size(100, 20);
            this.txt_usuarioSel.TabIndex = 7;
            // 
            // txt_idfac_desg
            // 
            this.txt_idfac_desg.Location = new System.Drawing.Point(23, 33);
            this.txt_idfac_desg.Name = "txt_idfac_desg";
            this.txt_idfac_desg.ReadOnly = true;
            this.txt_idfac_desg.Size = new System.Drawing.Size(100, 20);
            this.txt_idfac_desg.TabIndex = 6;
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Location = new System.Drawing.Point(677, 17);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(70, 13);
            this.lblTotalFactura.TabIndex = 5;
            this.lblTotalFactura.Text = "Total Factura";
            // 
            // lblIVAFact
            // 
            this.lblIVAFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIVAFact.AutoSize = true;
            this.lblIVAFact.Location = new System.Drawing.Point(613, 17);
            this.lblIVAFact.Name = "lblIVAFact";
            this.lblIVAFact.Size = new System.Drawing.Size(24, 13);
            this.lblIVAFact.TabIndex = 4;
            this.lblIVAFact.Text = "IVA";
            // 
            // lblBaseImp
            // 
            this.lblBaseImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaseImp.AutoSize = true;
            this.lblBaseImp.Location = new System.Drawing.Point(507, 17);
            this.lblBaseImp.Name = "lblBaseImp";
            this.lblBaseImp.Size = new System.Drawing.Size(54, 13);
            this.lblBaseImp.TabIndex = 3;
            this.lblBaseImp.Text = "Base Imp.";
            // 
            // lblIDCli
            // 
            this.lblIDCli.AutoSize = true;
            this.lblIDCli.Location = new System.Drawing.Point(261, 17);
            this.lblIDCli.Name = "lblIDCli";
            this.lblIDCli.Size = new System.Drawing.Size(53, 13);
            this.lblIDCli.TabIndex = 2;
            this.lblIDCli.Text = "ID Cliente";
            // 
            // lblUsuSel
            // 
            this.lblUsuSel.AutoSize = true;
            this.lblUsuSel.Location = new System.Drawing.Point(156, 17);
            this.lblUsuSel.Name = "lblUsuSel";
            this.lblUsuSel.Size = new System.Drawing.Size(50, 13);
            this.lblUsuSel.TabIndex = 1;
            this.lblUsuSel.Text = "Usu. Sel.";
            // 
            // lblFactSel
            // 
            this.lblFactSel.AutoSize = true;
            this.lblFactSel.Location = new System.Drawing.Point(40, 17);
            this.lblFactSel.Name = "lblFactSel";
            this.lblFactSel.Size = new System.Drawing.Size(52, 13);
            this.lblFactSel.TabIndex = 0;
            this.lblFactSel.Text = "Fact. Sel.";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(110, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 60);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt_LTotal
            // 
            this.txt_LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LTotal.Location = new System.Drawing.Point(663, 30);
            this.txt_LTotal.Name = "txt_LTotal";
            this.txt_LTotal.ReadOnly = true;
            this.txt_LTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_LTotal.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total Linea";
            // 
            // txt_LIVA
            // 
            this.txt_LIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LIVA.Location = new System.Drawing.Point(583, 29);
            this.txt_LIVA.Name = "txt_LIVA";
            this.txt_LIVA.ReadOnly = true;
            this.txt_LIVA.Size = new System.Drawing.Size(74, 20);
            this.txt_LIVA.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "IVA";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Location = new System.Drawing.Point(416, 3);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(71, 61);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_LBaseImp
            // 
            this.txt_LBaseImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LBaseImp.Location = new System.Drawing.Point(493, 29);
            this.txt_LBaseImp.Name = "txt_LBaseImp";
            this.txt_LBaseImp.ReadOnly = true;
            this.txt_LBaseImp.Size = new System.Drawing.Size(84, 20);
            this.txt_LBaseImp.TabIndex = 15;
            // 
            // lblBaseImpLinea
            // 
            this.lblBaseImpLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaseImpLinea.AutoSize = true;
            this.lblBaseImpLinea.Location = new System.Drawing.Point(507, 14);
            this.lblBaseImpLinea.Name = "lblBaseImpLinea";
            this.lblBaseImpLinea.Size = new System.Drawing.Size(54, 13);
            this.lblBaseImpLinea.TabIndex = 14;
            this.lblBaseImpLinea.Text = "Base Imp.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad";
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Cantidad.Location = new System.Drawing.Point(344, 30);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(66, 20);
            this.nud_Cantidad.TabIndex = 11;
            this.nud_Cantidad.ValueChanged += new System.EventHandler(this.nud_Cantidad_ValueChanged);
            // 
            // cmb_IdProducto
            // 
            this.cmb_IdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_IdProducto.Location = new System.Drawing.Point(177, 29);
            this.cmb_IdProducto.Name = "cmb_IdProducto";
            this.cmb_IdProducto.Size = new System.Drawing.Size(161, 21);
            this.cmb_IdProducto.TabIndex = 21;
            this.cmb_IdProducto.SelectionChangeCommitted += new System.EventHandler(this.cmb_IdProducto_SelectionChangeCommitted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Producto";
            // 
            // txt_LinSel
            // 
            this.txt_LinSel.Location = new System.Drawing.Point(23, 30);
            this.txt_LinSel.Name = "txt_LinSel";
            this.txt_LinSel.Size = new System.Drawing.Size(81, 20);
            this.txt_LinSel.TabIndex = 7;
            // 
            // lblLinSel
            // 
            this.lblLinSel.AutoSize = true;
            this.lblLinSel.Location = new System.Drawing.Point(40, 14);
            this.lblLinSel.Name = "lblLinSel";
            this.lblLinSel.Size = new System.Drawing.Size(45, 13);
            this.lblLinSel.TabIndex = 1;
            this.lblLinSel.Text = "Lin. Sel.";
            // 
            // dgv_LinFact
            // 
            this.dgv_LinFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LinFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LinFact.Location = new System.Drawing.Point(0, 0);
            this.dgv_LinFact.Name = "dgv_LinFact";
            this.dgv_LinFact.ReadOnly = true;
            this.dgv_LinFact.Size = new System.Drawing.Size(784, 258);
            this.dgv_LinFact.TabIndex = 0;
            this.dgv_LinFact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LinFact_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_BuscarFactura,
            this.tsb_BorrarFactura,
            this.tsb_CerrarFactura});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_BuscarFactura
            // 
            this.tsb_BuscarFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_BuscarFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BuscarFactura.Image")));
            this.tsb_BuscarFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BuscarFactura.Name = "tsb_BuscarFactura";
            this.tsb_BuscarFactura.Size = new System.Drawing.Size(88, 22);
            this.tsb_BuscarFactura.Text = "Buscar Factura";
            this.tsb_BuscarFactura.Click += new System.EventHandler(this.tsb_BuscarFactura_Click);
            // 
            // tsb_BorrarFactura
            // 
            this.tsb_BorrarFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_BorrarFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BorrarFactura.Image")));
            this.tsb_BorrarFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BorrarFactura.Name = "tsb_BorrarFactura";
            this.tsb_BorrarFactura.Size = new System.Drawing.Size(85, 22);
            this.tsb_BorrarFactura.Text = "Borrar Factura";
            this.tsb_BorrarFactura.Click += new System.EventHandler(this.tsb_BorrarFactura_Click);
            // 
            // tsb_CerrarFactura
            // 
            this.tsb_CerrarFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_CerrarFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CerrarFactura.Image")));
            this.tsb_CerrarFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CerrarFactura.Name = "tsb_CerrarFactura";
            this.tsb_CerrarFactura.Size = new System.Drawing.Size(95, 22);
            this.tsb_CerrarFactura.Text = "Guardar y cerrar";
            this.tsb_CerrarFactura.Click += new System.EventHandler(this.tsb_CerrarFactura_Click);
            // 
            // FrmCartera
            // 
            this.ClientSize = new System.Drawing.Size(798, 484);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCartera";
            this.Load += new System.EventHandler(this.FrmCartera_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpEncabezado.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).EndInit();
            this.tabDesgloses.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LinFact)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        


        private void dgv_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dgv_Facturas.CurrentCell.RowIndex;
            int numFactura = int.Parse(dgv_Facturas["IdFactura", indice].Value.ToString().Trim());
            tbEncabezadoFactura.Text = numFactura.ToString();
        }
        

        private void dgv_LinFact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dgv_LinFact.CurrentCell.RowIndex;
            int numLinea = int.Parse(dgv_LinFact["Linea", indice].Value.ToString().Trim());
            txt_LinSel.Text = numLinea.ToString();
        }
        

        public void actualizarLineas()
        {
            selectFactura(int.Parse(tbEncabezadoFactura.Text));
        }
        

        private void tsb_BuscarFactura_Click(object sender, EventArgs e)
        {
            int numFactura = int.Parse(tbEncabezadoFactura.Text);
            selectFactura(numFactura);
        }

        private void selectFactura(int idFactura)
        {
            CsFacturas subFactura = new CsFacturas();
            foreach (CsFacturas factura in listaFacturas)
            {
                if (factura.IdFactura == idFactura)
                {
                    subFactura = factura;
                    break;
                }
            }

            List<CsFactDetall> subListaLinFact = new List<CsFactDetall>();
            foreach (CsFactDetall linFactura in listaLinFact)
            {
                if (linFactura.IdFactura == idFactura)
                {
                    subListaLinFact.Add(linFactura);
                }
            }
            dgv_LinFact.DataSource = subListaLinFact;
            dgv_LinFact.Refresh();

            txt_idfac_desg.Text = subFactura.IdFactura.ToString();
            txt_usuarioSel.Text = subFactura.IdUsuario.ToString();
            cmb_IdCliente.DataSource = listaClientes;
            cmb_IdCliente.SelectedValue = subFactura.IdCliente;
            txt_BaseImp.Text = subFactura.BaseImponible.ToString();
            txt_Iva.Text = subFactura.Iva.ToString();
            txt_Total.Text = subFactura.TotalFactura.ToString();
        }

        private void tsb_BorrarFactura_Click(object sender, EventArgs e)
        {
            Borra_facturaylineas();
        }

        private void Borra_facturaylineas()
        {
            bool found = false;
            CsFactDetall mifacturalin = new CsFactDetall();
            foreach (CsFactDetall linFactura in listaLinFact)
            {
                if (linFactura.Linea == int.Parse(txt_LinSel.Text))
                {
                    found = true;
                    mifacturalin = linFactura;
                }
            }
            if (found)
            {
                listaLinFact.Remove(mifacturalin);
                MessageBox.Show("Lineas Borradas");
            }
            found = false;
            CsFacturas mifactura = new CsFacturas();
            foreach (CsFacturas factura in listaFacturas)
            {
                if (factura.IdFactura == int.Parse(tbEncabezadoFactura.Text))
                {
                    found = true;
                    mifactura = factura;
                }
            }
            if (found)
            {
                listaFacturas.Remove(mifactura);
                MessageBox.Show("Factura Borrada");
            }
            dgv_Facturas.Refresh();
            dgv_LinFact.Refresh();
        }


        private void tsb_CerrarFactura_Click(object sender, EventArgs e)
        {
            Guardar_Factura();
            this.Close();
        }

        private void Guardar_Factura()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsFacturas>));
            TextWriter escritor = new StreamWriter("Facturas.xml");
            serializador.Serialize(escritor, listaFacturas);
            escritor.Close();

            XmlSerializer serializador2 = new XmlSerializer(typeof(List<CsFactDetall>));
            TextWriter escritor2 = new StreamWriter("FacturasDetalladas.xml");
            serializador2.Serialize(escritor2, listaLinFact);
            escritor2.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CsFactDetall subLinea = new CsFactDetall();
            foreach (CsFactDetall lineaFactura in listaLinFact)
            {
                if (lineaFactura.Linea.ToString() == txt_LinSel.Text && lineaFactura.IdFactura.ToString() == txt_idfac_desg.Text)
                {
                    subLinea = lineaFactura;
                    break;
                }
            }
            cmb_IdProducto.SelectedValue = subLinea.IdProducto;
            nud_Cantidad.Value = subLinea.Cantidad;
            txt_LBaseImp.Text = subLinea.Importe.ToString();
            txt_LIVA.Text = subLinea.Iva.ToString();
            txt_LTotal.Text = subLinea.TotalLinea.ToString();

            actualizarPrecios();
        }


        private void cmb_IdProducto_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            actualizarPrecios();
        }

        private void nud_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            actualizarPrecios();
        }

        public void actualizarPrecios()
        {
            CsProductos elProducto = new CsProductos();
            foreach (CsProductos producto in listaProductos)
            {
                if (producto.NombreProducto == cmb_IdProducto.Text)
                {
                    elProducto = producto;
                    break;
                }
            }
            CsFacturas lafactura = new CsFacturas();
            foreach (CsFacturas factura in listaFacturas)
            {
                if (factura.IdFactura.ToString() == txt_idfac_desg.Text.Trim())
                {
                    lafactura = factura;
                    break;
                }
            }
            CsFactDetall lalinea = new CsFactDetall();
            foreach (CsFactDetall linea in listaLinFact)
            {
                if (linea.Linea.ToString() == txt_LinSel.Text.Trim())
                {
                    lalinea = linea;
                    break;
                }
            }

            txt_LBaseImp.Text = (elProducto.Precio*(double)nud_Cantidad.Value).ToString();
            txt_LIVA.Text = ((elProducto.Precio * (double)nud_Cantidad.Value) * 21.0 / 100).ToString();
            txt_LTotal.Text = (((elProducto.Precio * 21.0 / 100)+elProducto.Precio)*(double)nud_Cantidad.Value).ToString();

            txt_BaseImp.Text = (lafactura.BaseImponible+((elProducto.Precio* (double)nud_Cantidad.Value)- lalinea.Importe)).ToString();
            txt_Iva.Text = (lafactura.Iva + ((elProducto.Precio* (double)nud_Cantidad.Value) * 21.0 / 100 - lalinea.Iva)).ToString();
            txt_Total.Text = ((double.Parse(txt_BaseImp.Text) * 21.0 / 100) + double.Parse(txt_BaseImp.Text)).ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (CsFacturas factura in listaFacturas)
            {
                if (factura.IdFactura.ToString() == txt_idfac_desg.Text)
                {
                    factura.BaseImponible = double.Parse(txt_BaseImp.Text);
                    factura.Iva = double.Parse(txt_Iva.Text);
                    factura.TotalFactura = double.Parse(txt_Total.Text);
                    break;
                }
            }
            dgv_Facturas.Refresh();

            foreach (CsFactDetall linea in listaLinFact)
            {
                if (linea.Linea.ToString() == txt_LinSel.Text && linea.IdFactura.ToString() == txt_idfac_desg.Text)
                {
                    linea.NombreProducto = cmb_IdProducto.Text;
                    linea.IdProducto = (int)cmb_IdProducto.SelectedValue;
                    linea.Cantidad = (int)nud_Cantidad.Value;
                    linea.Importe = double.Parse(txt_LBaseImp.Text);
                    linea.Iva = double.Parse(txt_LIVA.Text);
                    linea.TotalLinea = double.Parse(txt_LTotal.Text);
                    break;
                }
            }
            dgv_LinFact.Refresh();
        }
    }
}
