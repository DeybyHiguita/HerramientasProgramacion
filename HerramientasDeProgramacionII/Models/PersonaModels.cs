namespace HerramientasDeProgramacionII.Models
{
    public class PersonaModels
    {
        public String nombre { get; set;}
        public String apellido { get; set;}
        public Int128 identificacion { get; set;}
        public String estadoCivil { get; set;}

        public PersonaModels(String nombre, String apellido, Int128 identificacion, String estadoCivil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.identificacion = identificacion;
            this.estadoCivil = estadoCivil;
        }

        public void CambiarEstadoCivil(String estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }
    }
}
