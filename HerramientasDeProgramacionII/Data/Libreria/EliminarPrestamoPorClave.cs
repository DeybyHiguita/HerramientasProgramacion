using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class EliminarPrestamoPorClave : SQLProviderBase
    {
        private string query = "DELETE FROM libreria.prestamos WHERE codigolibro = @codigolibro AND fechaprestamo = @fechaprestamo;";
        private PrestamoModel prestamo;

        public EliminarPrestamoPorClave(PrestamoModel prestamo)
        {
            this.prestamo = prestamo;
        }

        public void Proceso()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@codigolibro", prestamo.CodigoLibro);
                parameters.Add("@fechaprestamo", prestamo.FechaPrestamo.ToString("yyyy-MM-dd"));
                ExecuteNonQuery(query, parameters);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
