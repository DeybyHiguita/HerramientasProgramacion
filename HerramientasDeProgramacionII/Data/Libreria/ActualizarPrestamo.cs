using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class ActualizarPrestamo : SQLProviderBase
    {
        private string query = @"UPDATE libreria.prestamos SET FechaDevolucion = @FechaDevolucion
                                WHERE  CodigoLibro = @CodigoLibro AND DocSuscriptor = @DocSuscriptor AND FechaPrestamo = @FechaPrestamo;";
                                

        private PrestamoModel prestamo;
        public ActualizarPrestamo(PrestamoModel prestamo)
        {
            this.prestamo = prestamo;
        }

        public void Proceso()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@DocSuscriptor", prestamo.DocSuscriptor },
                    { "@CodigoLibro", prestamo.CodigoLibro },
                    { "@FechaPrestamo",prestamo.FechaPrestamo },
                    { "@FechaDevolucion", prestamo.FechaDevolucion }
                };

                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
