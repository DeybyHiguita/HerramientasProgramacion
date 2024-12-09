using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HerramientasDeProgramacionII.Models.Libreria
{
    public class ReporteModel
    {
        public SuscriptorModel Suscriptor { get; set; }
        public LibroModel Libro { get; set; }
        public PrestamoModel Prestamo { get; set; }
    }
}
