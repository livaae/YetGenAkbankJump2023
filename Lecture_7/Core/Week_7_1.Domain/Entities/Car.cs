using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_7_1.Domain.Common;

namespace Week_7_1.Domain.Entities
{
    public class Car : EntityBase<Guid>
    {
        public string Brand { get; set; } //BMW
        public string Model { get; set; } //520
        public decimal EngineDisplacement { get; set; } //1.6
        public int ManufacturingYear { get; set; } //2018
    }
}
