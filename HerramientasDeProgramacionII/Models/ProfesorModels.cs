namespace HerramientasDeProgramacionII.Models
{
    public class ProfesorModels : PersonaModels
    {
        public String facultad { get; set; }

        public ProfesorModels(String nombre, String apellido, Int128 identificacion, String estadoCivil, String facultad) : base(nombre, apellido, identificacion, estadoCivil)
        {
            this.facultad = facultad;
        }

        public void ModificarFacultad(String facultad)
        {
            this.facultad = facultad;
        }
    }
}
