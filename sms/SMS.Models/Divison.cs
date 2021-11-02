using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class Divison
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
