using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
namespace BussinesLayer
{
    public class Enviar
    {
        DB_Registro g = new DB_Registro();
        public Boolean Guardar_en_datos(string nombres, string apellidos, string cedula, Guid puesto, int edad)
        {

             return g.Guardar_En_DatosTable(nombres, apellidos, cedula, puesto, edad, Guid.NewGuid());
                       
        }

        
        
    }
}
