using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using GarageLog.Core.Interfaces;
using GarageLog.Core.Models;
using GarageLog.Infrastructure.Data;

namespace GarageLog.Infrastructure.Repositories
{
	public class VehicleRepository : IVehicleRepository
	{
		private readonly GarageLogDbContext _context;

		public VehicleRepository(GarageLogDbContext context)
		{
			_context = context;
		}

		public void Add(Vehicle vehicle)
		{
			_context.Vehicles.Add(vehicle);
			_context.SaveChanges();
		}

		public IEnumerable<Vehicle> GetAll()
		{
			return _context.Vehicles.ToList();
		}

		public Vehicle GetById(int id)
		{
			return _context.Vehicles.FirstOrDefault(v => v.Id == id);
		}

		public void Update(Vehicle vehicle)
		{
			_context.Vehicles.Update(vehicle);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var vehicle = _context.Vehicles.FirstOrDefault(v => v.Id == id);
			if (vehicle != null)
			{
				_context.Vehicles.Remove(vehicle);
				_context.SaveChanges();
			}
		}
	}
}
