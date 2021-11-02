﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class Upazila
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long DistrictId { get; set; }
        public virtual District District { get; set; }
    }
}