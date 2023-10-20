using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplicationCereals.Models;

namespace WebApplicationCereals.Db
{
	public class CerealsDbContext : DbContext
	{
		public DbSet<Cereal> Cereals { get; set;}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			base.OnConfiguring(options);
			options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cereals");
		}

	}
}
