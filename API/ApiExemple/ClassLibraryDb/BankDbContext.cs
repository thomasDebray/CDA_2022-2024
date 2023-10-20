using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace ClassLibraryDb
{
	public class BankDbContext : DbContext
	{
		public BankDbContext(DbContextOptions<BankDbContext> options)
		: base(options)
		{
		}

		public DbSet<BankTransaction> BankTransactions { get; set; } = null!;
	}
}