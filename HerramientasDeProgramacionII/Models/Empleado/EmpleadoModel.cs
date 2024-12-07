using System.ComponentModel.DataAnnotations;

namespace HerramientasDeProgramacionII.Models.Empleado
{
    public class EmpleadoModel
    {
        [Required(ErrorMessage = "El campo id empleado es obligatorio")]
        public int idempleado { get; set; }
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo direccion es obligatorio")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El campo email es obligatorio")]
        public string email { get; set; }
    }
}
