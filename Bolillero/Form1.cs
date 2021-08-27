using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolillero
{
    public partial class Loteria : Form
    {
        static int cantJugadores=0;
        static string ganadores = "Ganador/es: ";
        public Loteria()
        {
            InitializeComponent();
        }
        LaLoteria nuevoJuego;

        private void brInicio_Click(object sender, EventArgs e)
        {
            // comentario nuevo
            // otro comentario
            nuevoJuego = new LaLoteria(tbNombre.Text, Convert.ToInt32(numericUdJugadores.Value));
            cantJugadores = Convert.ToInt32(numericUdJugadores.Value);
            int[] numeros = new int[15];
            Fcarton fcarton = new Fcarton();
            if (fcarton.ShowDialog() == DialogResult.Yes)
            {
                FelegirNumeros fnuevoElegir = new FelegirNumeros();
                int cant = 0;
                do
                {
                    if (fnuevoElegir.ShowDialog() == DialogResult.OK)
                    {
                        if (cant== 0)
                        {
                            numeros[cant] = Convert.ToInt32(fnuevoElegir.tbNumero.Text);
                            cant++;
                            fnuevoElegir.tbNumero.Clear();
                        }
                        else
                        {
                            int rep=0;
                            for(int i = 0; i < cant; i++)
                            {
                                if(numeros[i] == Convert.ToInt32(fnuevoElegir.tbNumero.Text))
                                {
                                    rep++;
                                }
                            }
                            if (rep == 0)
                            {
                                numeros[cant] = Convert.ToInt32(fnuevoElegir.tbNumero.Text);
                                cant++;
                            }
                            fnuevoElegir.tbNumero.Clear();
                        }
                    }
                } while (cant < 15);
                nuevoJuego.VerJugador(0).CrearCarton(numeros);
                fnuevoElegir.Dispose();
            }
            else
            {
                nuevoJuego.VerJugador(0).CrearCarton();
            }
            fcarton.Dispose();

            gbSorteo.Enabled = true;
            gbInicio.Enabled = false;
            btReiniciar.Enabled = false;
            btSortear.Enabled = true;

            imprimir();
        }
        
        public void imprimir()
        {
            listBox1.Items.Add("-------------------------------------------------------------------------------------");
            for (int i = 0; i < cantJugadores; i++)
            {
                listBox1.Items.Add(nuevoJuego.VerJugador(i).Nombre+"-"+ " Numeros Restantes: "+ nuevoJuego.VerJugador(i).Carton.ToString()+" Aciertos: "+nuevoJuego.VerJugador(i).Carton.Aciertos);
                listBox1.Items.Add("");
            }
            listBox1.Items.Add("-------------------------------------------------------------------------------------");
            lbrestantes.Text = "Bolillas Restantes: " + nuevoJuego.Bolillero.Bolillas;
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(nuevoJuego.Sortear());
            
            imprimir();

            for(int i = 0; i < cantJugadores; i++)
            {
                    if (nuevoJuego.VerJugador(i).Carton.Aciertos == 15)
                    {
                        ganadores += nuevoJuego.VerJugador(i).Nombre + " ";
                    }
            }
            if (ganadores != "Ganador/es: ")
            {
                MessageBox.Show(ganadores);
                btSortear.Enabled = false;
                btReiniciar.Visible = true;
                btReiniciar.Enabled = true;
            }
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            gbSorteo.Enabled = false;
            gbInicio.Enabled = true;
        }

    }
}
