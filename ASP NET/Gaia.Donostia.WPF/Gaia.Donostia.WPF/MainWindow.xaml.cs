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

namespace Gaia.Donostia.WPF
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

        private void btnVerClientes_Click(object sender, RoutedEventArgs e)
        {
            AdventureWorks2012Entities1 context = new AdventureWorks2012Entities1();

            var clientes = context.Customer.Select(c => c).ToList();
            //var clientes2 = (from c in context.Customer
            //                 select c).ToList();
            //var clientes3 = context.Customer.ToList();
            //var clientes4 = from c in context.Customer
            //                select c;
            //ICollection<Customer> clientes5 = null;
            //foreach (var item in clientes4)
            //{
            //    clientes5.Add(item);
            //}

            dataGridClientes.ItemsSource = clientes;
          //  dataGridClientes.DataContext = clientes;
        }
    }
}
