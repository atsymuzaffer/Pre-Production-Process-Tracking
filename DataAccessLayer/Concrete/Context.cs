using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=UOTakipDb;integrated security=true;");
		}

		public DbSet<Order> Orders { get; set; }
		public DbSet<Kullanici> Kullanicilar { get; set; }
		public DbSet<StatuKategori> StatuKategorileri { get; set; }
		public DbSet<Surec> Surecler { get; set; }
		public DbSet<SurecKategori> SurecKategorileri { get; set; }
	}
}
