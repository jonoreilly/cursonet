using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using clasesGesEscuela.Cursos;

namespace clasesGesEscuela.Vistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGuardarCurso_Click(object sender, RoutedEventArgs e)
        {
            Curso nuevoCurso = new Curso(txtNombreCurso.Text);
            ColeDB.cursos.Add(nuevoCurso);

            int misCursos = BuscarMisCursos();
        }

        private int BuscarMisCursos()
        {
            var cuentaCursos = (from c in ColeDB.cursos
                                   select c).Count();
            return cuentaCursos;
        }
    }
}
