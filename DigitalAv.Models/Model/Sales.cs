using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Sales 
	{
		public Sales()
		{
			Countries = new HashSet<Country>();
			Regions = new HashSet<Region>();
			Cities = new HashSet<City>();
			Products = new HashSet<Product>();
		}

		[Key]
		public int Id { get; set; }
		[Display(Name = "Customer Name")]
		public string SalesName { get; set; }
		[Display(Name = "Customer SaleDate")]
		public DateTime SaleDate { get; set; }
		[Display(Name = "Quantity Of Product")]
		public int Quantity { get; set; }
		public int ProductID { get; set; }

		public string CountryCode { get; set; }
		public string RegionCode { get; set; }
		public int CityCode { get; set; }
		public ICollection<Country> Countries { get; set; }
		public ICollection<Region> Regions { get; set; }
		public ICollection<City> Cities { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
