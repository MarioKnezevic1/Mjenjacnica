using Microsoft.AspNetCore.Mvc;

namespace Mjenjačnica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MJ()
        {
            return View("Views/Models/MJ.cshtml");
        }
    }
}
