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
    public partial class FrmClientes : Form
    {
        List<CsClientes> listaClientes = new List<CsClientes>();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            CsClientes micliente = new CsClientes();
            //Validaciones
            if (!ValidarID()) return;
            if (!ValidarOtrosCampos()) return;
            if (GetCliente(Convert.ToInt32(txt_IdCliente.Text)) != null)
            {
                errorProvider1.SetError(txt_IdCliente, "Este cliente ya está introducido");
                txt_nombre.Focus();
                return;
            }

            //Asignaciones
            micliente.IdCliente= Convert.ToInt32(txt_IdCliente.Text);
            micliente.Nombre = txt_nombre.Text;
            micliente.Apellido = txt_apellido.Text;
            micliente.Nif = txt_nif.Text;
            micliente.Localidad = txt_localidad.Text;

            //Metemos los valores en la lista y refrescamos el datagrid
            listaClientes.Add(micliente);
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = listaClientes;
            limpiarformulario();
                }
        private bool ValidarOtrosCampos()
                {

                {
                if (txt_nombre.Text == "")
                {
                    errorProvider1.SetError(txt_nombre, "Introduce un Nombre");
                    txt_nombre.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_nombre, "");
            }
            {
                if (txt_nif.Text == "")
                {
                    errorProvider1.SetError(txt_nif, "Introduce un nif");
                    txt_nif.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_nif, "");
            }

            {
                if (txt_localidad.Text == "")
                {
                    errorProvider1.SetError(txt_localidad, "Introduce una localidad");
                    txt_localidad.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_localidad, "");
            }

            {
                if (txt_apellido.Text == "")
                {
                    errorProvider1.SetError(txt_apellido, "Introduce un Apellido");
                    txt_apellido.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_apellido, "");

            }
            
            return true;
        }
        private bool ValidarID()
        {
            {
                if (txt_IdCliente.Text == "")
                {
                    errorProvider1.SetError(txt_IdCliente, "Introduce un ID");
                    txt_IdCliente.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_IdCliente, "");
                return true;
            }
        }
        private CsClientes GetCliente(int IdCliente)
        {
            foreach (CsClientes miCliente in listaClientes)
            {
                if (miCliente.IdCliente == IdCliente) return miCliente;
            }
            return null;
        }
        private void limpiarformulario()
        {
            txt_IdCliente.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_localidad.Clear();
            txt_nif.Clear();
            txt_IdCliente.Focus();
        }       
        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsClientes>));
            TextWriter escritor = new StreamWriter("Clientes.xml");
            serializador.Serialize(escritor, listaClientes);
            escritor.Close();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (File.Exists("Clientes.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsClientes>));
                FileStream lector = File.OpenRead("Clientes.xml");
                listaClientes = (List<CsClientes>)serializador.Deserialize(lector);
                lector.Close();
            }
            dgv_clientes.DataSource = listaClientes;
        }
        private int M_NuevoID()
        {
            int miId = 0;

            foreach (CsClientes miCliente in listaClientes)
            {
                if (miCliente.IdCliente > miId) miId = miCliente.IdCliente;
            }

            return miId + 1;
        }       

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            if (GetCliente(Convert.ToInt32(txt_IdCliente.Text)) == null)
            {
                errorProvider1.SetError(txt_IdCliente, "Cliente no existe");
                txt_nombre.Focus();
                return;
            }
            errorProvider1.SetError(txt_nombre, "");
            if (!ValidarOtrosCampos()) return;
            foreach (CsClientes miCliente in listaClientes)
            {
                if (miCliente.IdCliente == Convert.ToInt32(txt_IdCliente.Text))
                {
                    miCliente.Nombre = txt_nombre.Text;
                    miCliente.Apellido = txt_apellido.Text;
                    miCliente.Nif = txt_nif.Text;
                    miCliente.Localidad = txt_localidad.Text;
                    break;
                }

            }
            limpiarformulario();
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = listaClientes;
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            CsClientes miCliente = GetCliente(Convert.ToInt32(txt_IdCliente.Text));
            if (miCliente == null)
            {
                errorProvider1.SetError(txt_IdCliente, "La persona no existe");
                txt_IdCliente.Focus();
                return;
            }
            errorProvider1.SetError(txt_IdCliente, "");
            txt_nombre.Text = miCliente.Nombre;
            txt_apellido.Text = miCliente.Apellido;            
            txt_nif.Text = miCliente.Nif;
            txt_localidad.Text = miCliente.Localidad;
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            txt_IdCliente.Text = Convert.ToString(calc_ID_max());
            
        }
        private int calc_ID_max()
        {
            int miId = 0;

            foreach (CsClientes miCliente in listaClientes)
            {
                if (miCliente.IdCliente > miId) miId = miCliente.IdCliente;
            }

            return miId + 1;
        }

        private void tsb_borrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, "¿Está seguro de borrar el Cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            if (!ValidarID()) return;
            if (GetCliente(Convert.ToInt32(txt_IdCliente.Text)) == null)
            {
                errorProvider1.SetError(txt_IdCliente, "Cliente no existe");
                txt_IdCliente.Focus();
                return;
            }
            foreach (CsClientes miCliente in listaClientes)
            {
                if (miCliente.IdCliente == Convert.ToInt32(txt_IdCliente.Text))
                {
                    listaClientes.Remove(miCliente);
                    break;
                }
            }
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = listaClientes;
            limpiarformulario();
        }
    }
    }
    




