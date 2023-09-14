using Microsoft.AspNetCore.Mvc;
using VidlyF.Models;
using VidlyF.ViewModels;

namespace VidlyF.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>() 
            {
                new Movie() { Name = "Avatar"},
				new Movie() { Name = "No Time To Die"},
				new Movie() { Name = "Fast"},
				new Movie() { Name = "Mission Impossible"}
			};

            MoviesCustomersViewModel moviesCustomersViewModel = new MoviesCustomersViewModel()
            {
                Movies = movies,
            };

            return View(moviesCustomersViewModel);
        }

        [Route("Movies/released/{year}/{month:regex(\\d{{2}})}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
