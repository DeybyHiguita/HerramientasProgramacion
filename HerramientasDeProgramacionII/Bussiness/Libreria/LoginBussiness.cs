using HerramientasDeProgramacionII.Data.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Bussiness.Libreria
{
    public class LoginBussiness
    {
        public Boolean DataUsuarioPorNombre(UsuarioModel usuario)
        {
            DataUsuario dataUsuario = new DataUsuario();
            UsuarioModel usuarioModel = dataUsuario.ObtenerPorNombre(usuario.Nombre);
            if (usuarioModel != null)
            {
                if (usuarioModel.Password == usuario.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public void CrearUsuario(UsuarioModel usuario)
        {
            CrearUsuario dataUsuario = new CrearUsuario();
            dataUsuario.Proceso(usuario);
        }


    }
}
