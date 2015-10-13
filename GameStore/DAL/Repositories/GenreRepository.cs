using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;
using Models.Entities;

namespace DAL.Repositories
{
    public class GenreRepository: IRepository<Genre>
    {
        private GameStoreContext db;

        public GenreRepository(GameStoreContext database)
        {
            this.db = database;
        }
        public IEnumerable<Genre> Get()
        {
            return db.Genres.ToList();
        }

        public Genre Get(int id)
        {
            return db.Genres.Find(id);
        }

        public void Update(Genre item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Create(Genre item)
        {
            db.Genres.Add(item);
        }

        public void Delete(int id)
        {
            var genre = db.Genres.Find(id);
            genre.IsDeleted = true;
            db.Entry(genre).State = EntityState.Modified;
        }
    }
}
