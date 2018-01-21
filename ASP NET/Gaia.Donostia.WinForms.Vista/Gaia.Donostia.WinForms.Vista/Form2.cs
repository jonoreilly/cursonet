using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gaia.Donostia.WinForms.Controlador;

namespace Gaia.Donostia.WinForms.Vista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Control1 clientes = new Control1();
                dgClientes.DataSource = clientes.GetCustomers();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgClientes.Refresh();
        }
    }
}
