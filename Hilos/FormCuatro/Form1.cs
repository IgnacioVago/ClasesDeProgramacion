using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FormCuatro
{
    public partial class Form1 : Form
    {
        List<Thread> _hilos;
        int _cantidadPelotitas;

        public Form1()
        {
            InitializeComponent();
            this._cantidadPelotitas = 0;
            this._hilos = new List<Thread>();
            this.btnPausar.Click += new EventHandler(this.pausarPelotitas);
            this.btnEliminar.Click += new EventHandler(this.eliminarPelotitas);
            this.btnReanudar.Click += new EventHandler(this.reanudarPelotitas);
            this.btnEliminar.Enabled = false;
            this.btnPausar.Enabled = false;
            this.btnReanudar.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            #region MyRegion

            this.btnEliminar.Enabled = true;
            this.btnPausar.Enabled = true;
            this.btnReanudar.Enabled = true;

            #endregion
            Pelotita_Con_Thread.Pelotita nuevaPelotita;
            nuevaPelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);

            Thread miHilo = new Thread(nuevaPelotita.DoWork);
            miHilo.Start();

            this._hilos.Add(miHilo);

            this._cantidadPelotitas++;

            this.lblCantidad.Text = "Cantidad de pelotitas: " + this._cantidadPelotitas;
        }

        public void pausarPelotitas(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._cantidadPelotitas - 1].Suspend();
                this._cantidadPelotitas--;
                this.btnCrear.Enabled = false;
            }
            catch (Exception)
            {
                
            }
        }

        public void eliminarPelotitas(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._cantidadPelotitas - 1].Abort();
                this._hilos.RemoveAt(this._cantidadPelotitas - 1);
                this._cantidadPelotitas--;

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
                this.lblCantidad.Text = "Cantidad de pelotitas: " + this._cantidadPelotitas;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void reanudarPelotitas(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._cantidadPelotitas].Resume();
                this._cantidadPelotitas++;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
