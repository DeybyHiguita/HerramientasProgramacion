using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class DataLibro : SQLProviderBase
    {
        private string querySelectAll = "SELECT * FROM libreria.libro";
        private string querySelectByKey = "SELECT * FROM libreria.libro WHERE codigo = @codigo";

        // Método para obtener todos los libros
        public List<LibroModel> ObtenerTodos()
        {
            List<LibroModel> libros = new List<LibroModel>();
            try
            {
                List<object[]> result = ExecuteReader(querySelectAll);
                foreach (var row in result)
                {
                    libros.Add(new LibroModel
                    {
                        Codigo = (int)row[0],
                        Titulo = (string)row[1],
                        Autor = (string)row[2]
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return libros;
        }

        // Método para obtener un libro por ID (clave primaria)
        public LibroModel ObtenerPorId(int id)
        {
            LibroModel libro = null;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@codigo", id }
                };

                List<object[]> result = ExecuteReader(querySelectByKey, parameters);
                if (result.Count > 0)
                {
                    var row = result[0];
                    libro = new LibroModel
                    {
                        Codigo = (int)row[0],
                        Titulo = (string)row[1],
                        Autor = (string)row[2]
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return libro;
        }
    }
}
