using Microsoft.AspNetCore.Mvc;

namespace Tahsel.Controllers
{
    public class ThelibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
