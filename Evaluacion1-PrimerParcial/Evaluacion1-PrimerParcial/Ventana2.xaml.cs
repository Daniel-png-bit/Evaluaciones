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
using System.Windows.Shapes;

namespace Evaluacion1_PrimerParcial
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public delegate void Controlador(string cont);
        public event Controlador controlador;
        Piloto p = new Piloto();
        private Piloto[] pilotos = new Piloto[5];
        internal Piloto[] Pilotos { get => pilotos; set => pilotos = value; }

        public Ventana2()
        {
            InitializeComponent();
        }

        public void MostrarResultados(string contr)
        {
            if (controlador != null)
            {
                controlador(contr);
            }
        }

        private void btnBuscarPiloto_Click(object sender, RoutedEventArgs e)
        {
            int res = p.mostrarPosicion(Pilotos, txtBuscarPiloto.Text);
            if (res != -1)
            {
                controlador($"{Pilotos[res].Nombre} - Posición: {res + 1}");
            } else {
                controlador("No existe.");
            }
        }


    }
}
