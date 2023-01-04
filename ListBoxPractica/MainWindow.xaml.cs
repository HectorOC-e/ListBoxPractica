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

namespace ListBoxPractica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblaciones> listaPoblacion = new List<Poblaciones>();
            listaPoblacion.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, Diferencia = 2});
            listaPoblacion.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 19, Temperatura2 = 31, Diferencia = 12 });
            listaPoblacion.Add(new Poblaciones() { Poblacion1 = "Malaga", Poblacion2 = "Bilbao", Temperatura1 = 16, Temperatura2 = 23 , Diferencia = 8 });
            listaPoblacion.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 22, Temperatura2 = 28 , Diferencia = 6 });
            
            ListaPoblaciones.ItemsSource = listaPoblacion;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ListaPoblaciones.SelectedItem != null)
                {
                    MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
                }
                else MessageBox.Show("Selecciona primero un elemento", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            catch (Exception error)
            {
                MessageBox.Show("Error Debe seleccionar un item\nError: " + error.Message) ;
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else MessageBox.Show("Selecciona primero un elemento", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void ListaPoblaciones_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        //private void ListaPoblaciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
        //    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " +
        //    (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
        //    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
        //}
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }
        public int Diferencia { get; set; }
    }
}
