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
		[HttpPost]
		public IActionResult CreateSong(Song s)
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("CreateSong");
			}

			return View();
		}
	}
}
