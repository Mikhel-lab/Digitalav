using DigitalAv.Models.Model;
using DigitalAv.Repositories.Database;
using DigitalAv.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DigitalAv.Repositories.Repositories.Implementations
{
	public class CustomerService : ICustomerService
	{
		public readonly CustomerDatabaseContext _context;
		public CustomerService(CustomerDatabaseContext context)
		{
			_context = context;
		}
		public async Task CreateAsync(Customer newCustoemr)
		{
			await _context.Customer.AddAsync(newCustoemr);
			await _context.SaveChangesAsync();
		}

		public IEnumerable<Customer> GetAll() => _context.Customer;


		public IEnumerable<SelectListItem> GetAllCustomersCity()
		{
			return GetAll().Select(emp => new SelectListItem()
			{
				Text = emp.Name,
				Value = emp.Id.ToString()
			});
		}

		public IEnumerable<SelectListItem> GetAllCustomersCountry()
		{
			return GetAll().Select(emp => new SelectListItem()
			{
				Text = emp.CountryCode,
				Value = emp.Id.ToString()
			});
		}

		public IEnumerable<SelectListItem> GetAllCustomersProduct()
		{
			return GetAll().Select(emp => new SelectListItem()
			{
				Text = emp.ProductId.ToString(),
				Value = emp.Id.ToString()
			});
		}

		public IEnumerable<SelectListItem> GetAllCustomersState()
		{
			return GetAll().Select(emp => new SelectListItem()
			{
				Text = emp.RegionCode,
				Value = emp.Id.ToString()
			});
		}

		public Customer GetById(Guid customerId) => _context.Customer.Where(x => x.Id == customerId).FirstOrDefault();


		public async Task UpdateAsync(Customer customer)
		{
			_context.Update(customer);
			await _context.SaveChangesAsync();
		}
	}
}
