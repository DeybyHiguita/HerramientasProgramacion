using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class CrearUsuario : SQLProviderBase
    {
        private string query = "INSERT INTO libreria.usuarios (nombre, password) VALUES (@nombre, @password)";

        public void Proceso(UsuarioModel usuario)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nombre", usuario.Nombre);
                parameters.Add("@password", usuario.Password);
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
