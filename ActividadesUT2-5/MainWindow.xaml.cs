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

namespace ActividadesUT2_5
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

        private void CheckBox_Checked_Negrita(object sender, RoutedEventArgs e)
        {
            txtResultado.FontWeight = FontWeights.Bold;
        }
        private void checkb_Unchecked_Negrita(object sender, RoutedEventArgs e)
        {
            txtResultado.FontWeight = FontWeights.Normal;
        }
        private void CheckBox_Checked_Cursiva(object sender, RoutedEventArgs e)
        {
            txtResultado.FontStyle = FontStyles.Italic;
        }
        private void checkb_Unchecked_Cursiva(object sender, RoutedEventArgs e)
        {
            txtResultado.FontStyle = FontStyles.Normal;
        }

        private void RadioButton_Checked_Azul(object sender, RoutedEventArgs e)
        {
            txtResultado.Foreground = Brushes.Blue;
        }

        private void RadioButton_Checked_Rojo(object sender, RoutedEventArgs e)
        {
            txtResultado.Foreground = Brushes.Red;
        }

        private void RadioButton_Checked_Verde(object sender, RoutedEventArgs e)
        {
            txtResultado.Foreground = Brushes.Green;
        }

        private void txtbTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtResultado.Text = txtbTexto.Text;
        }

        
    }
}
