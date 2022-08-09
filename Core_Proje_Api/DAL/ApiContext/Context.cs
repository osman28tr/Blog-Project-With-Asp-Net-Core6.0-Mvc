using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-7LR4Q85\\" +
				"SQLEXPRESS;Database=CoreProjeDB2;Integrated Security=true;");
		}
		public DbSet<Category> Categories { get; set; }
	}
}
