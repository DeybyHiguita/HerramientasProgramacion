using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerramientasDeProgramacionII.Models.Libreria
{
    public class PrestamoModel
    {
        [Required(ErrorMessage = "El documento del suscriptor es obligatorio.")]
        [StringLength(8, ErrorMessage = "El documento debe tener 8 caracteres.")]
        [ForeignKey("Suscriptor")]
        public string DocSuscriptor { get; set; }

        [Required(ErrorMessage = "El código del libro es obligatorio.")]
        [ForeignKey("Libro")]
        public int CodigoLibro { get; set; }

        [Required(ErrorMessage = "La fecha de préstamo es obligatoria.")]
        public DateTime FechaPrestamo { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        [Key]
        [Column(Order = 0)]
        public string PrimaryKey => $"{CodigoLibro}_{FechaPrestamo:yyyyMMdd}";
    }
}
