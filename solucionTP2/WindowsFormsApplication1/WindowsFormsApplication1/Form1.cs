using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class tpDos : Form
    {
        public tpDos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alambre;

            alambre = ((int.Parse(this.txtAncho.Text)+int.Parse(this.txtLargo.Text))*2)*3;

            MessageBox.Show("Ustede necesitaria " + alambre + " metros de alambre");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double alambre;

            alambre = (double.Parse(this.txtRadio.Text)*2)*3.14;

            MessageBox.Show("Usted necesitaria "+alambre+" metros de alambre");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
