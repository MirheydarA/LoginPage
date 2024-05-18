using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
