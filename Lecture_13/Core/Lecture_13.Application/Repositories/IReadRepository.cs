using Lecture_13.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Application.Repositories
{
    public interface IReadRepository <T>: IRepository<T> where T : EntityBase
    {
        List<T> GetAll();
        T GetById(string id);
    }
}
