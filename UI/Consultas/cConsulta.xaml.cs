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

namespace SegundoParcial.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cConsulta.xaml
    /// </summary>
    public partial class cConsulta : Window
    {
        public cConsulta()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            List<Proyectos> listado = new List<Proyectos>();

            if(CriterioTextBox.Text.Trim().Length >0)
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            listado = ProyectoBLL.GetList(p => p.ProyectoId == Utilidades.Toint(CriterioTextBox.Text));
                            break;
                        }

                    case 1:
                        {
                            listado = ProyectoBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                            break;
                        }
                }
            }
            else
            {
                listado = ProyectoBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = (List<Proyectos>)ProyectoBLL.GetList(p => p.Fecha.Date >= DesdeDatePicker.SelectedDate);
            if(HastaDatePicker.SelectedDate !=null)
                listado =(List<Proyectos>)ProyectoBLL.GetList(p => p.Fecha.Date <= HastaDatePicker.SelectedDate);
        }
    }
}
