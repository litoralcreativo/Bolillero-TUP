using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bolillero
{
    class Jugador
    {
        private string nombre;
        public Carton Carton;

        public string Nombre 
        { 
            get { return nombre; }
            set { nombre = value; }
        }

        public Jugador(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CrearCarton()
        {
            Carton = new Carton();
            Carton.SortearCarton();
        }
        
        public void CrearCarton(int[] numeros)
        {
            Carton = new Carton();
            foreach (int i in numeros)
            {
                Carton.IngresarNumero(i);
            }
        }

        public ArrayList MostrarCarton()
        {
            return Carton.miCarton;
        }


    }
}
