using Lecture_13.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Application.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        DbSet<T> Table { get; }
    }
}
