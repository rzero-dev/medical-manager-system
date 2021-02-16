using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_Final
{
    public partial class FRegistroCitas : Form , ILlenarLimpiar
    {
        CCitas ci = new CCitas();
        public FRegistroCitas()
        {
            InitializeComponent();
        }

        private void FRegistroCitas_Load(object sender, EventArgs e)
        {
            llenarGridAdaptado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ci.Exequatur = txtExequatur.Text;
                ci.Medico = txtMedico.Text;
                ci.Paciente = txtPaciente.Text;
                ci.Fecha = txtFecha.Text;
                ci.Hora = txtHora.Text; 
                ci.Clinica = txtClinica.Text;
                ci.Causa = txtCausa.Text;

                ci.Registrar(ci.Exequatur, ci.Medico, ci.Paciente, ci.Fecha, ci.Hora, ci.Clinica, ci.Causa);
                ci.ComunicarRegistro();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ci.morf = txtExequatur.Text;
                ci.morf = txtMedico.Text; 
                ci.Paciente = txtPaciente.Text;
                ci.Fecha = txtFecha.Text;
                ci.Hora = txtHora.Text;
                ci.Clinica = txtClinica.Text;
                ci.Causa = txtCausa.Text;


                ci.Actualizar(ci.morf, ci.morf, ci.Paciente, ci.Fecha, ci.Hora, ci.Clinica, ci.Causa);
                ci.ComunicarActualizado();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                ci.morf = txtMedico.Text;
                ci.morf = txtExequatur.Text;

                ci.Borrar(ci.morf);
                ci.ComunicarBorrado();
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ci.morf = txtBuscar.Text;

                dataGridViewCit.DataSource = ci.Buscar(ci.morf);



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

       

        public void llenarGridAdaptado()//Este metodo es implementado por medio de la interface
        {
            dataGridViewCit.DataSource = ci.llenarGridAdaptar();
        }
        public void Limpiar()//Este metodo es implementado por medio de la interface
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
