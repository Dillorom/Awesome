using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Awesome.Api.Models
{
    public class ValuesContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
    }
}