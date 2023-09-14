using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VidlyF.Models;

namespace VidlyF.EntityConfigurations
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public virtual void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(255);
		}
	}
}
