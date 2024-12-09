using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class DataUsuario : SQLProviderBase
    {
        private string querySelectAll = "SELECT * FROM libreria.usuarios";
        private string querySelectByKey = "SELECT * FROM libreria.usuarios WHERE nombre = @nombre";

        // Método para obtener todos los usuarios
        public List<UsuarioModel> ObtenerTodos()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            try
            {
                List<object[]> result = ExecuteReader(querySelectAll);
                foreach (var row in result)
                {
                    usuarios.Add(new UsuarioModel
                    {
                        Nombre = (string)row[0],
                        Password = (string)row[1]
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuarios;
        }

        // Método para obtener un usuario por nombre (clave primaria)
        public UsuarioModel ObtenerPorNombre(string nombre)
        {
            UsuarioModel usuario = null;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nombre", nombre }
                };

                List<object[]> result = ExecuteReader(querySelectByKey, parameters);
                if (result.Count > 0)
                {
                    var row = result[0];
                    usuario = new UsuarioModel
                    {
                        Nombre = (string)row[0],
                        Password = (string)row[1]
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }
    }
}
