using SegundoParcial.UI.Consultas;
using SegundoParcial.UI.Registros;
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

namespace SegundoParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProyectoDetalleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyectoDetalle rProyectoDetalle = new rProyectoDetalle();
            rProyectoDetalle.Show();
        }

        private void ConsultaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cConsulta cConsulta = new cConsulta();
            cConsulta.Show();

        }
    }
}
