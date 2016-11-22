using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNroUno_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float numeroTres;
            float resultado;
            float numeroDos;
            float numeroUno;

            numeroUno = float.Parse(this.txtNumeroUno.Text);
            numeroDos = float.Parse(this.txtNumeroDos.Text);
            numeroTres = float.Parse(this.txtNumeroTres.Text);

            resultado = numeroUno + numeroDos + numeroTres;

            MessageBox.Show("Resultado de la suma: " + resultado);
        }

        private void txtNumeroDos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumeroUno_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblNroTres_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float numeroTres;
            float resultado;
            float numeroDos;
            float numeroUno;

            numeroUno = float.Parse(this.txtNumeroUno.Text);
            numeroDos = float.Parse(this.txtNumeroDos.Text);
            numeroTres = float.Parse(this.txtNumeroTres.Text);

            resultado = ((numeroUno + numeroDos + numeroTres)/3);

            MessageBox.Show("Resultado del promedio es: " + resultado);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            float numeroTres;
            float resultado;
            float numeroDos;
            float numeroUno;
            float IVA;
            float resultadoFinal;

            numeroUno = float.Parse(this.txtNumeroUno.Text);
            numeroDos = float.Parse(this.txtNumeroDos.Text);
            numeroTres = float.Parse(this.txtNumeroTres.Text);

            resultado = numeroUno + numeroDos + numeroTres;
            IVA = ((resultado*21)/100);
            resultadoFinal = IVA + resultado;

            MessageBox.Show("Resultado final (IVA incluido): " + resultadoFinal);
        }
    }
}
