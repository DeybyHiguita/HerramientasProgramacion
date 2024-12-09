using HerramientasDeProgramacionII.Bussiness.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Controllers
{
    public class LibreriaController : Controller
    {
        // GET: LibreriaController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [SessionValidationFilter]

        public ActionResult Libro()
        {
            LibroBussiness libroBussiness = new LibroBussiness();
            List<LibroModel> libros = libroBussiness.ObtenerLibros();
            return View(libros);
        }

        public ActionResult CerrarSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        //Registro
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioModel usuario)
        {
            if(!ModelState.IsValid)
            {
                return View(usuario);
            }

            LoginBussiness loginBussiness = new LoginBussiness();
            if (loginBussiness.DataUsuarioPorNombre(usuario))
            {
                GuardarVariablesSession("usuario", usuario.Nombre);
                return RedirectToAction("Libro");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos");
                return View(usuario);
            }

        }

        private void GuardarVariablesSession(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
        }

        [HttpPost]
        public IActionResult Registro(UsuarioModel usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            try
            {
                LoginBussiness loginBussiness = new LoginBussiness();
                loginBussiness.CrearUsuario(usuario);
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ocurrió un error al registrar el usuario: " + ex.Message);
                return View(usuario);
            }

        }

        [HttpPost]
        public ActionResult CrearLibro(LibroModel libro)
        {
            if (!ModelState.IsValid)
            {
                return View(libro);
            }

            try
            {
                LibroBussiness libroBussiness = new LibroBussiness();
                libroBussiness.CrearLibro(libro);
                TempData["SuccessMessage"] = $"Libro: {libro.Titulo} creado correctamente.";
                return RedirectToAction("Libro");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ocurrió un error al registrar el libro: " + ex.Message);
                return View(libro);
            }
        }

        [HttpPost]
        public ActionResult ActualizarLibro(LibroModel libro)
        {
            if (!ModelState.IsValid)
            {
                return View(libro);
            }

            try
            {
                LibroBussiness libroBussiness = new LibroBussiness();
                libroBussiness.ActualizarLibro(libro);
                TempData["SuccessMessage"] = "Libro editado correctamente.";
                return RedirectToAction("Libro");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ocurrió un error al actualizar el libro: " + ex.Message);
                return View(libro);
            }
        }

        [HttpGet]
        public ActionResult EliminarLibro(int id)
        {
            try
            {
                LibroBussiness libroBussiness = new LibroBussiness();
                libroBussiness.EliminarLibro(id);
                TempData["SuccessMessage"] = "Libro eliminado correctamente.";
                return RedirectToAction("Libro");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Ocurrió un error al eliminar el libro: " + ex.Message);
                return RedirectToAction("Libro");
            }
        }

        [SessionValidationFilter]
        [HttpGet]
        public ActionResult Suscriptores()
        {
            SuscritorBussiness suscritorBussiness = new SuscritorBussiness();
            List<SuscriptorModel> suscritores = suscritorBussiness.ObtenerSuscritores();
            return View(suscritores);
        }

        [HttpPost]
        public ActionResult CrearSuscriptor(SuscriptorModel suscriptor)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al crear el suscriptor.";
                return RedirectToAction("Suscriptores");
            }

            try
            {
                SuscritorBussiness suscritorBussiness = new SuscritorBussiness();
                suscritorBussiness.CrearSuscriptor(suscriptor);
                TempData["SuccessMessage"] = $"Suscriptor: {suscriptor.Nombre} creado correctamente.";
                return RedirectToAction("Suscriptores");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al eliminar el suscriptor: " + ex.Message;
                return RedirectToAction("Suscriptores");
            }
        }

        [HttpPost]
        public ActionResult ActualizarSuscriptor(SuscriptorModel suscriptor)
        {
            if (!ModelState.IsValid)
            {
                return View(suscriptor);
            }

            try
            {
                SuscritorBussiness suscritorBussiness = new SuscritorBussiness();
                suscritorBussiness.ActualizarSuscriptor(suscriptor);
                TempData["SuccessMessage"] = "Suscriptor editado correctamente.";
                return RedirectToAction("Suscriptores");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al eliminar el suscriptor: " + ex.Message;
                return RedirectToAction("Suscriptores");
            }
        }

        [HttpGet]
        public ActionResult EliminarSuscriptor(string documento)
        {
            try
            {
                SuscritorBussiness suscritorBussiness = new SuscritorBussiness();
                suscritorBussiness.EliminarSuscriptor(documento);
                TempData["SuccessMessage"] = "Suscriptor eliminado correctamente.";
                return RedirectToAction("Suscriptores");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al eliminar el suscriptor: " + ex.Message;
                return RedirectToAction("Suscriptores");
            }
        }
        [SessionValidationFilter]
        [HttpGet]
        public ActionResult Prestamos()
        {
            PrestamoBussiness prestamoBussiness = new PrestamoBussiness();
            LibroBussiness libroBussiness = new LibroBussiness();
            SuscritorBussiness suscritorBussiness = new SuscritorBussiness();

            List<PrestamoModel> prestamos = prestamoBussiness.ObtenerPrestamos();
            List<LibroModel> libros = libroBussiness.ObtenerLibros();
            List<SuscriptorModel> suscriptores = suscritorBussiness.ObtenerSuscritores();

            return View((prestamos, libros, suscriptores));
        }


        [HttpPost]
        public ActionResult CrearPrestamo(PrestamoModel prestamo)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Prestamos");
            }

            try
            {
                PrestamoBussiness prestamoBussiness = new PrestamoBussiness();
                prestamoBussiness.CrearPrestamo(prestamo);
                TempData["SuccessMessage"] = $"Prestamo: {prestamo.CodigoLibro} creado correctamente.";
                return RedirectToAction("Prestamos");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al registrar el prestamo: " + ex.Message;
                return RedirectToAction("Prestamos");
            }
        }

        [HttpPost]
        public ActionResult ActualizarPrestamo(PrestamoModel prestamo)
        {
            if (!ModelState.IsValid)
            {
                return View(prestamo);
            }

            try
            {
                PrestamoBussiness prestamoBussiness = new PrestamoBussiness();
                prestamoBussiness.ActualizarPrestamo(prestamo);
                TempData["SuccessMessage"] = "Prestamo editado correctamente.";
                return RedirectToAction("Prestamos");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al actualizar el prestamo: " + ex.Message;
                return RedirectToAction("Prestamos");
            }
        }


        [HttpGet]
        public ActionResult EliminarPrestamo(string codigolibro)
        {
            try
            {
                PrestamoBussiness prestamoBussiness = new PrestamoBussiness();
                prestamoBussiness.EliminarPrestamo(codigolibro);
                TempData["SuccessMessage"] = "Prestamo eliminado correctamente.";
                return RedirectToAction("Prestamos");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Ocurrió un error al eliminar el prestamo: " + ex.Message;
                return RedirectToAction("Prestamos");
            }
        }
        [SessionValidationFilter]
        [HttpGet]
        public ActionResult Reporte()
        
        {
            ReporteBussiness reporteBussiness = new ReporteBussiness();
            List<ReporteModel> reporte = reporteBussiness.Proceso();
            return View(reporte);
        }

    }
}
