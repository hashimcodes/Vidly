﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Customer> Customers { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}