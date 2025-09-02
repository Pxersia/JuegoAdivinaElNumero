using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_adivina__numero
{
    public partial class Form1 : Form
    {

        private int numeroSecreto;
        private int intentos;
        private Random aleatorio;
        public Form1()
        {
            InitializeComponent();
            aleatorio = new Random();
            IniciarJuego();
            
        }

        private void IniciarJuego()
        {
            CajaTexto.Enabled = true;
            button1.Enabled = true;
            Lista_Intentos.Items.Clear();
            CajaTexto.Clear();
            numeroSecreto = aleatorio.Next(1, 101); // Número entre 1 y 100
            intentos = 0;
            Nro_Intentos.Text = "Intentos: 0";
  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(CajaTexto.Text, out int numeroIngresado))
                {
                    intentos++;
                    Lista_Intentos.Text = "Intentos: " + intentos;
                    Lista_Intentos.Items.Add(numeroIngresado);

                    if (numeroIngresado == numeroSecreto)
                    {
                        MessageBox.Show("¡Felicidades! Adivinaste el número secreto en " + intentos + " intentos.");
                        CajaTexto.Enabled = false;
                        button1.Enabled = false;
                    }
                    else if (numeroIngresado < numeroSecreto)
                    {
                        MessageBox.Show("El número secreto es mayor.");
                    }
                    else
                    {
                        MessageBox.Show("El número secreto es menor.");
                    }

                    CajaTexto.Clear();
                    CajaTexto.Focus();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
        }

        private void NuevoJuego_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
        
