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

namespace Gaia.Repaso.Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DateTime fecha = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void MostrarMensajes(string mensaje, DateTime fecha)
        {
            string miFecha = fecha.ToShortDateString();
            string miHora = fecha.ToShortTimeString();
            string miMensaje = mensaje + " el dia " + miFecha + " a las " + miHora + " UTC.";
            MessageBox.Show(miMensaje);
        }

        private void btnMostrarMensaje_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                MostrarMensajes(txtMensaje.Text.Trim(), DateTime.Now.ToUniversalTime());
            }
            else
            {
                txtMensaje.Focus();
            }
        }

        private void txtMesajeChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty((string)lblMensajeNoIntroducido.Content) && !string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                lblMensajeNoIntroducido.Content = string.Empty;
            }
        }

        private void txtMesajeLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                lblMensajeNoIntroducido.Content = "*Debe introducir algo";
            }
        }
    }
}
