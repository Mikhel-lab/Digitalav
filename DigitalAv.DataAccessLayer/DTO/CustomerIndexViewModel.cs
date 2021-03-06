using DigitalAv.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Domain.DTO
{
	public class CustomerIndexViewModel
	{
		public string Name { get; set; }
		public DateTime SaleDate { get; set; }
		public int Quantity { get; set; }

		public string CountryCode { get; set; }
		
		public string RegionCode { get; set; }
		
		public int CityCode { get; set; }
	
		public int ProductId { get; set; }
		
	}
}
