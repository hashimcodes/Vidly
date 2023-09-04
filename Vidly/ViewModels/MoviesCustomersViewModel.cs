using Vidly.Models;

namespace Vidly.ViewModels
{
	public class MoviesCustomersViewModel
	{
		public Movie Movie { get; set; }
		public List<Customer> Customers { get; set; }
		public List<Movie> Movies { get; set; }
	}
}
