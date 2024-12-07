using HerramientasDeProgramacionII.Models.Reservas;

namespace HerramientasDeProgramacionII.Data
{
    public class ActualizarReservaReservas : SQLProviderBase
    {
        private String query = "UPDATE reservas.reserva SET estado = @estado, nombre = @nombre, fecha = @fecha WHERE id = @id";
        public void Proceso(ReservaModels reservaModels)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@estado", reservaModels.estado);
                parameters.Add("@nombre", reservaModels.nombre);
                parameters.Add("@fecha", reservaModels.fecha);
                parameters.Add("@id", reservaModels.id);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
