using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Models.Abstacts;

namespace Models.Entities
{
    public class Game: Entity<Int32>
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<PlatformType> PlatformTypes { get; set; } 
    }
}
