using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Models.Abstacts;

namespace Models.Entities
{
    public class Genre: Entity<Int32>
    {
        public Int32 GenreId { get; set; }
        public String Name { get; set; }
        public Int32? ParrentId { get; set; }

        public virtual ICollection<Game> Games { get; set; } 
    }
}
