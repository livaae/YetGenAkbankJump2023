using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Domain.Entities;

namespace Week7.Persistence.Contexts
{
    public class Week7_DbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPost> CarPosts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=Week7_Db; UserId=postgres; Password=1532456;");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
