
using HerramientasDeProgramacionII.Models.Reservas;

public class ReservaReservas : SQLProviderBase
{
    private String query = "SELECT * FROM reservas.reserva";
    public List<ReservaModels> ConsultarReserva()
    {
        
        List<ReservaModels> reservas = new List<ReservaModels>();
        try
        {
            List<object[]> result = ExecuteReader(query);
            foreach (var row in result)
            {
                reservas.Add(new ReservaModels
                {
                    id = (Int32)row[0],
                    estado = (Boolean)row[1],
                    nombre = (String)row[2],
                    fecha = (DateTime)row[3]
                });
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return reservas;
    }

}