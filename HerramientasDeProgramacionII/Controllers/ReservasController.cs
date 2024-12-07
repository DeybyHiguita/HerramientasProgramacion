using HerramientasDeProgramacionII.Bussiness;
using HerramientasDeProgramacionII.Models.Reservas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Controllers
{
    public class ReservasController : Controller
    {
        //Crear modelo ReservaModels para que los metodos accedan a la informacion
        List<ReservaModels> reservasController = new List<ReservaModels>();
        RecervasAppModels recervasAppModels = new RecervasAppModels();

        // GET: ReservasController
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult App()
        {
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            List<ReservaModels> reservas = ConsultarReserva();
            recervasAppModels.reservaModels = reservas;
            recervasAppModels = FiltroRecervasAppModels(this.recervasAppModels);
            return View(this.recervasAppModels);
        }
        public ActionResult EliminarReserva(int id)
        {
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            reservaBussiness.ActualizarReserva(new ReservaModels { id = id, estado = false, nombre = "", fecha = DateTime.Now });
            recervasAppModels.ultimaReservaEliminar = id;
            return RedirectToAction("App");
        }

        public ActionResult EliminarTodasReservas()
        {
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            foreach (var item in ConsultarReserva())
            {
                reservaBussiness.ActualizarReserva(new ReservaModels { id = item.id, estado = false, nombre = "", fecha = DateTime.Now });
            }
            return RedirectToAction("App");
        }

        //Post : Crearcapacidad
        [HttpPost]
        public ActionResult CrearCapacidad(IFormCollection collection)
        {
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            int capacidad = int.Parse(collection["capacidad"]);
            List<ReservaModels> reservas = ConsultarReserva();
            recervasAppModels.reservaModels = reservas;
            recervasAppModels.capacidad = reservaBussiness.CrearCapaciadad(capacidad);
            return View("App", FiltroRecervasAppModels(recervasAppModels));
        }

        public RecervasAppModels FiltroRecervasAppModels(RecervasAppModels recervasAppModels)
        {
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            return reservaBussiness.FiltroRecervasAppModels(recervasAppModels);
        }

        public List<ReservaModels> ConsultarReserva()
        {
            if (this.reservasController.Count == 0)
            {
                ReservaBussiness reservaBussiness = new ReservaBussiness();
                this.reservasController = reservaBussiness.ConsultarReserva();
            }
            return this.reservasController;
        }


        public ActionResult ActualizarReservas()
        {
            List<ReservaModels> reservas = ConsultarReserva();
            recervasAppModels.reservaModels = reservas;
            return View("App", FiltroRecervasAppModels(recervasAppModels));
        }
        [HttpPost]
        public ActionResult ReservarVuelo(ReservaModels reserva)
        {
            int id = reserva.id;
            ReservaBussiness reservaBussiness = new ReservaBussiness();
            recervasAppModels.reservaModels = ConsultarReserva();
            reserva.estado = true;
            reservaBussiness.ActualizarReserva(reserva);
            recervasAppModels.ultimaReserva = id;
            return View("App", FiltroRecervasAppModels(recervasAppModels));
        }



        // GET: ReservasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
