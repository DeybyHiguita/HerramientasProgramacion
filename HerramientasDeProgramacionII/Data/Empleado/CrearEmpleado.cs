using HerramientasDeProgramacionII.Models.Empleado;

namespace HerramientasDeProgramacionII.Data.Empleado
{
    public class CrearEmpleado : SQLProviderBase
    {
        private String query = "INSERT INTO empleado.empleado (idempleado, apellido, nombre, direccion, email) VALUES (@idempleado, @apellido, @nombre, @direccion, @email)";
        public void proceso(EmpleadoModel empleado)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idempleado", empleado.idempleado);
                parameters.Add("@apellido", empleado.apellido);
                parameters.Add("@nombre", empleado.nombre);
                parameters.Add("@direccion", empleado.direccion);
                parameters.Add("@email", empleado.email);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
