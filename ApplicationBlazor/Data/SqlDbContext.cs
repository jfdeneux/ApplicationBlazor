using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationBlazor.Data;

namespace ApplicationBlazor.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
           : base(options)
        {
        }
        public DbSet<ApplicationBlazor.Data.CustomerMaster> CustomerMaster { get; set; }
    }
}
