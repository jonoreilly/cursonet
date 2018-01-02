using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiformulario
{
    public class CsUsuarios
    {
        private int idUsuario;
        private string contrasenya;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
    }
}
