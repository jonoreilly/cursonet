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
    public partial class FrmProductos : Form
    {
        List<CsProductos> listaProductos = new List<CsProductos>();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private int calc_ID_max()
        {
            int miId = 0;

            foreach (CsProductos miProducto in listaProductos)
            {
                if (miProducto.IdProducto > miId) miId = miProducto.IdProducto;
            }

            return miId + 1;
        }

        private void tsb_agregar_Click(object sender, EventArgs e)
        {
            txt_IdProducto.Text = Convert.ToString(calc_ID_max());            
        }

        private bool ValidarOtrosCampos()
        {
            {
                if (txt_nombreProducto.Text == "")
                {
                    errorProvider1.SetError(txt_nombreProducto, "Introduce un Nombre");
                    txt_nombreProducto.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_nombreProducto, "");
            }
            {
                if (txt_precio.Text == "")
                {
                    errorProvider1.SetError(txt_precio, "Introduce un precio");
                    txt_precio.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_precio, "");
            }
            return true;
        }

        private bool ValidarID()
        {
            {
                if (txt_IdProducto.Text == "")
                {
                    errorProvider1.SetError(txt_IdProducto, "Introduce un ID");
                    txt_IdProducto.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_IdProducto, "");
                return true;
            }
        }

        private CsProductos GetProducto(int IdProducto)
        {
            foreach (CsProductos miProducto in listaProductos)
            {
                if (miProducto.IdProducto == IdProducto) return miProducto;
            }
            return null;
        }

        private void limpiarformulario()
        {
            txt_IdProducto.Clear();
            txt_nombreProducto.Clear();
            txt_precio.Clear();
            txt_IdProducto.Focus();
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsProductos>));
            TextWriter escritor = new StreamWriter("Productos.xml");
            serializador.Serialize(escritor, listaProductos);
            escritor.Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (File.Exists("Productos.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsProductos>));
                FileStream lector = File.OpenRead("Productos.xml");
                listaProductos = (List<CsProductos>)serializador.Deserialize(lector);
                lector.Close();
            }
            dgv_Productos.DataSource = listaProductos;
        }

        private int M_NuevoID()
        {
            int miId = 0;

            foreach (CsProductos miProducto in listaProductos)
            {
                if (miProducto.IdProducto > miId) miId = miProducto.IdProducto;
            }

            return miId + 1;
        }

        private void tsbguardar_Click(object sender, EventArgs e)
        {
            CsProductos miproducto = new CsProductos();

            //Validaciones
            if (!ValidarID()) return;
            if (!ValidarOtrosCampos()) return;
            if (GetProducto(Convert.ToInt32(txt_IdProducto.Text)) != null)
            {
                errorProvider1.SetError(txt_IdProducto, "Este producto ya está introducido ");
                txt_IdProducto.Focus();
                return;
            }
            //Asignaciones
            miproducto.IdProducto = Convert.ToInt32(txt_IdProducto.Text);
            miproducto.NombreProducto = txt_nombreProducto.Text;
            miproducto.Precio = Convert.ToDouble(txt_precio.Text);

            //Metemos los valores en la lista y refrescamos el datagrid
            listaProductos.Add(miproducto);
            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = listaProductos;
            limpiarformulario();
        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            CsProductos miProducto = GetProducto(Convert.ToInt32(txt_IdProducto.Text));
            if (miProducto == null)
            {
                errorProvider1.SetError(txt_IdProducto, "El Producto no existe");
                txt_IdProducto.Focus();
                return;
            }
            errorProvider1.SetError(txt_IdProducto, "");
            txt_nombreProducto.Text = miProducto.NombreProducto;
            txt_precio.Text = Convert.ToString(miProducto.Precio);
        }

        private void tsb_modificar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            if (GetProducto(Convert.ToInt32(txt_IdProducto.Text)) == null)
            {
                errorProvider1.SetError(txt_IdProducto, "Producto no existe");
                txt_nombreProducto.Focus();
                return;
            }
            errorProvider1.SetError(txt_nombreProducto, "");
            if (!ValidarOtrosCampos()) return;
            foreach (CsProductos miProducto in listaProductos)
            {
                if (miProducto.IdProducto == Convert.ToInt32(txt_IdProducto.Text))
                {
                    miProducto.NombreProducto = txt_nombreProducto.Text;
                    miProducto.Precio = Convert.ToDouble(txt_precio.Text);
                    break;
                }
            }
            limpiarformulario();
            dgv_Productos.DataSource = null;
            dgv_Productos.DataSource = listaProductos;
        }

        private void tsb_borrar_Click(object sender, EventArgs e)        {
            
            DialogResult rta = MessageBox.Show(this, "¿Está seguro de borrar el Producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            if (!ValidarID()) return;
            if (GetProducto(Convert.ToInt32(txt_IdProducto.Text)) == null)
                {
                    errorProvider1.SetError(txt_IdProducto, "Producto no existe");
                    txt_nombreProducto.Focus();
                    return;
                }
                foreach (CsProductos miProducto in listaProductos)
                {
                    if (miProducto.IdProducto == Convert.ToInt32(txt_IdProducto.Text))
                    {
                        listaProductos.Remove(miProducto);
                        break;
                    }
                }
                dgv_Productos.DataSource = null;
                dgv_Productos.DataSource = listaProductos;
                limpiarformulario();
            }
        }
    }

