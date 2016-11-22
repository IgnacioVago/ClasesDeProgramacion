using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SegundoParcialModelo
{
    public partial class frmEsqueleto : Form
    {
        public Empleado miEmpleado;

        public frmEsqueleto()
        {
            InitializeComponent();
            miEmpleado = new Empleado("Juan Martin", "Pollio", 40916958);
            //this.btnGuardar.Click += this.btnGuardar_Click;
        }

        private void frmEsqueleto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread hilo;
            hilo = new Thread(this.IngresarPersona);
            hilo.Start();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread hilo;
            hilo = new Thread(this.LeerPersona);
            hilo.Start();
        }

        public void IngresarPersona()
        {
            if (miEmpleado.guardar("empleado.xml", miEmpleado))
            {
                MessageBox.Show("Empleado guardado");
            }
            else
            {
                MessageBox.Show("Empleado no guardado");
            }
        }

        public void LeerPersona()
        {
            Empleado aux;

            if (miEmpleado.leer("empleado.xml", out aux))
            {
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Empleado no leído");
            }
        }
    }
}
