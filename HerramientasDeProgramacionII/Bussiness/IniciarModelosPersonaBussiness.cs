using HerramientasDeProgramacionII.Models;

namespace HerramientasDeProgramacionII.Bussiness
{
    public class IniciarModelosPersonaBussiness
    {
        public AdministrativoModels administrativo { get; set; }
        public EmpleadoModels empleado { get; set; }
        public EstudianteModels estudiante { get; set; }
        public ProfesorModels profesor { get; set; }
        public ServicioModels servicio { get; set; }

        public IniciarModelosPersonaBussiness()
        {
            administrativo = new AdministrativoModels(
                               "Juan",
                                              "Perez",
                                                             123456,
                                                                            "Casado",
                                                                                           "Administrativo");

            empleado = new EmpleadoModels(
                               "Pedro",
                                              "Gomez",
                                                             654321,
                                                                            "Soltero",
                                                                                           DateTime.Now);

            estudiante = new EstudianteModels(
                               "Maria",
                                              "Gonzalez",
                                                             987654,
                                                                            "Casada",
                                                                                           "Matematicas");

            profesor = new ProfesorModels(
                               "Ana",
                                              "Martinez",
                                                             456789,
                                                                            "Soltera",
                                                                                           "Fisica");

            servicio = new ServicioModels(
                               "Luis",
                                              "Garcia",
                                                             789123,
                                                                            "Casado",
                                                                                           "Servicio Social");
        }

        public void MatricularCurso()
        {
            estudiante.MatricularEstudiante("Curso Matriculado");
        }

        public void CambiarEstadoCivil(String persona)
        {
            switch (persona)
            {
                case "Administrativo":
                    administrativo.CambiarEstadoCivil("Divorciado");
                    break;
                case "Empleado":
                        empleado.CambiarEstadoCivil("Casado");
                    break;
                case "Estudiante":
                        estudiante.CambiarEstadoCivil("Soltero");
                    break;
                case "Profesor":
                        profesor.CambiarEstadoCivil("Viudo");
                    break;
                case "Servicio":
                        servicio.CambiarEstadoCivil("Soltero");
                    break;
                default:
                    break;
            }
        }

        public void ModificarFacultad()
        {
            profesor.ModificarFacultad("Ingenieria");
        }

        public void ModificarLabor()
        {
            servicio.ModificarLabor("Servicio de aseo");
        }

        public void ModificarDependencia()
        {
            administrativo.ModificarDependencia("Rectoria");
        }
    }
}
