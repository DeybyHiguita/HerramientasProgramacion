using System.ComponentModel.DataAnnotations;

namespace HerramientasDeProgramacionII.Models.Libreria
{
    public class LibroModel
    {
        [Key]
        [Required(ErrorMessage = "El codigo es obligatorio.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [StringLength(50, ErrorMessage = "El autor no puede exceder los 50 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La editorial es obligatoria.")]
        [StringLength(50, ErrorMessage = "La editorial no puede exceder los 50 caracteres.")]
        public string Autor { get; set; }
    }
}
