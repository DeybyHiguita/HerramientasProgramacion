using System.ComponentModel.DataAnnotations;

namespace HerramientasDeProgramacionII.Models.Libreria
{
    public class UsuarioModel
    {
        [Key]
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [StringLength(40, ErrorMessage = "El nombre no puede exceder los 40 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo contraseña es obligatorio.")]
        [StringLength(20, ErrorMessage = "La contraseña no puede exceder los 20 caracteres.")]
        public string Password { get; set; }
    }
}
