using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bolillero
{
    class Carton
    {
        public ArrayList miCarton = new ArrayList(15);
        private int aciertos=0;
        Bolillero bolilleroPersonal = new Bolillero();
 

        public int Aciertos
        {
            get { return aciertos; }
            set { aciertos = value; }
        }

        public void SortearCarton()
        {
            for(int i = 0; i < 15; i++)
            {
                miCarton.Add(bolilleroPersonal.Extraer());
            }
        }
        public void IngresarNumero(object numero)
        {
                miCarton.Add(numero);
        }

        public void quitarNumero(int indice)
        {
            miCarton.RemoveAt(indice);
        }

        public override string ToString()
        {
            string numerosRestantes = "";
            {
                foreach (object bolilla in miCarton)
                {
                    numerosRestantes += " " + bolilla;
                }
            }
            return numerosRestantes;
        }


    }
}
