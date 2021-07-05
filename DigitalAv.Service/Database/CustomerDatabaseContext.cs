using DigitalAv.Models.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalAv.Repositories.Database
{
	public class CustomerDatabaseContext : IdentityDbContext
	{
		public CustomerDatabaseContext(DbContextOptions<CustomerDatabaseContext> options) : base(options)
		{
		}

		public DbSet<Customer> Customer { get; set; }
		public DbSet<Country> Country { get; set; }
		public DbSet<Region> Region { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<Product> Product { get; set; }

	}
}
