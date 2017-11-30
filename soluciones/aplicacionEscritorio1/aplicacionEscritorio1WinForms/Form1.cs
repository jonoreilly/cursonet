using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionEscritorio1WinForms
{
    public partial class FormEjemplo1 : Form
    {
        public FormEjemplo1()
        {
            InitializeComponent();
        }

        private void btnPulsa_Click(object sender, EventArgs e)
        {
            Mensaje miMensaje1 = new Mensaje("Hola Amigos");

            try
            {
                miMensaje1.ShowCajaMensaje("Hola", "Amigos");
                miMensaje1.ShowCajaMensaje("Hola", "Am");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                miMensaje1.ShowCajaMensaje(ex.Message);
            }

            catch (Exception ex)
            {
                //Guardar los datos de la excepcion en un archivo de Log de fallos
                //Notificar al administrador del sistema mediante email
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}