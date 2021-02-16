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
    public partial class FRegistroPac : Form , ILlenarLimpiar
    {
        CPaciente pa = new CPaciente(); //Instancia de la clase CPaciente

        public FRegistroPac()
        {
            InitializeComponent();
        }

        private void FPacientes_Load(object sender, EventArgs e)
        {
            llenarGridAdaptado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                pa.ID = txtID.Text;
                pa.Cedula = txtCedula.Text;
                pa.Nombre = txtNombre.Text;
                pa.Telefono = txtTelefono.Text;
                pa.Email = txtEmail.Text;
                pa.Direccion = txtDireccion.Text;

                pa.Registrar(pa.ID, pa.Cedula, pa.Nombre, pa.Telefono, pa.Email, pa.Direccion);

                pa.ComunicarRegistro();
                
            }
            catch(Exception error)
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
                pa.ID = txtID.Text;
                pa.Cedula = txtCedula.Text;
                pa.Nombre = txtNombre.Text;
                pa.Telefono = txtTelefono.Text;
                pa.Email = txtEmail.Text;
                pa.Direccion = txtDireccion.Text;

                pa.Actualizar(pa.ID, pa.Cedula, pa.Nombre, pa.Telefono, pa.Email, pa.Direccion);
                
                pa.ComunicarActualizado();
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
                pa.ID = txtID.Text;
                

                pa.Borrar(pa.ID);

                pa.ComunicarBorrado();
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

        public void llenarGridAdaptado()//Este metodo es implementado por medio de la interface
        {
            dataGridViewPa.DataSource = pa.llenarGridAdaptar();
        }

        public void Limpiar()//Este metodo es implementado por medio de la interface
        {
            foreach (Control element in Controls)
            {
                if(element is TextBox)
                {
                    element.Text = "";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                pa.ID = txtBuscar.Text;

                dataGridViewPa.DataSource = pa.Buscar(pa.ID);

                
            
            }catch(Exception error)
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FRegistro fregistro = new FRegistro();

            fregistro.Show();
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
