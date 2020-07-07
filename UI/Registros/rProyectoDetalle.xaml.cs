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

            TipoTareaComboBox.SelectedValuePath = "TareaId";
            TipoTareaComboBox.DisplayMemberPath = "Tarea";
            TipoTareaComboBox.ItemsSource = TareasBLL.GetTareas();



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
            Proyectos encontrado = ProyectoBLL.Buscar(proyectos.ProyectoId);
            {
                if (encontrado != null)
                {
                    proyectos = encontrado;
                    Cargar();
                    MessageBox.Show("Partida Encontrada", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"El Id de Proyecto no pudo ser encontrado", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                    Limpiar();
                    ProyectoIdTextBox.Text = " ";
                    ProyectoIdTextBox.Focus();
                }
            }
        }

        private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)
        {
            var filaDetalle = new ProyectosDetalle
            {
                ProyectoId = this.proyectos.ProyectoId,
                TareaId = Convert.ToInt32(TipoTareaComboBox.SelectedValue.ToString()),
                Requerimiento = RequerimientoTextBox.Text.ToString(),
                Tiempo = Convert.ToInt32(TiempoTextBox.Text.ToString())
            };

            this.proyectos.Detalle.Add(filaDetalle);
            Cargar();

            TipoTareaComboBox.SelectedIndex = -1;
            RequerimientoTextBox.Clear();
            TiempoTextBox.Clear();
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if(DetalleDataGrid.Items.Count >=1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count -1)
            {
                proyectos.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = ProyectoBLL.Guardar(this.proyectos);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado Con Exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
                MessageBox.Show("No se pudo Guardad", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProyectoBLL.Eliminar(Utilidades.Toint(ProyectoIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("El Registro Fue Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
                MessageBox.Show("El Registro no pudo se eliminado", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
