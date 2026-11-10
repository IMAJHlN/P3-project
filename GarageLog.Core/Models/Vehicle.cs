using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLog.Core.Models
{
	public class Vehicle
	{
		public int Id { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Engine { get; set; }
		public int HP {  get; set; }
		public string FuelType { get; set; }
		public string LicensePlate { get; set; }
		public int Mileage { get; set; }

		public void UpdateMileage(int newMileage)
		{
			if (newMileage < Mileage)
			{
				throw new ArgumentException("Nowy przebieg nie może być mniejszy niż obecny.");
			}
			Mileage = newMileage;
		}
	}
}
