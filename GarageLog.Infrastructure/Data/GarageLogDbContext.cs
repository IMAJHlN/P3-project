using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GarageLog.Core.Models;

namespace GarageLog.Infrastructure.Data
{
	public class GarageLogDbContext : DbContext
	{
		public DbSet<Vehicle> Vehicles { get; set; }
		public DbSet<ServiceRecord> ServiceRecords { get; set; }
		public DbSet<FuelEntry> FuelEntries { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=garagelog.db");
		}
	}
}