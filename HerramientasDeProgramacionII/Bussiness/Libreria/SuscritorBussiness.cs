using HerramientasDeProgramacionII.Data.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Bussiness.Libreria
{
    public class SuscritorBussiness
    {
        public List<SuscriptorModel> ObtenerSuscritores()
        {
            DataSuscriptor dataSuscriptor = new DataSuscriptor();
            return dataSuscriptor.ObtenerTodos();
        }

        public void CrearSuscriptor(SuscriptorModel suscriptor)
        {
            CrearSuscriptor crearSuscriptor = new CrearSuscriptor(suscriptor);
            crearSuscriptor.Proceso();
        }

        public void ActualizarSuscriptor(SuscriptorModel suscriptor)
        {
            ActualizarSuscriptorPorDocumento actualizarSuscriptor = new ActualizarSuscriptorPorDocumento(suscriptor);
            actualizarSuscriptor.Proceso();
        }

        public void EliminarSuscriptor(string suscriptor)
        {
            EliminarSuscritorPorDocumento eliminarSuscriptor = new EliminarSuscritorPorDocumento(suscriptor);
            eliminarSuscriptor.Proceso();
        }
    }
}
