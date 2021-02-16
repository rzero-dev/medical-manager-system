using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//using para utilizar ADO.NET
using System.Data;

namespace Proyecto_Final
{
    class CConsultasMed : DataBaseClinica
    {
        //Atributo local

        public string morf { get; set; }

        //Conexion a Sql Server
        SqlConnection conex = new SqlConnection("Data Source=LENOVO-G50\\ROSDB;Initial Catalog=DataBase Final Project;Integrated Security=True");

        SqlCommand command;


        //Metodos bastractos heredados de la clase principal DataBaseClinica
        public override DataTable llenarGridAdaptar() //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = "select * from Medicos"; //Texto del comando
            command = new SqlCommand(commandLine, conex); //Creacion objeto del comando
            command.ExecuteNonQuery(); //Ejecuta el comando

            SqlDataAdapter data = new SqlDataAdapter(command);//Adapta los datos proveniente de la base de datos

            DataTable table = new DataTable(); //crea un objeto para una tabla en memoria

            data.Fill(table); //llena la tabla con los datos adaptados

            conex.Close(); //cierra la conexion

            return table; //retorna la tabla 

        }

        public override DataTable Buscar(string morf) //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = $"select * from Medicos where Nombre = '{morf}' or Exequatur= '{morf}'"; //Texto del comando
            command = new SqlCommand(commandLine, conex); //Creacion objeto del comando
            command.ExecuteNonQuery(); //Ejecuta el comando

            SqlDataAdapter data = new SqlDataAdapter(command);//Adapta los datos proveniente de la base de datos

            DataTable table = new DataTable(); //crea un objeto para una tabla en memoria

            data.Fill(table); //llena la tabla con los datos adaptados

            conex.Close(); //cierra la conexion

            return table; //retorna la tabla 

        }
    }
}
