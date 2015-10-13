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
    public class CommentRepository: IRepository<Comment>
    {
        private GameStoreContext db;

        public CommentRepository(GameStoreContext database)
        {
            this.db = database;
        }

        public IEnumerable<Comment> Get()
        {
            return db.Comments.ToList();
        }

        public Comment Get(int id)
        {
            return db.Comments.Find(id);
        }

        public void Update(Comment item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Create(Comment item)
        {
            db.Comments.Add(item);
        }

        public void Delete(int id)
        {
            var comment = db.Comments.Find(id);
            comment.IsDeleted = true;
            db.Entry(comment).State = EntityState.Modified;
        }
    }
}
