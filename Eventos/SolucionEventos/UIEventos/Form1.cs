using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace UIEventos
{
    public partial class Form1 : Form
    {
        public Cuenta miCuenta;

        public Form1()
        {
            InitializeComponent();
            miCuenta = new Cuenta();
            miCuenta.SaldoNegativo += this.saldoNegativo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            miCuenta.SacarDinero(1000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress");
        }

        private void textBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox1_KeyPress2");
        }

        private void mio(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("mio");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox2_KeyPress");
        }

        private void textBox2_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox2_KeyPress2");
        }

        private void textBox2_KeyPress3(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("textBox2_KeyPress3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void saldoNegativo(float dinero)
        {
            MessageBox.Show("Dinero: "+dinero);
        }
    }
}
