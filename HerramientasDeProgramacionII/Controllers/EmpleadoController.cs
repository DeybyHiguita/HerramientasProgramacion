using HerramientasDeProgramacionII.Bussiness;
using HerramientasDeProgramacionII.Models.Empleado;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Controllers
{
    public class EmpleadoController : Controller
    {
        public List<EmpleadoModel> empleados = new List<EmpleadoModel>();
        public EmpleadoBussiness empleadoBussiness = new EmpleadoBussiness();

        // GET: EmpleadoController
        public ActionResult Index()
        {
            if(!empleados.Any())
            {
                empleados = empleadoBussiness.ConsultarEmpleado();
            }

            return View(empleados);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Detalle(int id)
        {
            try
            {
                var empleado = empleadoBussiness.ObtenerEmpleado(id);

                if (empleado == null)
                {
                    return NotFound(); // Si no se encuentra el empleado, retorna un error 404
                }

                return View(empleado);
            }
            catch
            {
                return RedirectToAction("Index"); // Redirige a la lista en caso de error
            }
        }

        // GET: EmpleadoController/Create
        public ActionResult Crear()
        {
            return View(new EmpleadoModel());
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(EmpleadoModel empleado)
        {
            if (!ModelState.IsValid)
            {
                return View(empleado);
            }

            try
            {
                empleadoBussiness.CrearEmpleado(empleado);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Editar(int id)
        {
            try
            {
                // Obtener el empleado por ID desde la capa de negocio o base de datos
                var empleado = empleadoBussiness.ObtenerEmpleado(id);

                if (empleado == null)
                {
                    return NotFound(); // Si no se encuentra el empleado, retorna un error 404
                }

                return View(empleado); // Carga la vista con el modelo
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(EmpleadoModel empleado)
        {
            if (!ModelState.IsValid)
            {
                return View(empleado);
            }

            try
            {
                empleadoBussiness.ActualizarEmpleado(empleado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(empleado);
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Eliminar(int id)
        {
            try
            {
                empleadoBussiness.EliminarEmpleado(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
} 
