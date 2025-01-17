﻿using ECommercialSite.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercialSite.DataAccess.Context
{
    public class ProjectContext: DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-D8D8GGB;Database=ECommercialSite;Integrated Security=True;";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
        public DbSet<Supplier> Supliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}
