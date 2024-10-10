using HerramientasDeProgramacionII.Bussiness;
using HerramientasDeProgramacionII.Models;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Controllers
{
    public class HerenciaPOOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Triangulo()
        {
            return View();
        }

        public IActionResult Circulo()
        {
            return View();
        }

        public IActionResult Rectangulo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcularCirculo(FigurasModels figurasModels)
         {
            if (figurasModels.ladoY != 0)
            {
                figurasModels.ladoX = 3.1416m;
                HerenciaPOOBusiness herenciaPOOBusiness = new HerenciaPOOBusiness();
                ResultadoFiguraModels resultadoFiguraModels = herenciaPOOBusiness.CalcularCirculo(figurasModels);
                ViewBag.resultadoFiguraModels = resultadoFiguraModels;
            }
            else
            {
                ViewBag.mensaje = "Debe ingresar los valores de los lados";
            }

            return View("Circulo");
        }

        [HttpPost]
        public IActionResult CalcularRectangulo(FigurasModels figurasModels)
        {
            if (figurasModels.ladoY != 0 && figurasModels.ladoX != 0)
            {
                HerenciaPOOBusiness herenciaPOOBusiness = new HerenciaPOOBusiness();
                ResultadoFiguraModels resultadoFiguraModels = herenciaPOOBusiness.CalcularRectangulo(figurasModels);
                ViewBag.resultadoFiguraModels = resultadoFiguraModels;
            }
            else
            {
                ViewBag.mensaje = "Debe ingresar los valores de lel lado X y lado Y";
            }

            return View("Rectangulo");
        }

        public IActionResult CalcularTriangulo(FigurasModels figurasModels)
        {
            if (figurasModels.ladoX != 0 && figurasModels.ladoY != 0)
            {
                HerenciaPOOBusiness herenciaPOOBusiness = new HerenciaPOOBusiness();
                ResultadoFiguraModels resultadoFiguraModels = herenciaPOOBusiness.CalcularTriangulo(figurasModels);
                ViewBag.resultadoFiguraModels = resultadoFiguraModels;
            }
            else
            {
                ViewBag.mensaje = "Debe ingresar los valores de lel lado X y lado Y";
            }

            return View("Triangulo");
        }
        [HttpGet]
        public IActionResult LimpiarModelo(string vista)
        {
            ViewBag.resultadoFiguraModels = null;
            return View(vista);
        }



    }
}
