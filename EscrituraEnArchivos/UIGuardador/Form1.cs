using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consolaArchivos;

namespace UIGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Guardador.GuardarPersona(new Persona(this.txtNombre.Text, this.txtClave.Text));
            this.cargarListado(Guardador.ListadoDePersonas());
            this.txtNombre.Clear();
            this.txtClave.Clear();         
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cargarListado(List<Persona> listadoDePersonas)
        {
            lstPersonas.Items.Clear();

            foreach (Persona item in listadoDePersonas)
            {
                this.lstPersonas.Items.Add(item);                
            }
        }
    }
}
