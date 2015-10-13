using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Context;
using Models.Entities;

namespace DAL.Repositories
{
    public class GameRepository: IRepository<Game>
    {
        private GameStoreContext db;

        public GameRepository(GameStoreContext database)
        {
            this.db = database;
        }

        public IEnumerable<Models.Entities.Game> Get()
        {
            return db.Games.ToList();
        }

        public Models.Entities.Game Get(int id)
        {
            return db.Games.Find(id);
        }

        public void Update(Models.Entities.Game item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Create(Models.Entities.Game item)
        {
            db.Games.Add(item);
        }

        public void Delete(int id)
        {
            var game = db.Games.Find(id);
            game.IsDeleted = true;
            db.Entry(game).State = EntityState.Modified;
        }
    }
}
