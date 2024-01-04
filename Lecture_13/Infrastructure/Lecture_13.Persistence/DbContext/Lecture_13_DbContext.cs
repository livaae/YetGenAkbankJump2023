using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_13.Domain.Entities;

namespace Lecture_13.Persistence.DbContext
{
    public class Lecture_13_DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Lecture_13"); 
        }

    }
}
