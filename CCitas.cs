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
    class CCitas : DataBaseClinica
    {
        //Atributos propios de la clase
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Exequatur { get; set; }
        public string Clinica { get; set; }
        public string Causa { get; set; }
        public string morf { get; set; }//Su valor es variable dependiendo del caso


        //Conexion a Sql Server
        SqlConnection conex = new SqlConnection("Data Source=LENOVO-G50\\ROSDB;Initial Catalog=DataBase Final Project;Integrated Security=True");

        SqlCommand command;

        //Metodos propios
        public void Registrar(string exeq, string med, string pac, string fecha, string hora, string cli, string causa)
        {
            conex.Open();
            string commandLine = $"insert into Citas values ('{exeq}','{med}','{pac}','{fecha}','{hora}','{cli}','{causa}')";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }
        public void Actualizar(string exeq, string med, string pac, string fecha, string hora, string cli, string causa)
        {
            conex.Open();
            string commandLine = $"update Citas set Exequatur='{exeq}', Medico='{med}', Paciente='{pac}', Fecha='{fecha}', Hora='{hora}', Clinica='{cli}', Causa='{causa}' where Medico = '{med}' or Exequatur='{exeq}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        
        public override void Borrar(string morf)//Metodo virtual
        {
            conex.Open();
            string commandLine = $"delete from Citas where Medico = '{morf}' or Exequatur = '{morf}'";
            command = new SqlCommand(commandLine, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }

        //Metodos abstractos
        public override DataTable llenarGridAdaptar() //Metodo para usar el DataGridView
        {
            conex.Open(); //Abre la conexion
            string commandLine = "select * from Citas"; //Texto del comando
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
            string commandLine = $"select * from Citas where Medico = '{morf}' or Exequatur = '{morf}'"; //Texto del comando
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
            MessageBox.Show("Cita registrada correctamente.");
        }
        public override void ComunicarActualizado()
        {
            MessageBox.Show("Cita Actualizada correctamente.");
        }
        public override void ComunicarBorrado()
        {
            MessageBox.Show("Cita eliminado correctamente.");
        }



    }
}
