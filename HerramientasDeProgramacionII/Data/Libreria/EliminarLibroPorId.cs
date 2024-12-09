namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class EliminarLibroPorId : SQLProviderBase
    {
        private string query = "DELETE FROM libreria.libro WHERE codigo = @codigo";

        public void Proceso(int id)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@codigo", id }
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
