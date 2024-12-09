using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class DataPrestamo : SQLProviderBase
    {
        private string querySelectAll = "SELECT * FROM libreria.prestamos";
        private string querySelectByKey = "SELECT * FROM libreria.prestamos WHERE codigolibro = @codigolibro AND fechaprestamo = @fechaprestamo";

        // Método para obtener todos los préstamos
        public List<PrestamoModel> ObtenerTodos()
        {
            List<PrestamoModel> prestamos = new List<PrestamoModel>();
            try
            {
                List<object[]> result = ExecuteReader(querySelectAll);
                foreach (var row in result)
                {
                    prestamos.Add(new PrestamoModel
                    {
                        DocSuscriptor = (string)row[0],
                        CodigoLibro = (int)row[1],
                        FechaPrestamo = (DateTime)row[2],
                        FechaDevolucion = row[3] != DBNull.Value ? (DateTime?)row[3] : null
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return prestamos;
        }

        // Método para obtener un préstamo por clave compuesta
        public PrestamoModel ObtenerPorClave(int codigoLibro, DateTime fechaPrestamo)
        {
            PrestamoModel prestamo = null;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@codigolibro", codigoLibro },
                    { "@fechaprestamo", fechaPrestamo }
                };

                List<object[]> result = ExecuteReader(querySelectByKey, parameters);
                if (result.Count > 0)
                {
                    var row = result[0];
                    prestamo = new PrestamoModel
                    {
                        DocSuscriptor = (string)row[0],
                        CodigoLibro = (int)row[1],
                        FechaPrestamo = (DateTime)row[2],
                        FechaDevolucion = row[3] != DBNull.Value ? (DateTime?)row[3] : null
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return prestamo;
        }
    }
}
