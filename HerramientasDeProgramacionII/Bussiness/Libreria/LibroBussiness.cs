using HerramientasDeProgramacionII.Data.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Bussiness.Libreria
{
    public class LibroBussiness
    {        

        public List<LibroModel> ObtenerLibros()
        {
            DataLibro dataLibro = new DataLibro();
            return dataLibro.ObtenerTodos();
        }

        public LibroModel ObtenerLibroPorId(int id)
        {
            DataLibro dataLibro = new DataLibro();
            return dataLibro.ObtenerPorId(id);
        }

        public void CrearLibro(LibroModel libro)
        {
            CrearLibro dataLibro = new CrearLibro();
            dataLibro.Proceso(libro);
        }

        public void ActualizarLibro(LibroModel libro)
        {
           ActualizarLibroPorId dataLibro = new ActualizarLibroPorId();
            dataLibro.Proceso(libro);
        }

        public void EliminarLibro(int id)
        {
            EliminarLibroPorId dataLibro = new EliminarLibroPorId();
            dataLibro.Proceso(id);
        }
    }
}
