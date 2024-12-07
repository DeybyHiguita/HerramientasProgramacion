namespace HerramientasDeProgramacionII.Models.Reservas
{
    public class RecervasAppModels
    {
        public List<ReservaModels> reservaModels { get; set; }
        public int capacidad { get; set; }

        public List<ReservaModels> disponibles { get; set; }
        public List<ReservaModels> reservadas { get; set; }
        public ReservaModels crearReserva { get; set; }
        public int ultimaReserva { get; set; } 
        public int ultimaReservaEliminar { get; set; }
    }
}
