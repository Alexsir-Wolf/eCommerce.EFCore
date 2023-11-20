using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models;

public class eCommerceDbContext : DbContext
{
	public eCommerceDbContext(DbContextOptions options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

	}
}
