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
    class PlatformTypeRepository: IRepository<PlatformType>
    {
        private GameStoreContext db;

        public PlatformTypeRepository(GameStoreContext database)
        {
            this.db = database;
        }
        public IEnumerable<PlatformType> Get()
        {
            return db.PlatformTypes.ToList();
        }

        public PlatformType Get(int id)
        {
            return db.PlatformTypes.Find(id);
        }

        public void Update(PlatformType item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Create(PlatformType item)
        {
            db.PlatformTypes.Add(item);
        }

        public void Delete(int id)
        {
            var platformType = db.PlatformTypes.Find(id);
            platformType.IsDeleted = true;
            db.Entry(platformType).State = EntityState.Modified;
        }
    }
}
