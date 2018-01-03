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
    public partial class Registro : Form
    {
        List<CsClave> listaClave = new List<CsClave>();
        

        public Registro()
        {
            InitializeComponent();
            lblAlertaContraseña.Hide();
            lblAlertaUsEx.Hide();
            lblAlertaHueco.Hide();
            lblAlertaSinContraseña.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            lblAlertaHueco.Hide();
            lblAlertaUsEx.Hide();
            lblAlertaContraseña.Hide();
            lblAlertaSinContraseña.Hide();
            bool continuar = true;

            if (!File.Exists("NadaImportante.xml"))
            {
                File.WriteAllText(".\\NadaImportante.xml", "<?xml version=\"1.0\" encoding=\"utf-8\"?> <ArrayOfCsClave xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> \n </ArrayOfCsClave>");
            }

            XmlSerializer serializador = new XmlSerializer(typeof(List<CsClave>));
            FileStream lector = File.OpenRead("NadaImportante.xml");
            listaClave = (List<CsClave>)serializador.Deserialize(lector);
            lector.Close();

            foreach (CsClave item in listaClave)
            {
                if (item.usuario == tbUsuario.Text)
                {
                    lblAlertaUsEx.Show();
                    continuar = false;
                    break;
                }
            }
            if (tbUsuario.Text == "")
            {
                lblAlertaHueco.Show();
                continuar = false;
            }
            if (tbContraseña.Text == "" && tbContraseña2.Text == "")
            {
                lblAlertaSinContraseña.Show();
                continuar = false;
            }
            if (continuar)
            {
                
                if (tbContraseña.Text == tbContraseña2.Text)
                {
                    CsClave nuevaClave = new CsClave(tbUsuario.Text, tbContraseña.Text);
                    listaClave.Add(nuevaClave);
                    TextWriter escritor = new StreamWriter("NadaImportante.xml");
                    serializador.Serialize(escritor, listaClave);
                    escritor.Close();

                    this.Close();
                }
                else lblAlertaContraseña.Show();

            }
        }
    }
}
