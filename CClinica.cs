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
    class CClinica : DataBaseClinica
    {

        //Conexion a Sql Server
        SqlConnection conex = new SqlConnection("Data Source=LENOVO-G50\\ROSDB;Initial Catalog=DataBase Final Project;Integrated Security=True");

        SqlCommand command;


        //Metodos propios
        public void Registrar(string id, string nom, string dir)
        {
            conex.Open();
            string commandLine = $"insert into Clinicas values ('{id}','{nom}','{dir}')";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }
        public void Actualizar(string id, string nom, string dir)
        {
            conex.Open();
            string commandLine = $"update Clinicas set Nombre='{nom}', Direccion='{dir}' where ID = '{id}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        
        public override void Borrar(string id)//Metodo virtual
        {
            conex.Open();
            string commandLine = $"delete from Clinicas where ID = '{id}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        //Metodos abstractos
        public override DataTable llenarGridAdaptar() //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = "select * from Clinicas"; //Texto del comando
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
            string commandLine = $"select * from Clinicas where ID = '{id}'"; //Texto del comando
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
            MessageBox.Show("Clinica registrada correctamente.");
        }
        public override void ComunicarActualizado()
        {
            MessageBox.Show("Clinica actualizada correctamente.");
        }
        public override void ComunicarBorrado()
        {
            MessageBox.Show("Clinica eliminada correctamente.");
        }
    }
}
