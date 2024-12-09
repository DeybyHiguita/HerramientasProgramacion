using System.ComponentModel.DataAnnotations;

namespace HerramientasDeProgramacionII.Models.Libreria
{
    public class SuscriptorModel
    {
        [Key]
        [Required(ErrorMessage = "El documento es obligatorio.")]
        [StringLength(8, ErrorMessage = "El documento debe tener 8 caracteres.")]
        public string Documento { get; set; }

        [StringLength(30, ErrorMessage = "El nombre no puede exceder los 30 caracteres.")]
        public string Nombre { get; set; }

        [StringLength(30, ErrorMessage = "La dirección no puede exceder los 30 caracteres.")]
        public string Direccion { get; set; }
    }
}
