using HerramientasDeProgramacionII.Data.Empleado;
using HerramientasDeProgramacionII.Models.Empleado;

namespace HerramientasDeProgramacionII.Bussiness
{
    public class EmpleadoBussiness
    {
        public void ActualizarEmpleado(EmpleadoModel empleado)
        {
            try
            {
                ActualizarEmpleado actualizarEmpleado = new ActualizarEmpleado();
                actualizarEmpleado.proceso(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmpleadoModel> ConsultarEmpleado()
        {
            List<EmpleadoModel> empleados = new List<EmpleadoModel>();
            try
            {
                DataEmpleado consultarEmpleado = new DataEmpleado();
                empleados = consultarEmpleado.Proceso();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return empleados;
        }

        public void CrearEmpleado(EmpleadoModel empleado)
        {
            try
            {
                CrearEmpleado crearEmpleado = new CrearEmpleado();
                crearEmpleado.proceso(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarEmpleado(int empleado)
        {
            try
            {
                EliminarEmpleado eliminarEmpleado = new EliminarEmpleado();
                eliminarEmpleado.proceso(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmpleadoModel ObtenerEmpleado(int id)
        {
            EmpleadoModel empleado = new EmpleadoModel();
            try
            {
                DataEmpleadoPorIdempleado dataEmpleadoPorIdempleado = new DataEmpleadoPorIdempleado();
                empleado = dataEmpleadoPorIdempleado.Proceso(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return empleado;
        }
    }
}
