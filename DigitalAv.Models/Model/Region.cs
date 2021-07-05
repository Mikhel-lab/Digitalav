using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Region : BaseModel
	{
		public string RegionCode { get; set; }
		public string CountryCode { get; set; }
		[ForeignKey(nameof(CountryCode))]
		public Country Country { get; set; }
		public string RegionName { get; set; }

	}
}
