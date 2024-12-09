using HerramientasDeProgramacionII.Data.Libreria;
using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Bussiness.Libreria
{
    public class PrestamoBussiness
    {
        public List<PrestamoModel> ObtenerPrestamos()
        {
            DataPrestamo dataPrestamo = new DataPrestamo();
            return dataPrestamo.ObtenerTodos();
        }

        public void CrearPrestamo(PrestamoModel prestamo)
        {
            CrearPrestamo crearPrestamo = new CrearPrestamo(prestamo);
            crearPrestamo.Proceso();
        }


        public void ActualizarPrestamo(PrestamoModel prestamo)
        {
            ActualizarPrestamo actualizarPrestamo = new ActualizarPrestamo(prestamo);
            actualizarPrestamo.Proceso();
        }


        public void EliminarPrestamo(string prestamo)
        {
            // Validación básica del formato
            if (string.IsNullOrEmpty(prestamo) || !prestamo.Contains("_"))
            {
                throw new ArgumentException("El formato del identificador del préstamo es inválido.");
            }

            // Separar los datos
            string[] datos = prestamo.Split('_');
            if (datos.Length != 2)
            {
                throw new ArgumentException("El formato del identificador del préstamo es inválido.");
            }

            // Validar y convertir los valores
            if (!DateTime.TryParseExact(datos[1], "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaPrestamo))
            {
                throw new ArgumentException("La fecha del préstamo es inválida.");
            }

            int codigo = Convert.ToInt32(datos[0]);

            // Crear el modelo del préstamo
            PrestamoModel prestamoModelo = new PrestamoModel
            {
                FechaPrestamo = fechaPrestamo,
                CodigoLibro = codigo,
            };

            // Llamar al proceso de eliminación
            EliminarPrestamoPorClave eliminarPrestamo = new EliminarPrestamoPorClave(prestamoModelo);
            eliminarPrestamo.Proceso();
        }




    }
}
