using gestion_alumno.Models;
using gestion_alumno.Models.Login;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gestion_alumno.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel
            {
                isLogged = true,
                message = ""
            };
            return View(loginViewModel);
        }
        public IActionResult Login (LoginModel loginModel)
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            if (string.IsNullOrEmpty(loginModel.userName) || string.IsNullOrEmpty(loginModel.password))
            {
                loginViewModel.isLogged = false;
                loginViewModel.message = "Por favor ingrese un usuario o clave valida";
                return View("~/Views/Home/Index.cshtml", loginViewModel);
            }
            if(loginModel.userName.Equals("Master") && loginModel.password.Equals("123456"))
            {
                return Redirect("~/Panel/Alumnos");
            }

            loginViewModel.isLogged = false;
            loginViewModel.message = "Alguno de los datos ingresados son incorrectos. Intente nuevamente";
            
            return View(loginViewModel);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}