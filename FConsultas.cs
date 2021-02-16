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
    public partial class FConsultas : Form
    {
        public FConsultas()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FConsultasPac fConsultasPac = new FConsultasPac();

            fConsultasPac.Show();

            this.Hide();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FConsultasMed fConsultasMed = new FConsultasMed();

            fConsultasMed.Show();

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
