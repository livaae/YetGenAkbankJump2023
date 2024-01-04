using Lecture_13.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13.Domain.Entities
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
