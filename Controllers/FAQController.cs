using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
