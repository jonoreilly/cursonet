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
    public partial class FrmUsuarios : Form
    {
        List<CsUsuarios> listaUsuarios = new List<CsUsuarios>();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void tsb_agregar_Click(object sender, EventArgs e)
        {
            txt_IdUsuario.Text = Convert.ToString(calc_ID_max());
        }

        private object calc_ID_max()
        {
            int miId = 0;

            foreach (CsUsuarios miusuario in listaUsuarios)
            {
                if (miusuario.IdUsuario > miId) miId = miusuario.IdUsuario;
            }

            return miId + 1;
        }

        private bool ValidarOtrosCampos()
        {
            {
                if (txt_Contrasenya.Text == "")
                {
                    errorProvider1.SetError(txt_Contrasenya, "Introduce una Contraseña");
                    txt_Contrasenya.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_Contrasenya, "");
            }            
            return true;
        }

        private bool ValidarID()
        {
            {
                if (txt_IdUsuario.Text == "")
                {
                    errorProvider1.SetError(txt_IdUsuario, "Introduce un ID");
                    txt_IdUsuario.Focus();
                    return false;
                }
                errorProvider1.SetError(txt_IdUsuario, "");
                return true;
            }
        }

        private CsUsuarios GetUsuario(int Idusuario)
        {
            foreach (CsUsuarios miUsuario in listaUsuarios)
            {
                if (miUsuario.IdUsuario == Idusuario) return miUsuario;
            }
            return null;
        }

        private void limpiarformulario()
        {
            txt_IdUsuario.Clear();
            txt_Contrasenya.Clear();
            
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<CsUsuarios>));
            TextWriter escritor = new StreamWriter("Usuarios.xml");
            serializador.Serialize(escritor, listaUsuarios);
            escritor.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (File.Exists("Usuarios.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<CsUsuarios>));
                FileStream lector = File.OpenRead("Usuarios.xml");
                listaUsuarios = (List<CsUsuarios>)serializador.Deserialize(lector);
                lector.Close();
            }
            dgv_Usuarios.DataSource = listaUsuarios;
        }

        private int M_NuevoID()
        {
            int miId = 0;

            foreach (CsUsuarios miUsuario in listaUsuarios)
            {
                if (miUsuario.IdUsuario > miId) miId = miUsuario.IdUsuario;
            }

            return miId + 1;
        }

        private void tsbguardar_Click(object sender, EventArgs e)
        {
            CsUsuarios miusuario = new CsUsuarios();

            //Validaciones
            if (!ValidarID()) return;
            if (!ValidarOtrosCampos()) return;
            if (GetUsuario(Convert.ToInt32(txt_IdUsuario.Text)) != null)
            {
                errorProvider1.SetError(txt_IdUsuario, "Este usuario ya está introducido ");
                txt_IdUsuario.Focus();
                return;
            }
            //Asignaciones
            miusuario.IdUsuario = Convert.ToInt32(txt_IdUsuario.Text);
            miusuario.Contrasenya = txt_Contrasenya.Text;
         

            //Metemos los valores en la lista y refrescamos el datagrid
            listaUsuarios.Add(miusuario);
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = listaUsuarios;
            limpiarformulario();
        }

        private void tsb_buscar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            CsUsuarios miUsuario = GetUsuario(Convert.ToInt32(txt_IdUsuario.Text));
            if (miUsuario == null)
            {
                errorProvider1.SetError(txt_IdUsuario, "El Producto no existe");
                txt_IdUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_IdUsuario, "");
            txt_IdUsuario.Text = Convert.ToString(miUsuario.IdUsuario);
            txt_Contrasenya.Text = Convert.ToString(miUsuario.Contrasenya);
        }

        private void tsb_modificar_Click(object sender, EventArgs e)
        {
            if (!ValidarID()) return;
            if (GetUsuario(Convert.ToInt32(txt_IdUsuario.Text)) == null)
            {
                errorProvider1.SetError(txt_IdUsuario, "Usuario no existe");
                txt_IdUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_IdUsuario, "");
            if (!ValidarOtrosCampos()) return;
            foreach (CsUsuarios miUsuario in listaUsuarios)
            {
                if (miUsuario.IdUsuario == Convert.ToInt32(txt_IdUsuario.Text))
                {
                    miUsuario.IdUsuario = Convert.ToInt32(txt_IdUsuario.Text);
                    miUsuario.Contrasenya = txt_Contrasenya.Text;
                    break;
                }
            }
            limpiarformulario();
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = listaUsuarios;
        }

        private void tsb_borrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, "¿Está seguro de borrar el Usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            if (!ValidarID()) return;
            if (GetUsuario(Convert.ToInt32(txt_IdUsuario.Text)) == null)
            {
                errorProvider1.SetError(txt_IdUsuario, "Usuario no existe");
                txt_IdUsuario.Focus();
                return;
            }
            foreach (CsUsuarios miProducto in listaUsuarios)
            {
                if (miProducto.IdUsuario == Convert.ToInt32(txt_IdUsuario.Text))
                {
                    listaUsuarios.Remove(miProducto);
                    break;
                }
            }
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = listaUsuarios;
            limpiarformulario();
        }
    }
    }

