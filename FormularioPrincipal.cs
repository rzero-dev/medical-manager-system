using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FormularioPrincipal : Form
    {
        
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FRegistro fregistro = new FRegistro();

            fregistro.Show();

            this.Hide();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FConsultas fConsultas = new FConsultas();

            fConsultas.Show();

            this.Hide();

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FRegistroCitas fRegistroCitas = new FRegistroCitas();

            fRegistroCitas.Show();
            this.Hide();


        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            FConversor fConversor = new FConversor();
            fConversor.Show();
            this.Hide();

        }
    }

}
