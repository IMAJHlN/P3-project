using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLog.Core.Models
{
	public class FuelEntry
	{
		public int Id { get; set; }
		public int VehicleId { get; set; }
		public string FuelType { get; set; }
		public decimal Amount { get; set; }
		public decimal Price { get; set; }
		public DateTime Date {  get; set; }
		public int Mileage { get; set; }
		public bool IsFull { get; set; }
	}
}
