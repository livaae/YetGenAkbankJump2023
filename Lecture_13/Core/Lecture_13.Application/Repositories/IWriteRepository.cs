using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture_13.Domain.Common; 
namespace Lecture_13.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : EntityBase
    {
        void Add(T entity);
        void Delete(string id);
        void SaveChanges();
    }
}
