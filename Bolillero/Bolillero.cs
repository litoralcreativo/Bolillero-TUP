using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bolillero
{
    class Bolillero
    {
        ArrayList bolillas;
        int cant = 90;
        static Random rand;

        public int Bolillas
        {
            get { return bolillas.Count; }
        }

        public Bolillero()
        {
            bolillas = new ArrayList();
            bolillas.Capacity=90;
            for (int i = 0; i < cant; i++)
            {
                bolillas.Add(i+1);
            }
        }
        public object Extraer()                                                                                                                                                                                     
        {
            object bolilla=-1;
            if (bolillas.Count > 1)
            {
                rand = new Random();
                int pos = rand.Next(0, bolillas.Count);
                bolilla = bolillas[pos];
                bolillas.RemoveAt(pos);
            }
            else if(bolillas.Count == 1)
            {
                bolilla = bolillas[0];
                bolillas.RemoveAt(0);
            }

            return bolilla;
        }
    }
}
