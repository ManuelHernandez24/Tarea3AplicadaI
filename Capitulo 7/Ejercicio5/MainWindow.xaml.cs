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

        Hashtable numeros = new Hashtable();  

        private void GuardarButton_Click (object sender, RoutedEventArgs e){
                     
            numeros.Add(TextBoxNombreGuardar.Text, TextBoxNumero.Text);    
            MessageBox.Show($"Se guardó con éxito.");       
        }
        private void BuscarButton_Click (object sender, RoutedEventArgs e){
            string nombre = TextBoxNombreBuscar.Text;
            MessageBox.Show($"Numero: {numeros[nombre]}");
            
        }

    }
}
