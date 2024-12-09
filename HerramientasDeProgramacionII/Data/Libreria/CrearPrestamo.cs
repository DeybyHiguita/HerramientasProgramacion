using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class CrearPrestamo : SQLProviderBase
    {
        private string query = "INSERT INTO libreria.prestamos (docsuscriptor, codigolibro, fechaprestamo, fechadevolucion) VALUES (@docsuscriptor, @codigolibro, @fechaprestamo, @fechadevolucion)";
        private PrestamoModel prestamo;

        public CrearPrestamo(PrestamoModel prestamo)
        {
            this.prestamo = prestamo;
        }
        public void Proceso()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@docsuscriptor", prestamo.DocSuscriptor },
                    { "@codigolibro", prestamo.CodigoLibro },
                    { "@fechaprestamo", prestamo.FechaPrestamo },
                    { "@fechadevolucion", prestamo.FechaDevolucion ?? (object)DBNull.Value }
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
