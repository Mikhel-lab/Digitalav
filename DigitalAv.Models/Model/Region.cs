using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Region 
	{
		public int Id { get; set; }
		public string RegionCode { get; set; }
		public int CountryCode { get; set; }
		public Country Country { get; set; }
		public string RegionName { get; set; }

	}
}
