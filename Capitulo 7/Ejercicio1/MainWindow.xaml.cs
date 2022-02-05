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
            ArrayList notas = new ArrayList(5);
            notas.Add(85);
            notas.Add(65);
            notas.Add(90);
            notas.Add(92);
            notas.Add(82);
            
             
            float promedio = 0, notaMinima = 100, notaMaxima = 0;
            foreach( int n in notas){
                if(n >= notaMaxima){
                    notaMaxima = n;
                }
                else if(n <= notaMinima){
                    notaMinima = n;
                }
                promedio = promedio + n;             
            }

            promedio = promedio / notas.Count;

            TextBoxNotaMinima.Text = Convert.ToString(notaMinima);      
            TextBoxNotaMaxima.Text = Convert.ToString(notaMaxima); 
            TextBoxPromedio.Text = Convert.ToString(promedio);      



        }

    }
}
