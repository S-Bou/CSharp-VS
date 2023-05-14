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
using System.Diagnostics;

namespace PrimeraInterface
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("Le has dado al botón");
            MessageBox.Show("Le has dado al botón");
        }

        /*private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("Le has dado al stack");
            MessageBox.Show("Le has dado al stack");
        }*/

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.Write("Le has dado al panel");
            MessageBox.Show("Le has dado al panel");
        }
    }
}
