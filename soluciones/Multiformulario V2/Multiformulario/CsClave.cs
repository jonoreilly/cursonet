using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsClave
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }


        //public bool Comprobar (string intento)
        //{
        //    char[] charArray = intento.ToCharArray();
        //    Array.Reverse(charArray);
        //    if (hash == new string(charArray))
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        public bool Comprobar (string intento)
        {
            if (intento == this.contraseña)
            {
                return true;
            }
            else return false;
        }


        //public void guardarContraseña (string clave)
        //{
        //    char[] charArray = clave.ToCharArray();
        //    Array.Reverse(charArray);
        //    this.hash = new string(charArray);
        //}

        public void guardarContraseña(string clave)
        {
            this.contraseña = (string)clave;
        }

        public CsClave(string nombre, string clave)
        {
            this.usuario = nombre;
            guardarContraseña(clave);
        }

        public CsClave()
        {

        }
    }
}
