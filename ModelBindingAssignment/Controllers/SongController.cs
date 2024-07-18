using Microsoft.AspNetCore.Mvc;

namespace ModelBindingAssignment.Controllers
{
    public class SongController : Controller
    {
        public IActionResult CreateSong()
        {
            return View();
        }
    }
}
