﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class StaffType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
