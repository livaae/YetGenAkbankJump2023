using Lecture_13.Application.Repositories.CustomerRepositories;
using Lecture_13.Domain.Entities;
using Lecture_13.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository<Customer>
    {
        public CustomerReadRepository(Lecture_13_DbContext context) : base(context)
        {
        }
    }
}

