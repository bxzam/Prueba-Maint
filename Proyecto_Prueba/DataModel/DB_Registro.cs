using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DB_Registro
    {
        LocalDBDataContext DB = new LocalDBDataContext();
        public Boolean Guardar_En_DatosTable(string nombres, string apellidos, string cedula, Guid puesto, int edad, Guid id)
        {
            try
            {
                if (VerificarDatos(cedula))
                {

                    Enviar_a_DB(nombres, apellidos, cedula, puesto, edad, id);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }

         
        }

        private void Enviar_a_DB(string _nombres, string _apellidos, string _cedula, Guid _puesto, int _edad, Guid _id)
        {

            Datos tblDatos = new Datos();

            tblDatos.Nombres = _nombres;
            tblDatos.Apellidos = _apellidos;
            tblDatos.Cedula = _cedula;
            tblDatos.Edad = _edad;
            tblDatos.Puesto = _puesto;
            tblDatos.Id = _id;

            DB.Datos.InsertOnSubmit(tblDatos);
            DB.SubmitChanges();

        }

        private Boolean VerificarDatos(string cedula)
        {

            foreach (Datos d in DB.Datos)
            {

                if (cedula == d.Cedula)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
