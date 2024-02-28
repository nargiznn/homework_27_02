using homework27_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework27_02.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Brand> Brands { get; set;  }
        public DbSet<Product>  Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MOON10\\MAINDB;database=BrandDb;trusted_connection=true");
        }
      

    }
}
