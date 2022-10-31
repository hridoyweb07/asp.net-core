using Microsoft.EntityFrameworkCore;
using Repository_Test.Areas.Employees.Data.Entity;
using Repository_Test.Areas.Inventory.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<SalesInvoiceMaster> salesInvoiceMasters { get; set; }
        public DbSet<SalesInvoiceDetails> salesInvoiceDetails { get; set; }

    }
}
