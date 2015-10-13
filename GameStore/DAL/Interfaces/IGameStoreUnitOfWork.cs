using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGameStoreUnitOfWork
    {
        IRepository<Game> GameRepository { get; }
        IRepository<Genre> GenreRepository { get; }
        IRepository<PlatformType> PlatformTypeRepository { get; }
        IRepository<Comment> CommentRepository { get; }

        void Save();

    }
}
