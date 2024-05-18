using Microsoft.AspNetCore.Mvc;

namespace LoginTemplate.Controllers
{
    public class MedicalDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
