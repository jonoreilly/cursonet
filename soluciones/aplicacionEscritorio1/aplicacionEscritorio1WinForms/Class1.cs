using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionEscritorio1WinForms
{
    public class Mensaje
    {
        #region definicion de variables

        private string mensaje;

        #endregion

        #region Constructores

        public Mensaje()
        {
            MensajeGS = string.Empty;
        }

        public Mensaje(string mensaje)
        {
            MensajeGS = mensaje;
        }
         
        #endregion

        #region Propiedades

        public string MensajeGS
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }

        #endregion

        #region Procedimientos
        /*
                public void MostrarMensaje(string mensaje)
                {
                    if (!String.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show(mensaje + ", ha pulsao un boton", mensaje, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Mete un nombre, anda", "º_º", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }

                public void MostrarMensaje()
                {
                    MessageBox.Show("Mete un nombre, anda", "º_º", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
        */
        public void ShowCajaMensaje(params string[] mensajes)
        {
            for (int i = 0; i < mensajes.Length; i++)
            {
                if (mensajes[i].Length < 3 )
                {
                    throw new ArgumentException("mayor de 2, plis");
                }
            }
            string miMensajeCompleto = ConcatenarMensajes(mensajes);
            MessageBox.Show(miMensajeCompleto);
        }

        public string ConcatenarMensajes(string[] mensajes)
        {
            string miMensajeCompleto = string.Empty;
            for (int i = 0; i < mensajes.Length; i++)
            {
                miMensajeCompleto += mensajes[i] + " ";
            }

            return miMensajeCompleto;
        }
        #endregion
    }
}