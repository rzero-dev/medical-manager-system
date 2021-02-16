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
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FRegistroPac fRegistroPac = new FRegistroPac();
            fRegistroPac.Show();

          

            this.Hide();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FRegistroMed fRegistroMed = new FRegistroMed();
            fRegistroMed.Show();

            this.Hide();
        }

        private void btnClinica_Click(object sender, EventArgs e)
        {
            FRegistroCli fclinicas = new FRegistroCli();

            fclinicas.Show();

            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormularioPrincipal formularioPrincipal = new FormularioPrincipal();

            formularioPrincipal.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
