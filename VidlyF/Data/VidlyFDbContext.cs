using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VidlyF.EntityConfigurations;
using VidlyF.Models;

namespace VidlyF.Data
{
	public class VidlyFDbContext : DbContext
	{
		public VidlyFDbContext(DbContextOptions<VidlyFDbContext> options)
			: base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CustomerConfiguration());
		}
	}



}
