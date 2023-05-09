using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webuser.models
{
    public class Hakancontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4848NTT; Database=HakanECommerceDb; Trusted_Connection=True");
        }


        public DbSet<WebUser> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}
