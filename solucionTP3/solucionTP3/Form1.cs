using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucionTP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fahrenheit;
            double celsius = 0;

            fahrenheit = double.Parse(this.txtTemperatura.Text);
            celsius = (fahrenheit - 32)*5/9;

            MessageBox.Show("La temperatura ingresada ("+fahrenheit+") ºF, equivale a " +celsius+" ºC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double celsius;
            double fahrenheit = 0;

            celsius = double.Parse(this.txtTemperatura.Text);
            fahrenheit = (((celsius) * (1.8)) + 32);

            MessageBox.Show("La temperatura ingresada (" + celsius + ") ºC, equivale a " + fahrenheit + " ºF");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
