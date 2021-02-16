using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;//using para el manejos de controles en el formulario


namespace Proyecto_Final
{
    public abstract class DataBaseClinica
    {
        //Atributos

        public string ID { get; set; }
        public string Cedula { get; set; }
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length < 1)
                {
                    nombre = "Desconocido";
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }



        //Metodos abstractos
      
        public abstract DataTable llenarGridAdaptar();//Metodo que adapta los datos provenientes de la base de datos

        public abstract DataTable Buscar(string id);

        //Metodos virtuales
        public virtual void Borrar(string id)
        {

        }
        public virtual void ComunicarRegistro()
        {
            MessageBox.Show("Datos registrados correctamente.");
        }
        public virtual void ComunicarActualizado()
        {
            MessageBox.Show("Datos actualizados correctamente.");
        }
        public virtual void ComunicarBorrado()
        {
            MessageBox.Show("Datos borrados correctamente.");
        }

        
    }
}
