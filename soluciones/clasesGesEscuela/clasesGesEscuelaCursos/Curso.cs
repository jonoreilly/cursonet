using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGesEscuela.Cursos
{
    public class Curso
    {
        private static int contador;
        private int idCurso;
        private string nombreCurso;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }


        public Curso()
        {
            idCurso = ++contador;
        }

        public Curso (string nombreCurso)
        {
            this.nombreCurso = nombreCurso;
            idCurso = ++contador;
        }
    }
}
