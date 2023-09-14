using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using VidlyF.Data;
using VidlyF.Migrations;
using VidlyF.Models;
using VidlyF.ViewModels;


namespace VidlyF.Controllers
{
	public class CustomersController : Controller
	{
		private VidlyFDbContext _context;

		public CustomersController(VidlyFDbContext context)
		{
			_context = context;
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
			base.Dispose(disposing);
		}

		public IActionResult Index()
		{
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();
			return View(customers);
		}

		public IActionResult Details(int id)
		{
			var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
			if (customer == null)
			{
				Console.WriteLine("No customer with entered ID");
				return NotFound();
			}		
			return View("CustomerDetails", customer);
		}

		public IActionResult New()
		{
			var membershipTypes = _context.MembershipTypes.ToList();
			var viewModel = new CustomerFormViewModel
			{
				MembershipTypes = membershipTypes
			};
			return View("CustomerForm", viewModel);
		}

		[HttpPost]
		public IActionResult Save(Customer customer)
		{
			if (customer.Id == 0)
			{
				_context.Customers.Add(customer);
			}
			else
			{
				var customerFromDB = _context.Customers.Single(c => c.Id == customer.Id);
				customerFromDB.Name = customer.Name;
				customerFromDB.MembershipTypeId = customer.MembershipTypeId;
			}
			_context.SaveChanges();
			return RedirectToAction("Index", "Customers");
		}

		public IActionResult Edit(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
			if (customer == null)
			{
				return NotFound();
			}
			var viewModel = new CustomerFormViewModel
			{
				Customer = customer,
				MembershipTypes = _context.MembershipTypes.ToList()
			};
			return View("CustomerForm", viewModel);
		}
	}
}
