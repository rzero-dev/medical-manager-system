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
    public partial class FRegistroCli : Form , ILlenarLimpiar
    {

        CClinica cli = new CClinica();//Instancia de la clase CClinica

        public FRegistroCli()
        {
            InitializeComponent();
        }

     
        private void FClinicas_Load(object sender, EventArgs e)
        {
            llenarGridAdaptado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                cli.ID = txtID.Text;
                cli.Nombre = txtNombre.Text;
                cli.Direccion = txtDireccion.Text;

                cli.Registrar(cli.ID, cli.Nombre, cli.Direccion);

                cli.ComunicarRegistro();

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

                cli.ID = txtID.Text;
                cli.Nombre = txtNombre.Text;
                cli.Direccion = txtDireccion.Text;

                cli.Actualizar(cli.ID, cli.Nombre, cli.Direccion);

                cli.ComunicarActualizado ();

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

                cli.ID = txtID.Text;
                

                cli.Borrar(cli.ID);

                cli.ComunicarBorrado();

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
                cli.ID = txtBuscar.Text;

                dataGridViewCli.DataSource = cli.Buscar(cli.ID);

                
            }
            catch (Exception error)
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
            dataGridViewCli.DataSource = cli.llenarGridAdaptar();
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
