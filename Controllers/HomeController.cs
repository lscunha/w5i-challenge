using Microsoft.AspNetCore.Mvc;
using w5i.Controllers; // Certifique-se de que o namespace está correto

namespace w5i.Controllers // Certifique-se de que o namespace está correto
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ControleAcessoController controller = new ControleAcessoController(null); // Certifique-se de que o construtor está correto
            // ...
            return Content("Controle de acesso processado.");
        }
    }
}

