using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucionTP6
{
    public partial class adivinaNumero2 : Form
    {
        private Random randomNumero;
        private int numeroRandom;
        private int numeroIngresado;
        private int intentos = 0;

        public adivinaNumero2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numeroIngresado = int.Parse(txtNumero.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                switch (intentos)
                {
                    case 1:
                        MessageBox.Show("Usted es un psiquico, ganó con: "+intentos+" intentos");
                        break;
                    case 2:
                        MessageBox.Show("Excelente percepción, ganó con: " + intentos + " intentos");
                        break;
                    case 3:
                        MessageBox.Show("Esto es suerte, ganó con: " + intentos + " intentos");
                        break;
                    case 4:
                        MessageBox.Show("Excelente técnica, ganó con: " + intentos + " intentos");
                        break;
                    case 5:
                        MessageBox.Show("Usted está en la media, ganó con: " + intentos + " intentos");
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        MessageBox.Show("Falta técnica, ganó con: " + intentos + " intentos");
                        break;
                    default:
                        MessageBox.Show("Afortunado en el amor!, ganó con: " + intentos + " intentos");
                        break;
                }
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

        private void adivinaNumero2_Load(object sender, EventArgs e)
        {

        }
    }
}
