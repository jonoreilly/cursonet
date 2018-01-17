using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaia.Donostia.WinFormsMVC.Controladores;

namespace Gaia.Donostia.WinFormsMVC.Vistas
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ClientesControlador clientes = new ClientesControlador();
            dgClientes.DataSource = clientes.GetClientes();
        }

    }
}
