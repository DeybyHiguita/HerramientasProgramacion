using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HerramientasDeProgramacionII.Controllers
{
    public class SessionValidationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session.GetString("usuario");

            if (string.IsNullOrEmpty(session))
            {
                // Redirigir al login si no hay sesión
                context.Result = new RedirectToActionResult("Login", "Libreria", null);
            }

            base.OnActionExecuting(context);
        }
    }
}
