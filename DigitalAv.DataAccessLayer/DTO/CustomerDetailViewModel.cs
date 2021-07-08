using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAv.Domain.DTO
{
	public class CustomerDetailViewModel
	{
		public int CustomerID { get; set; }
		public string Name { get; set; }
		public DateTime SaleDate { get; set; }
		public int Quantity { get; set; }

	}
}
