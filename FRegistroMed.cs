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
    public partial class FRegistroMed : Form , ILlenarLimpiar
    {
        CMedico me = new CMedico();//Instancia de la clase CMedico

        public FRegistroMed()
        {
            InitializeComponent();
        }

        private void FMedicos_Load(object sender, EventArgs e)
        {
            llenarGridAdaptado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                me.ID = txtID.Text;
                me.Cedula = txtCedula.Text;
                me.Exequatur = txtExequatur.Text;
                me.Nombre = txtNombre.Text;
                me.Telefono = txtTelefono.Text;
                me.Email = txtEmail.Text;
                me.Clinica = txtClinica.Text;

                me.Registrar(me.ID, me.Cedula, me.Exequatur, me.Nombre, me.Telefono, me.Email, me.Clinica);

                me.ComunicarRegistro();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                me.ID = txtID.Text;
                me.Cedula = txtCedula.Text;
                me.Exequatur = txtExequatur.Text;
                me.Nombre = txtNombre.Text;
                me.Telefono = txtTelefono.Text;
                me.Email = txtEmail.Text;
                me.Clinica = txtClinica.Text;

                me.Actualizar(me.ID, me.Cedula, me.Exequatur, me.Nombre, me.Telefono, me.Email, me.Clinica);

                me.ComunicarActualizado();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                me.ID = txtID.Text;
                

                me.Borrar(me.ID);

                me.ComunicarBorrado();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            llenarGridAdaptado();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                me.ID = txtBuscar.Text;

                dataGridViewMe.DataSource = me.Buscar(me.ID);
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            Limpiar();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenarGridAdaptado();

            Limpiar();
        }

        public void llenarGridAdaptado()//Este metodo es implementado por medio de la interface
        {
            dataGridViewMe.DataSource = me.llenarGridAdaptar();
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
            FRegistro fregistro = new FRegistro();

            fregistro.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormularioPrincipal formularioPrincipal = new FormularioPrincipal();

            formularioPrincipal.Show();
            this.Hide();
        }

       
    }
}
