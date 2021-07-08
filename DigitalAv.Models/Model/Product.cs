using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Product 
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		[Column(TypeName = "decimal")]
		public decimal Price { get; set; }
	}
}
