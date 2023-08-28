using Microsoft.AspNetCore.Mvc;

namespace Tahsel.Controllers
{
    public class VideoLessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
