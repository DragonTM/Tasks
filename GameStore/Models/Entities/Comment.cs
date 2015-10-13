using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstacts;

namespace Models.Entities
{
    public class Comment: Entity<Int32>
    {
        public String Name { get; set; }
        public String Body { get; set; }
        public Int32 Author { get; set; }
        public Int32 GameId { get; set; }

        public virtual Game Game { get; set; }
    }
}
