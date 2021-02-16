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
    public partial class FConversor : Form
    {
        double dollarpeso = 52.83;
        double europeso = 58.15;
        double dollareuro = 0.91;
        double eurodollar = 1.10;
        double resultado;
        
        public FConversor()
        {
            InitializeComponent();
            comboMonedaOrigen.Items.Add("Dollar");
            comboMonedaOrigen.Items.Add("Euro");
            comboMonedaOrigen.Items.Add("Peso");

            comboMonedaDestino.Items.Add("Dollar");
            comboMonedaDestino.Items.Add("Euro");
            comboMonedaDestino.Items.Add("Peso");


        }

        private void FConversor_Load(object sender, EventArgs e)
        {

        }

        private void comboMonedaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMonedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboMonedaOrigen.SelectedItem.ToString() == "Dollar" && comboMonedaDestino.SelectedItem.ToString() == "Euro")
                {
                    resultado = double.Parse(txtCantidad.Text);
                    resultado = resultado * dollareuro;
                    lblResultado.Text = resultado.ToString();
                }
                if (comboMonedaOrigen.SelectedItem.ToString() == "Euro" && comboMonedaDestino.SelectedItem.ToString() == "Dollar")
                {
                    {
                        resultado = double.Parse(txtCantidad.Text);
                        resultado = resultado * eurodollar;
                        lblResultado.Text = resultado.ToString();
                    }
                }
                if (comboMonedaOrigen.SelectedItem.ToString() == "Peso" && comboMonedaDestino.SelectedItem.ToString() == "Dollar")
                {
                    resultado = double.Parse(txtCantidad.Text);
                    resultado = resultado / dollarpeso;
                    lblResultado.Text = resultado.ToString() + " $";
                }
                if (comboMonedaOrigen.SelectedItem.ToString() == "Dollar" && comboMonedaDestino.SelectedItem.ToString() == "Peso")
                {
                    resultado = double.Parse(txtCantidad.Text);
                    resultado = resultado * dollarpeso;
                    lblResultado.Text = resultado.ToString() + " $";
                    
                }
                if (comboMonedaOrigen.SelectedItem.ToString() == "Peso" && comboMonedaDestino.SelectedItem.ToString() == "Euro")
                {
                    resultado = double.Parse(txtCantidad.Text);
                    resultado = resultado / europeso;
                    lblResultado.Text = resultado.ToString() + " $";
                }
                if (comboMonedaOrigen.SelectedItem.ToString() == "Euro" && comboMonedaDestino.SelectedItem.ToString() == "Peso")
                {
                    resultado = double.Parse(txtCantidad.Text);
                    resultado = resultado * europeso;
                    lblResultado.Text = resultado.ToString() + " $";
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
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
