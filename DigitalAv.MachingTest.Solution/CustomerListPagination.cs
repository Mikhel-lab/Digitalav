using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalAv.MachingTest.Solution
{
	public class CustomerListPagination<T> : List<T>
	{
		public int PageIndex { get; private set; }
		public int TotalPages { get; private set; }

		public CustomerListPagination(List<T> items, int count, int pageIndex, int pageSize)
		{
			PageIndex = pageIndex;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);
			this.AddRange(items);
		}

		//Enable or Disable our paging button
		public bool IsPreviousPageAvailable => PageIndex > 1;
		public bool IsNextPageAvailable => PageIndex < TotalPages;

		public static CustomerListPagination<T> Create(IList<T> source, int pageIndex, int pageSize)
		{
			var count = source.Count();
			var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
			return new CustomerListPagination<T>(items, count, pageIndex, pageSize);
		}
	}
}
