using DigitalAv.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DigitalAv.Repositories.Repositories.Interfaces
{
	public interface ICustomerService
	{
		Task CreateAsync(Customer newCustoemr);
		Customer GetById(Guid customerId);
		Task UpdateAsync(Customer customer);
		
		IEnumerable<Customer> GetAll();
		IEnumerable<SelectListItem> GetAllCustomersCountry();
		IEnumerable<SelectListItem> GetAllCustomersState();
		IEnumerable<SelectListItem> GetAllCustomersCity();
		IEnumerable<SelectListItem> GetAllCustomersProduct();
	}
}
