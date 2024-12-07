using HerramientasDeProgramacionII.Models.Empleado;

namespace HerramientasDeProgramacionII.Data.Empleado
{
    public class DataEmpleadoPorIdempleado : SQLProviderBase
    {
        private String query = "SELECT * FROM empleado.empleado WHERE idempleado = @idempleado";
        public EmpleadoModel Proceso(int idempleado)
        {
            EmpleadoModel modelo = new EmpleadoModel();
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idempleado", idempleado);
                List<object[]> result = ExecuteReader(query, parameters);
                foreach (var row in result)
                {
                    modelo.idempleado = (Int32)row[0];
                    modelo.apellido = (String)row[1];
                    modelo.nombre = (String)row[2];
                    modelo.direccion = (String)row[3];
                    modelo.email = (String)row[4];
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
