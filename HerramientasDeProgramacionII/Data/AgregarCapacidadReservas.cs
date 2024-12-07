using HerramientasDeProgramacionII.Models.Reservas;

namespace HerramientasDeProgramacionII.Data
{
    public class AgregarCapacidadReservas : SQLProviderBase
    {
        private String query = "INSERT INTO reservas.reserva(estado, nombre, fecha) VALUES (@estado, @nombre, @fecha)";
        int capacidad = 0;
        public void Proceso(int capacidad)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@estado", false);
                parameters.Add("@nombre", "");
                parameters.Add("@fecha", DateTime.Now);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
