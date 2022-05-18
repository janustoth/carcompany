using Microsoft.EntityFrameworkCore;

namespace CarCompany
{
	public class CarGarage
	{
		public long Id { get; set; }

		public string? Name { get; set; }
	}
	public class CarCompanyDbContext : DbContext
	{
		public CarCompanyDbContext(DbContextOptions<CarCompanyDbContext> options)
			   : base(options) { }

		public DbSet<CarGarage> Garages => Set<CarGarage>();
	}
}