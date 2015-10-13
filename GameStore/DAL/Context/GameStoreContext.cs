using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace DAL.Context
{
    public class GameStoreContext: DbContext
    {
        public GameStoreContext (string context): base(context)
        {}

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PlatformType> PlatformTypes { get; set; }
    }
}
