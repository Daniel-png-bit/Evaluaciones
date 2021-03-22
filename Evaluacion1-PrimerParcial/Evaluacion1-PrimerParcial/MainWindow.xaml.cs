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

namespace Evaluacion1_PrimerParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Piloto[] pilotos = new Piloto[5];
        Ventana2 ventana2 = new Ventana2();
        public MainWindow()
        {
            InitializeComponent();
            LlenarArreglo();
        }

        private void btnAbrirVentana2_Click(object sender, RoutedEventArgs e)
        {
            ventana2.Pilotos = pilotos;
            ventana2.controlador += new Ventana2.Controlador(MostrarResultados);
            ventana2.Show();
        }

        public void MostrarResultados(string res)
        {
            lbResultados.Items.Clear();
            lbResultados.Items.Add(res);
        }

        public void LlenarArreglo()
        {
            pilotos[0] = new Piloto("Pedro","Jack","Cochabamba");
            pilotos[1] = new Piloto("Juan", "Flick", "La Paz");
            pilotos[2] = new Piloto("Sara", "Bonty", "Santa Cruz");
            pilotos[3] = new Piloto("Lorena", "Flick", "Cochabamba");
            pilotos[4] = new Piloto("Lucas", "Jack", "Tarija");
        }
    }
}
