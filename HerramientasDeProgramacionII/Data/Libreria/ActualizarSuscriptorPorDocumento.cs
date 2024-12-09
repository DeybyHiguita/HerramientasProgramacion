using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class ActualizarSuscriptorPorDocumento : SQLProviderBase
    {
        private string query = "UPDATE libreria.suscriptores SET documento = @documento, nombre = @nombre, direccion = @direccion WHERE documento = @documento";
        private SuscriptorModel suscriptor;

        public ActualizarSuscriptorPorDocumento(SuscriptorModel suscriptor)
        {
            this.suscriptor = suscriptor;
        }

        public void Proceso()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@documento", suscriptor.Documento },
                    { "@nombre", suscriptor.Nombre },
                    { "@direccion", suscriptor.Direccion }
                };
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
