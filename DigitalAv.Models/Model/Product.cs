using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Product : BaseModel
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
	}
}
