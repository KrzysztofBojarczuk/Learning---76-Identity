using Identity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Identity.Data
{
    public class DataContext : DbContext
    {
        protected DataContext()
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}