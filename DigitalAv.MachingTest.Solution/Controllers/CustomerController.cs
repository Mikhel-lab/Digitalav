using DigitalAv.Domain.DTO;
using DigitalAv.Models.Model;
using DigitalAv.Repositories.Database;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAv.MachingTest.Solution.Controllers
{
	public class CustomerController : Controller
	{
		Db db = new Db();
		
		public IActionResult Index(int? pageNumber)
		{
			List<CustomerIndexViewModel> customer = new List<CustomerIndexViewModel>();
			var ds = db.GetAllSAles();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				customer.Add(new CustomerIndexViewModel
				{
					Name = dr["SalesName"].ToString(),
					SaleDate = DateTime.Parse(dr["SaleDate"].ToString()),
					CityCode = Convert.ToInt32(dr["CityCode"].ToString()),
					CountryCode = dr["CountryCode"].ToString(),
					ProductId = Convert.ToInt32(dr["ProductId"].ToString()),
					Quantity = Convert.ToInt32(dr["Quantity"].ToString()),
					RegionCode = dr["RegionCode"].ToString()
				}) ;
				//return View(customer);
				int pageSize = 4;
				return View(CustomerListPagination<CustomerIndexViewModel>.Create(customer, pageNumber ?? 1, pageSize));
			}

			return View();
			
		}


		
		[HttpGet]
		public IActionResult Create()
		{
			var model = new CustomerCreateViewModel();
			DataSet ds = db.GetCountry();
			List<SelectListItem> list = new List<SelectListItem>();
			//var customer = new CustomerCreateViewModel();
			model.Countries.Add(new SelectListItem("Select Country", ""));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				model.Countries.Add(new SelectListItem { Text = dr["CountryName"].ToString(), Value = dr["CountryCode"].ToString() });
			}
			ds = db.GetProduct();
			var dt = ds.Tables[0];
			//List<SelectListItem> list = new List<SelectListItem>();
			//var product = new CustomerCreateViewModel();
			//product.Products.Add(new SelectListItem("Select Product", ""));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				model.Products.Add(new SelectListItem { Text = dr["ProductName"].ToString(), Value = dr["ProductID"].ToString() });
			}
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Create(CustomerCreateViewModel model)
		{
			if (ModelState.IsValid)
			{
				var sales = new Sales
				{
					//CustomerID = model.CustomerID,
					SalesName = model.Name,
					SaleDate = model.SaleDate,
					Quantity = model.Quantity,
					ProductID = model.ProductId,
					CityCode = model.CityCode,
					CountryCode = model.CountryCode,
					RegionCode = model.RegionCode

				};

				db.InsertSalesDetails(sales);
				return RedirectToAction(nameof(Index));
			}
			return View();


		}
			
		[HttpGet]
		public IActionResult GetData()
		{
			DataSet ds = db.GetCountry();
			List<SelectListItem> list = new List<SelectListItem>();
			var customer = new CustomerCreateViewModel();
			customer.Countries.Add(new SelectListItem("Select Country", ""));
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				customer.Countries.Add(new SelectListItem { Text = dr["CountryName"].ToString(), Value = dr["CountryCode"].ToString() });
			}
			return View(customer); 

		}

		

		[HttpGet]
		public IActionResult GetProductList()
		{

			DataSet ds = db.GetProduct();
			var dt = ds.Tables[0];
			List<SelectListItem> list = new List<SelectListItem>();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new SelectListItem { Text = dr["ProductName"].ToString(), Value = dr["ProductID"].ToString() });
			}

			//ViewBag.Countrylist = list;
			return View(list);
		}



		public JsonResult GetRegionList(string cid)
		{
			DataSet ds = db.GetRegion(cid);
			var dt = ds.Tables[0];
			List<SelectListItem> list = new List<SelectListItem>();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new SelectListItem { Text = dr["RegionName"].ToString(), Value = dr["RegionCode"].ToString() });
			}
			//ViewBag.Countrylist = list;
			return Json(list);
		}

		public JsonResult GetCityList(string sid)
		{
			DataSet ds = db.GetCity(sid);
			List<SelectListItem> list = new List<SelectListItem>();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				list.Add(new SelectListItem { Text = dr["CityName"].ToString(), Value = dr["CityCode"].ToString() });
			}
			//ViewBag.Countrylist = list;
			return Json(list);
		}


		[HttpGet]
		public IActionResult Detail(int id)
		{
			CustomerDetailViewModel customer = new CustomerDetailViewModel();
			var ds = db.GetAllSAles();
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				customer= new CustomerDetailViewModel
				{
					Name = dr["SalesName"].ToString(),
					SaleDate = DateTime.Parse(dr["SaleDate"].ToString()),
					CityCode = Convert.ToInt32(dr["CityCode"].ToString()),
					CountryCode = dr["CountryCode"].ToString(),
					ProductId = Convert.ToInt32(dr["ProductId"].ToString()),
					Quantity = Convert.ToInt32(dr["Quantity"].ToString()),
					RegionCode = dr["RegionCode"].ToString()
				};
				return View(customer);
				
			}
			return View();
		}

		//public IActionResult Filter() => View();

		//[HttpPost]
		//public IActionResult Filter(string keyword)
		//{
		//	IEnumerable<FilterViewModel> filter = null;
		//	if (string.IsNullOrEmpty(keyword))
		//		ViewBag.Message = "Enter your filter keyword(s)";
		//	else
		//	{
		//		if (!string.IsNullOrEmpty(keyword) || !string.IsNullOrWhiteSpace(keyword))
		//		{
		//			filter = _customerDatabaseContext.Set<Sales>().Select(x => new FilterViewModel
		//			{
		//				CountryCode = x.CountryCode,
		//				RegionCode = x.RegionCode,
		//				CityCode = x.CityCode

		//			}).Where(x => x.CountryCode.ToLower().Trim().Contains(keyword)).ToList()
		//			.AsQueryable().AsTracking();

		//			if (filter != null)
		//				ViewBag.Search = filter;
		//			else
		//				ViewBag.Message = "No record found for your filter.";
		//		}

		//	}

		//	return View();
		//}

	}
}
