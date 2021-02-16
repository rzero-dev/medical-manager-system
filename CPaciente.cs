using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Para utilizar ADO.NET
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final
{
    class CPaciente : DataBaseClinica
    {
        //Conexion a Sql Server
        SqlConnection conex = new SqlConnection("Data Source=LENOVO-G50\\ROSDB;Initial Catalog=DataBase Final Project;Integrated Security=True");

        SqlCommand command;

        //Metodos propios
        public void Registrar(string id, string ced, string nom, string tel, string em, string dir)
        {
            conex.Open();
            string commandLine = $"insert into Pacientes values ('{id}','{ced}','{nom}','{tel}','{em}','{dir}')";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }
        public void Actualizar(string id, string ced, string nom, string tel, string em, string dir)
        {
            conex.Open();
            string commandLine = $"update Pacientes set Cedula='{ced}', Nombre='{nom}', Telefono='{tel}', Email='{em}', Direccion='{dir}' where ID = '{id}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        
        public override void Borrar(string id)//Metodo virtual
        {
            conex.Open();
            string commandLine = $"delete from Pacientes where ID = '{id}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        //Metodos abstractos
        public override DataTable llenarGridAdaptar() //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = "select * from Pacientes"; //Texto del comando
            command = new SqlCommand(commandLine, conex); //Creacion objeto del comando
            command.ExecuteNonQuery(); //Ejecuta el comando

            SqlDataAdapter data = new SqlDataAdapter(command);//Adapta los datos proveniente de la base de datos

            DataTable table = new DataTable(); //crea un objeto para una tabla en memoria

            data.Fill(table); //llena la tabla con los datos adaptados

            conex.Close(); //cierra la conexion

            return table; //retorna la tabla 

        }

        public override DataTable Buscar(string id) //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = $"select * from Pacientes where ID = '{id}'"; //Texto del comando
            command = new SqlCommand(commandLine, conex); //Creacion objeto del comando
            command.ExecuteNonQuery(); //Ejecuta el comando

            SqlDataAdapter data = new SqlDataAdapter(command);//Adapta los datos proveniente de la base de datos

            DataTable table = new DataTable(); //crea un objeto para una tabla en memoria

            data.Fill(table); //llena la tabla con los datos adaptados

            conex.Close(); //cierra la conexion

            return table; //retorna la tabla 

        }

        //Metodos virtuales heredados y sobreescritos
        public override void ComunicarRegistro()
        {
            MessageBox.Show("Paciente registrado correctamente.");
        }
        public override void ComunicarActualizado()
        {
            MessageBox.Show("Paciente Actualizado correctamente.");
        }
        public override void ComunicarBorrado()
        {
            MessageBox.Show("Paciente eliminado correctamente.");
        }


    }
}
