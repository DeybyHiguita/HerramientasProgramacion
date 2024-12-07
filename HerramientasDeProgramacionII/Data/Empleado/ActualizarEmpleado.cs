using HerramientasDeProgramacionII.Models.Empleado;
using HerramientasDeProgramacionII.Models.Reservas;
using System.Data.SqlClient;

namespace HerramientasDeProgramacionII.Data.Empleado
{
    public class ActualizarEmpleado : SQLProviderBase
    {
        private String query = "UPDATE empleado.empleado SET apellido = @apellido, nombre = @nombre, direccion = @direccion, email = @email WHERE idempleado = @idempleado";
        public void proceso(EmpleadoModel empleado)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@apellido", empleado.apellido);
                parameters.Add("@nombre", empleado.nombre);
                parameters.Add("@direccion", empleado.direccion);
                parameters.Add("@email", empleado.email);
                parameters.Add("@idempleado", empleado.idempleado);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
