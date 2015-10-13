using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstacts;

namespace Models.Entities
{
    public class PlatformType: Entity<Int32>
    {
        public Int32 PlatfomTypeId { get; set; }
        public String Type { get; set; }

        public virtual ICollection<Game> Games { get; set; } 
    }
}
