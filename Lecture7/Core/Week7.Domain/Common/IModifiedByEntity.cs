﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.Domain.Common
{
    public interface IModifiedByEntity
    {
        DateTime? ModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}
