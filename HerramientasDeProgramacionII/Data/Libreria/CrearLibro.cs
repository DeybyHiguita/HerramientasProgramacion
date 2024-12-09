using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class CrearLibro : SQLProviderBase
    {
        private string query = "INSERT INTO libreria.libro (codigo, titulo, autor) VALUES (@codigo, @titulo, @autor)";

        public void Proceso(LibroModel libro)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@codigo", libro.Codigo },
                    { "@titulo", libro.Titulo },
                    { "@autor", libro.Autor }
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
