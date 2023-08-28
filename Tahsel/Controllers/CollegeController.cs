using Microsoft.AspNetCore.Mvc;

namespace Tahsel.Controllers
{
    public class CollegeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
