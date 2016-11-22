using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucionTP5
{
    public partial class Form1 : Form
    {
        private Random randomNumero;
        private int numeroRandom;
        private int numeroIngresado;
        private int intentos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            numeroIngresado = int.Parse(txtNumero.Text);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            randomNumero = new Random();
            numeroRandom = randomNumero.Next(1, 100);
            MessageBox.Show("Que empiece el juego");
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            intentos++;

            if (numeroIngresado == numeroRandom)
            {
                MessageBox.Show("USTED GANÓ CON "+intentos+" INTENTOS");
            }
            else
            {
                if (numeroIngresado > numeroRandom)
                {
                    MessageBox.Show("USTED SE EXCEDIÓ DEL NUMERO A ADIVINAR");
                }
                else
                {
                    MessageBox.Show("A USTED LE FALTA PARA LLEGAR AL NUMERO A ADIVINAR");
                }
            }

            txtIntentos.Text = Convert.ToString(intentos);
        }

        private void txtIntentos_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
