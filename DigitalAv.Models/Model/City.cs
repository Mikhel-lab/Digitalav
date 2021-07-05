using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class City : BaseModel
	{
		public int CityCode { get; set; }
		public string RegionCode { get; set; }
		[ForeignKey(nameof(RegionCode))]
		public Region Region { get; set; }
		public string CityName { get; set; }
	}
}
