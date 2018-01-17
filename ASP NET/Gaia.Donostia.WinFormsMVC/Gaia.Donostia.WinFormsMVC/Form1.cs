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
using Gaia.Donostia.WinFormsMVC.Vistas;
using Gaia.Donostia.WinFormsMVC.Modelos;


namespace Gaia.Donostia.WinFormsMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            FormClientes index = new FormClientes();
            index.Show();
        }
    }
}
