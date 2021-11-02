using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class District
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long DivisonId { get; set; }
        public virtual Divison Divison { get; set; }
        public virtual ICollection<Upazila> Upazila { get; set; }
    }
}
