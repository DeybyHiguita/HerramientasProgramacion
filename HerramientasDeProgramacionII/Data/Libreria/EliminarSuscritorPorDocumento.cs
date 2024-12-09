namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class EliminarSuscritorPorDocumento : SQLProviderBase
    {
        private string query = "DELETE FROM libreria.suscriptores WHERE documento = @documento";
        private string documento;

        public EliminarSuscritorPorDocumento(string documento)
        {
            this.documento = documento;
        }

        public void Proceso()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@documento", documento);
                ExecuteNonQuery(query, parameters);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
