using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class City 
	{
		public int Id { get; set; }
		public int CityCode { get; set; }
		public int RegionCode { get; set; }
		public Region Region { get; set; }
		public string CityName { get; set; }
		public int Value { get; set; }
		public string Text { get; set; }
	}
}
