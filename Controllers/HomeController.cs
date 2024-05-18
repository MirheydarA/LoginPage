using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
