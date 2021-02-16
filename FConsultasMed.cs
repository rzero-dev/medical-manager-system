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
    public partial class FConsultasMed : Form , ILlenarLimpiar
    
    {
        CConsultasMed consultmed = new CConsultasMed();//Instancia de la classe CConsultasPac

        public FConsultasMed()
        {
            InitializeComponent();
        }

        private void FConsultasMed_Load(object sender, EventArgs e)
        {
            llenarGridAdaptado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                consultmed.morf = txtBuscar.Text;


                dataGridViewConsultaPac.DataSource = consultmed.Buscar(consultmed.morf);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            Limpiar();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            llenarGridAdaptado();

            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void llenarGridAdaptado()//Metodo heredado de la interface
        {
            dataGridViewConsultaPac.DataSource = consultmed.llenarGridAdaptar();
        }

        public void Limpiar()//Metodo heredado de la interface
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    element.Text = "";
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FConsultas fConsultas = new FConsultas();

            fConsultas.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
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
