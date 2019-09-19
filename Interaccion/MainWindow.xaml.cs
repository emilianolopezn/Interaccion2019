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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnMiBoton.Click += 
                BtnMiBoton_Click;
        }

        private void BtnMiBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios mundo!";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.Red;
        }

        private void BtnMiSegundoBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Segundo boton!";
            lblHolaMundo.FontSize = 24;
            lblHolaMundo.Foreground = Brushes.Aqua;
        }

        private void BtnMiTercerBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Tercer botón!";
            lblHolaMundo.FontSize = 27;
            lblHolaMundo.Foreground = Brushes.Coral;
        }
    }
}
