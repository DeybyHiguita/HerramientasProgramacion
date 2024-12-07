namespace HerramientasDeProgramacionII.Models
{
    public class EmpleadoModels : PersonaModels
    {
        public DateTime anioIncorporacion { get; set; }

        public EmpleadoModels(String nombre, String apellido, Int128 identificacion, String estadoCivil, DateTime anioIncorporacion): base(nombre, apellido, identificacion, estadoCivil)
        {
            this.anioIncorporacion = anioIncorporacion;
        }
    }
}
