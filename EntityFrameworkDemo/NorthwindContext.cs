using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class NorthwindContext : DbContext  
    {
        //uygulamadaki nesneleri ve veritabanındaki tabloları ilişkilendiricez
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //veritabanını belirledik
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = Northwind; Trusted_Connection = true ");
        }

        public DbSet<Product> Products { get; set; }
    }
}
