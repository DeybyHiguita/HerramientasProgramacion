namespace HerramientasDeProgramacionII.Models
{
    public class ServicioModels : PersonaModels
    {
        public String labor { get; set; }

        public ServicioModels(String nombre, String apellido, Int128 identificacion, String estadoCivil, String labor) : base(nombre, apellido, identificacion, estadoCivil)
        {
            this.labor = labor;
        }

        public void ModificarLabor(String labor)
        {
            this.labor = labor;
        }
    }
}
