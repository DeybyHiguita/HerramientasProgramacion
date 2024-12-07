using HerramientasDeProgramacionII.Data;
using HerramientasDeProgramacionII.Models.Reservas;
using Microsoft.AspNetCore.Mvc;

namespace HerramientasDeProgramacionII.Bussiness
{
    public class ReservaBussiness
    {
        public List<ReservaModels> ConsultarReserva()
        {
            ReservaReservas reservaReservas = new ReservaReservas();
            return reservaReservas.ConsultarReserva();
        }

        public int CrearCapaciadad(int capacidad)
        {
            int capacidadCreada = 0;
            AgregarCapacidadReservas agregarCapacidadReservas = new AgregarCapacidadReservas();
            for (int i = 0; i < capacidad; i++)
            {
                agregarCapacidadReservas.Proceso(capacidad);
                capacidadCreada++;
            }
            return capacidadCreada;
        }

        public RecervasAppModels FiltroRecervasAppModels(RecervasAppModels recervasAppModels)
        {
            List<ReservaModels> disponibles = new List<ReservaModels>();
            List<ReservaModels> reservadas = new List<ReservaModels>();
            RecervasAppModels recervasAppModelsFiltrado = new RecervasAppModels();

            foreach (var item in recervasAppModels.reservaModels)
            {
                if (item.estado == false)
                {
                    disponibles.Add(item);
                }
                else
                {
                    reservadas.Add(item);
                }
            }

            recervasAppModelsFiltrado = recervasAppModels;
            recervasAppModelsFiltrado.disponibles = disponibles;
            recervasAppModelsFiltrado.reservadas = reservadas;
            recervasAppModelsFiltrado.reservaModels = recervasAppModels.reservaModels;
            return recervasAppModelsFiltrado;
        }

        public void ActualizarReserva(ReservaModels reservaModels)
        {
            ActualizarReservaReservas actualizarReservaReservas = new ActualizarReservaReservas();
            actualizarReservaReservas.Proceso(reservaModels);
        }
    }
}

