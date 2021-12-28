using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class StatusTypeRepository : IRepository<StatusType>
    {
        private GCdb db;

        public StatusTypeRepository(GCdb dbcontext)
        {
            this.db = dbcontext;
        }

        public List<StatusType> GetList()
        {
            return db.StatusType.ToList();
        }

        public StatusType GetItem(int id)
        {
            return db.StatusType.Find(id);
        }

        public void Create(StatusType item)
        {
            db.StatusType.Add(item);
        }

        public void Update(StatusType item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            StatusType item = db.StatusType.Find(id);
            if (item != null)
                db.StatusType.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
