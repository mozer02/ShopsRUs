using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public abstract class Entity
    {
        public string Id { get; set; }
        public DateTime OnCreatedDate { get; set; }
    }
}
