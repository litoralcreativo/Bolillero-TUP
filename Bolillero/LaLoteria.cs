using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bolillero
{
    class LaLoteria
    {

        public ArrayList BolillasSorteadas = new ArrayList();
        public Bolillero Bolillero;
        private Jugador[] Players;


        public Jugador VerJugador(int i)
        {
            return Players[i]; 
        }

        public LaLoteria(string nombre, int jugadores)
        {
            Bolillero = new Bolillero();
            Players = new Jugador[jugadores];

            switch (jugadores)
            {
                case 2:
                    {
                        Players[0] = new Jugador(nombre);
                        Players[1] = new Jugador("  PC1  ");
                        Players[1].CrearCarton();
                        break;
                    }
                case 3:
                    {
                        Players[0] = new Jugador(nombre);
                        for (int i=1; i <jugadores; i++)
                        {
                            Players[i] = new Jugador("  PC" + i+"  ");
                            Players[i].CrearCarton();
                        }
                        break;
                    }
                case 4:
                    {
                        Players[0] = new Jugador(nombre);
                        for (int i = 1; i < jugadores; i++)
                        {
                            Players[i] = new Jugador("  PC" + i + "  ");
                            Players[i].CrearCarton();
                        }
                        break;
                    }
            }
        }

        public string Sortear()
        {
            string acertaron="     ";
            bool aciertos = false;
            object numero = Bolillero.Extraer();
            BolillasSorteadas.Add(numero);

            for (int i = 0; i < Players.Length; i++)
            {
                int indice = Players[i].MostrarCarton().IndexOf(numero);
                if (indice != -1)
                {
                    aciertos = true;
                    Players[i].Carton.Aciertos++;
                    Players[i].Carton.quitarNumero(indice);
                    acertaron += "|"+Players[i].Nombre+ "|" + "      ";
                }
            }
            if (aciertos == true) { return "bolilla " + numero + " - Acertaron: " + acertaron; }
            else { return "bolilla " + numero + " -sin aciertos"; }

        }

    }
}
