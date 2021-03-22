using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1_PrimerParcial
{
    class Piloto
    {
        private string nombre;
        private string marca;
        private string ciudad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public Piloto()
        {

        }

        public Piloto(string nombre, string marca, string ciudad)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.ciudad = ciudad;
        }

        public int mostrarPosicion(Piloto[] pilotos,string nombre)
        {
            for (int i = 0; i < pilotos.Length; i++)
            {
                if (pilotos[i].nombre.ToUpper() == nombre.ToUpper() )
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
