using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MBMTrans.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Auto.Car> Cars { get; set; }
        public DbSet<Auto.Manufacture> Manufactures { get; set; }
        public DbSet<Auto.Model> Models { get; set; }
        public DbSet<Auto.Color> Colors { get; set; }
        public DbSet<Auto.Driver> Drivers { get; set; }
    }
}
