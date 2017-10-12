using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DB_Lectura
    {

        LocalDBDataContext DB = new LocalDBDataContext();

        public List<Sueldos> Obtener_lista_puesto()
        {

            try
            {
                
                List<Sueldos> s = new List<Sueldos>();

                var consulta = from x in DB.Sueldos select x;
                s.AddRange(consulta);

                return s;
                             
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
