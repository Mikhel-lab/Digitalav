using DigitalAv.Domain.DTO;
using DigitalAv.Repositories.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAv.MachingTest.Solution.Controllers
{
	public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;
		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		public IActionResult Index(int? pageNumber)
		{
			var customer = _customerService.GetAll().Select(cus => new CustomerIndexViewModel
			{
				Name = cus.Name,
				SaleDate = cus.SaleDate,
				Quantity = cus.Quantity,
				Country = cus.Country,
				Region = cus.Region,
				City = cus.City,
				Product = cus.Product
			}).ToList();
			int pageSize = 4;
			return View(CustomerListPagination<CustomerIndexViewModel>.Create(customer, pageNumber ?? 1, pageSize));
		}
	}
}
