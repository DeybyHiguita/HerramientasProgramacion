using HerramientasDeProgramacionII.Data.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Bussiness.Libreria
{
    public class ReporteBussiness
    {
        public List<ReporteModel> Proceso()
        {
            Reporte reposte = new Reporte();
            return reposte.Proceso();
        }
    }
}
