using HerramientasDeProgramacionII.Models.Empleado;

namespace HerramientasDeProgramacionII.Data.Empleado
{
    public class EliminarEmpleado : SQLProviderBase
    {
        private String query = "DELETE FROM empleado.empleado WHERE idempleado = @idempleado";
        public void proceso(int empleado)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idempleado", empleado);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
