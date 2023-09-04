using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		private List<Customer> customers = new List<Customer>()
		{
			new Customer { Name = "Bassam Ehab"},
			new Customer { Name = "Fady Refaat"},
			new Customer { Name = "Tawfik Mohamed"},
			new Customer { Name = "Hashim Sayed"}
		};
		public IActionResult Index()
		{
			MoviesCustomersViewModel moviesCustomersViewModel = new MoviesCustomersViewModel()
			{
				Customers = customers
			};

			return View(moviesCustomersViewModel);
		}

		public IActionResult Details(int id)
		{
			id--;
			if (id < 0 || id >= customers.Count)
			{
				return Content("Error");
			}
			return View("CustomerDetails", customers[id]);
		}
	}
}
