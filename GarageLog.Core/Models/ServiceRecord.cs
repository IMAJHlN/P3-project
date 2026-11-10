using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLog.Core.Models
{
	public class ServiceRecord
	{
		public int Id { get; set; }
		public int VehicleId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date	{  get; set; }
		public decimal Price {  get; set; }
		public int Mileage { get; set; }
	}
}
