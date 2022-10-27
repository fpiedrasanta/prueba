using gestion_alumno.Models.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gestion_alumno.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Alumnos()
        {
            //LoginModel loginModel = HttpContext.Session.Get<LoginModel>("UsuarioLogueado");
            //if(loginModel == null)
            //{
            //    return Redirect("~/Home/Index");
            //}
            return View();
        }
        public IActionResult Matriculas()
        {
            return View();
        }
    }
}
