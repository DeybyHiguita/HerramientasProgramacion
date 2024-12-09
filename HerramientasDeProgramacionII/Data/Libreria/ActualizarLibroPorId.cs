using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class ActualizarLibroPorId : SQLProviderBase
    {
        private string query = "UPDATE libreria.libro SET titulo = @titulo, autor = @autor WHERE codigo = @codigo";

        public void Proceso(LibroModel libro)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@titulo", libro.Titulo },
                    { "@autor", libro.Autor },
                    { "@codigo", libro.Codigo }
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
