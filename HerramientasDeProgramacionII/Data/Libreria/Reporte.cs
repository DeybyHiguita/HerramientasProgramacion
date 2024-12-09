using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class Reporte : SQLProviderBase
    {
        private string query = "SELECT \r\n    p.docsuscriptor AS DocumentoSuscriptor,\r\n    s.nombre AS NombreSuscriptor,\r\n    s.direccion AS DireccionSuscriptor,\r\n    l.codigo AS CodigoLibro,\r\n    l.titulo AS TituloLibro,\r\n    l.autor AS AutorLibro,\r\n    p.fechaprestamo AS FechaPrestamo,\r\n    p.fechadevolucion AS FechaDevolucion\r\nFROM \r\n    libreria.prestamos p\r\nINNER JOIN \r\n    libreria.suscriptores s ON p.docsuscriptor = s.documento\r\nINNER JOIN \r\n    libreria.libro l ON p.codigolibro = l.codigo\r\nORDER BY \r\n    p.fechaprestamo DESC;\r\n";
        public List<ReporteModel> Proceso()
        {
            try
            {
                List<ReporteModel> reporte = new List<ReporteModel>();
                List<object[]> result = ExecuteReader(query);
                foreach (var row in result)
                {
                    reporte.Add(new ReporteModel
                    {
                        Suscriptor = new SuscriptorModel
                        {
                            Documento = row[0].ToString(),
                            Nombre = row[1].ToString(),
                            Direccion = row[2].ToString()
                        },
                        Libro = new LibroModel
                        {
                            Codigo = (int)row[3],
                            Titulo = row[4].ToString(),
                            Autor = row[5].ToString()
                        },
                        Prestamo = new PrestamoModel
                        {
                            FechaPrestamo = Convert.ToDateTime(row[6]),
                            //Si es null colocar null
                            FechaDevolucion = row[7] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[7])
                        }
                    });
                }

                return reporte;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
