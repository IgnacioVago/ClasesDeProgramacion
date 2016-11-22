using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTres
{
    public partial class Form1 : Form
    {
        Thread _miHilo;

        public Form1()
        {
            InitializeComponent();
            this.btnPausar.Click += new EventHandler(this.pausarPelotita);
            this.btnDestruir.Click += new EventHandler(this.destruirPelotita);
            this.btnContinuar.Click += new EventHandler(this.continuarPelotita);
            this.btnDestruir.Enabled = false;
            this.btnPausar.Enabled = false;
            this.btnContinuar.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Thread.Pelotita nuevaPelotita;
            nuevaPelotita = new Pelotita_Con_Thread.Pelotita(pictureBox1);
            
            this._miHilo = new Thread(nuevaPelotita.DoWork);

            this._miHilo.Start();

            this.btnCrear.Click -= new EventHandler(this.btnCrear_Click);

            this.btnCrear.Enabled = false;
            this.btnDestruir.Enabled = true;
            this.btnPausar.Enabled = true;
            this.btnContinuar.Enabled = true;
        }

        public void pausarPelotita(object sender, EventArgs e)
        {
            try
            {
                this._miHilo.Suspend();

            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void continuarPelotita(object sender, EventArgs e)
        {
            try
            {
                this._miHilo.Resume();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void destruirPelotita(object sender, EventArgs e)
        {
            try
            {
                this._miHilo.Abort();
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
                this.btnCrear.Enabled = true;
                this.btnCrear.Click += new EventHandler(this.btnCrear_Click);
                this.btnDestruir.Enabled = false;
                this.btnPausar.Enabled = false;
                this.btnContinuar.Enabled = false;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }
    }
}
