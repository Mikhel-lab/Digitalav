using DigitalAv.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAv.Models.Model
{
	public class Country : BaseModel
	{
		public string CountryCode { get; set; }
		public string CountryName { get; set; }
	}
}
