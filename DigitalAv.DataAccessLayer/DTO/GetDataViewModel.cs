using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigitalAv.Domain.DTO
{
	public class GetDataViewModel
	{
		[Required]
		public string Name { get; set; }
	}
}
