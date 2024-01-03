using Lecture_13.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Application.Repositories.ProductRepositories
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
