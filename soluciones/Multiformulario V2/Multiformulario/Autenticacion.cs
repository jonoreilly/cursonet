using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Multiformulario
{
    public partial class Autenticacion : Form
    {
        List<CsClave> listaClaves = new List<CsClave>();
        FormPrincipal principal = new FormPrincipal();


        public Autenticacion()
        {
            InitializeComponent();
            lblAlerta.Hide();
            FormPrincipal principal = (FormPrincipal)this.Owner;
        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (!File.Exists("NadaImportante.xml"))
            {
                File.Create("NadaImportante.xml");
            }
            else
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsClave>));
                FileStream lector = File.OpenRead("NadaImportante.xml");
                listaClaves = (List<CsClave>)serializador.Deserialize(lector);
                lector.Close();

                foreach (CsClave item in listaClaves)
                {
                    if (item.usuario == tbUsuario.Text)
                    {
                        if (item.Comprobar(tbContraseña.Text))
                        {
                            principal.Autenticarse(item.usuario);
                            break;
                        }
                    }
                }
            }
            if (principal.credenciales() == "")
            {
                lblAlerta.Show();
            }
            else this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro childForm = new Registro();
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }
    }
}

/*
  if (File.Exists("NadaImportante.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsClave>));
                TextWriter escritor = new StreamWriter("NadaImportante.xml");
                serializador.Serialize(escritor, listaClaves);
                escritor.Close();
            }
*/