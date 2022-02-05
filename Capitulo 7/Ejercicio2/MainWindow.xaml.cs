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
using System.Collections;

namespace Ejercicio1
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
        private void CalcularButton_Click (object sender, RoutedEventArgs e){
           Hashtable Saludos = new Hashtable();
            Saludos.Add(1,"Hola");
            Saludos.Add(2,"Buenos días");
            Saludos.Add(3,"Buenas tardes");
            Saludos.Add(4,"Buenas noches");

            MessageBox.Show($"{Saludos[int.Parse(TextBoxTexto.Text)]}");
        }

    }
}
