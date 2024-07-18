using Microsoft.AspNetCore.Mvc;
using ModelBindingAssignment.Models;

namespace ModelBindingAssignment.Controllers
{
    public class SongController : Controller
    {
        [HttpGet]
        public IActionResult CreateSong()
        {
            return View();
        }
	}
}
