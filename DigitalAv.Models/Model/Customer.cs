using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Customer : BaseModel
	{
		//public int Id { get; set; }
		public string Name { get; set; }
		public DateTime SaleDate { get; set; }
		public string Quantity { get; set; }

		public string CountryCode { get; set; }
		[ForeignKey(nameof(CountryCode))]
		public Country Country { get; set; }
		public string RegionCode { get; set; }
		[ForeignKey(nameof(RegionCode))]
		public Region Region { get; set; }
		public int CityCode { get; set; }
		[ForeignKey(nameof(CityCode))]
		public City City { get; set; }
		public Guid ProductId { get; set; }
		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; }

		public virtual ICollection<Country> Countries { get; set; }
		public virtual ICollection<Region> States { get; set; }
		public virtual ICollection<City> Cities { get; set; }
		public virtual ICollection<Product> Products { get; set; }
	}
}
