using Lecture_13.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Application.Repositories.CustomerRepositories
{
    public interface ICustomerReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
    }
}
