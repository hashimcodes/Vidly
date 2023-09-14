using VidlyF.Models;

namespace VidlyF.ViewModels
{
	public class MoviesCustomersViewModel
	{
		public Movie Movie { get; set; }
		public List<Customer> Customers { get; set; }
		public List<Movie> Movies { get; set; }
	}
}
