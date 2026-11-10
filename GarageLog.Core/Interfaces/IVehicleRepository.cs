using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLog.Core.Models;

namespace GarageLog.Core.Interfaces
{
	public interface IVehicleRepository
	{
		void Add(Vehicle vehicle);
		IEnumerable<Vehicle> GetAll();
		Vehicle GetById(int id);
		void Update(Vehicle vehicle);
		void Delete(int id);
	}
}
