namespace HerramientasDeProgramacionII.Models
{
    public class AdministrativoModels : PersonaModels
    {
        public String dependencia { get; set; }

        public AdministrativoModels(String nombre, String apellido, Int128 identificacion, String estadoCivil, String dependencia): base(nombre, apellido, identificacion, estadoCivil)
        {
            this.dependencia = dependencia;
        }

        public void ModificarDependencia(String dependencia)
        {
            this.dependencia = dependencia;
        }
    }
}
