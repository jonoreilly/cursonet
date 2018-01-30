using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsADO.NeptunoDataSetTableAdapters;
using System.Data.OleDb;

namespace WinFormsADO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void tbClienteSeleccionado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbClienteSeleccionado.Text = dgClientes.SelectedRows.GetEnumerator().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAL miDal = new DAL();
            DataSet ClientesDs = null;

            try
            {
                ClientesDs = miDal.GetClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dgClientes.DataSource = ClientesDs;
            dgClientes.DataMember = ClientesDs.Tables["Clientes"].ToString();
        }
    }
}
