using DigitalAv.Models.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DigitalAv.Domain.DTO
{
	public class CustomerCreateViewModel
	{
		public CustomerCreateViewModel()
		{
			this.Countries = new List<SelectListItem>();
			this.Regions = new List<SelectListItem>();
			this.Cities = new List<SelectListItem>();
			this.Products = new List<SelectListItem>();
			this.Customers = new List<SelectListItem>();
		}

		public int CustomerID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public DateTime SaleDate { get; set; }
		[Required]
		public int Quantity { get; set; }
		
		public string CountryCode { get; set; }
		
		public string RegionCode { get; set; }
		
		public int CityCode { get; set; }
		public int ProductId { get; set; }
		
		

		public IList<SelectListItem> Countries { get; set; }
		public IList<SelectListItem> Regions { get; set; }
		public IList<SelectListItem> Cities { get; set; }
		public IList<SelectListItem> Products { get; set; }
		public IList<SelectListItem> Customers { get; set; }

	}
}
