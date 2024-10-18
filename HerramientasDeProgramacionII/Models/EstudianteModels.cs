namespace HerramientasDeProgramacionII.Models
{
    public class EstudianteModels : PersonaModels
    {
        public String curso { get; set; }

        public EstudianteModels(String nombre, String apellido, Int128 identificacion, String estadoCivil, String curso) : base(nombre, apellido, identificacion, estadoCivil)
        {
            this.curso = curso;
        }

        public void MatricularEstudiante(String curso)
        {
            this.curso = $"{this.curso} - {curso}";
        }
    }
}
