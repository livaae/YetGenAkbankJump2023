
using Lecture_13.Domain.Entities;
using Lecture_13.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_13.Application.Repositories.ProductRepositories;

namespace Lecture_13.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository<Product>
    {
        public ProductReadRepository(Lecture_13_DbContext context) : base(context)
        {
        }
    }
}
