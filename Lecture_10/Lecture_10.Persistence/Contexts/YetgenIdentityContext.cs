using Lecture_10.Domain.Entities;
using Lecture_10.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10.Persistence.Contexts
{
    public class YetgenIdentityContext : IdentityDbContext<User, Role, Guid>
    {
        public YetgenIdentityContext(DbContextOptions<YetgenIdentityContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<Student>();
            //modelBuilder.Ignore<Product>();
           // modelBuilder.Ignore<Category>();
            //modelBuilder.Ignore<ProductCategory>();

            base.OnModelCreating(modelBuilder);
        }


    }
}
