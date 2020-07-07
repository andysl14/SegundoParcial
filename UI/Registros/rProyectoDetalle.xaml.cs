using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SegundoParcial.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyectoDetalle.xaml
    /// </summary>
    public partial class rProyectoDetalle : Window
    {
        private Proyectos proyectos = new Proyectos();
        public rProyectoDetalle()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            //TareasComboBox.SelectedValuePath = "TareaId";


        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyectos;
        }

        private void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }

        private bool Validar()
        {
            bool Validado = true;
            if (ProyectoIdTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Proyecto Encontrado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return Validado;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectoBLL.Buscar(proyectos.ProyectoId)
            {

            }
        }
    }
}
