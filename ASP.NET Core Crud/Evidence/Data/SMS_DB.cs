using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence.Data
{
    public class SMS_DB : DbContext
    {
        public SMS_DB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
