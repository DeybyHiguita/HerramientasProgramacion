using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class CrearSuscriptor : SQLProviderBase
    {
        private string query = "INSERT INTO libreria.suscriptores (documento, nombre, direccion) VALUES (@documento, @nombre, @direccion)";
        private SuscriptorModel suscriptor;

        public CrearSuscriptor(SuscriptorModel suscriptor)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
