using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;
using Models.Entities;

namespace DAL.Repositories
{
    class GameStoreUnitOfWork: IGameStoreUnitOfWork
    {
        private IRepository<Game> gameRepository;
        private IRepository<Genre> genreRepository;
        private IRepository<Comment> commnetRepository;
        private IRepository<PlatformType> platformTypeRepository;

        private GameStoreContext database;

        public GameStoreUnitOfWork(string context)
        {
            this.database = new GameStoreContext(context);
        }
        public IRepository<Models.Entities.Game> GameRepository
        {
            get 
            {
                if (gameRepository == null)
                {
                    gameRepository = new GameRepository(database);
                }
                return gameRepository;
            }
        }

        public IRepository<Models.Entities.Genre> GenreRepository
        {
            get
            {
                if (genreRepository == null)
                {
                    genreRepository = new GenreRepository(database);
                }
                return genreRepository;
            }
        }

        public IRepository<Models.Entities.PlatformType> PlatformTypeRepository
        {
            get
            {
                if (platformTypeRepository == null)
                {
                    platformTypeRepository = new PlatformTypeRepository(database);
                }
                return platformTypeRepository;
            }
        }

        public IRepository<Models.Entities.Comment> CommentRepository
        {
            get
            {
                if (commnetRepository == null)
                {
                    commnetRepository = new CommentRepository(database);
                }
                return commnetRepository;
            }
        }

        public void Save()
        {
            database.SaveChanges();
        }
    }
}
