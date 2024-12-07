using HerramientasDeProgramacionII.Models.Empleado;
using HerramientasDeProgramacionII.Models.Reservas;

namespace HerramientasDeProgramacionII.Data.Empleado
{
    public class DataEmpleado : SQLProviderBase
    {
        private String query = "SELECT * FROM empleado.empleado";
        public List<EmpleadoModel> Proceso()
        {

            List<EmpleadoModel> modelo = new List<EmpleadoModel>();
            try
            {
                List<object[]> result = ExecuteReader(query);
                foreach (var row in result)
                {
                    modelo.Add(new EmpleadoModel
                    {
                        idempleado = (Int32)row[0],
                        apellido = (String)row[1],
                        nombre = (String)row[2],
                        direccion = (String)row[3],
                        email = (String)row[4]
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return modelo;
        }
    }
}
