using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace BussinesLayer
{
    public class Recibir
    {
        DB_Lectura l = new DB_Lectura();
        public void Lista_de_puestos(ComboBox cbo)
        {
            try
            {

                List<Sueldos> sueldos = l.Obtener_lista_puesto();

                cbo.DataSource = sueldos;
                cbo.DisplayMember = "Puesto";
                cbo.ValueMember = "Id";
                                
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
