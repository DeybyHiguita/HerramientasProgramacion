using HerramientasDeProgramacionII.Bussiness;
using HerramientasDeProgramacionII.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Controllers
{
    public class HerenciaPolimorfismoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult App()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View(viewModel);
        }

        public IActionResult editarCurso()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.MatricularCurso();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }

        public IActionResult cambiarEstadoCivil(String persona)
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.CambiarEstadoCivil(persona);
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }

        public IActionResult modificarFacultad()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.ModificarFacultad();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }

        public IActionResult modificarLabor()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.ModificarLabor();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }

        public IActionResult modificarDependencia()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.ModificarDependencia();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }

        public IActionResult modificarCurso()
        {
            IniciarModelosPersonaBussiness iniciarModelosPersonaBussiness = new IniciarModelosPersonaBussiness();
            iniciarModelosPersonaBussiness.MatricularCurso();
            var viewModel = new HerenciaPolimorfismoAppModels
            {
                Administrativo = iniciarModelosPersonaBussiness.administrativo,
                Empleado = iniciarModelosPersonaBussiness.empleado,
                Estudiante = iniciarModelosPersonaBussiness.estudiante,
                Profesor = iniciarModelosPersonaBussiness.profesor,
                Servicio = iniciarModelosPersonaBussiness.servicio
            };

            return View("App", viewModel);
        }


    }
}
