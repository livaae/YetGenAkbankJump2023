using Lecture_13.Application.Repositories;
using Lecture_13.Domain.Common;
using Lecture_13.Domain.Entities;
using Lecture_13.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly Lecture_13_DbContext _context;

        public ReadRepository(Lecture_13_DbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public List<T> GetAll()
        {
           return Table.ToList();
        }

        public T GetById(string id)
        {
            return Table.FirstOrDefault(x => x.Id == Guid.Parse(id));
        }
    }
}
