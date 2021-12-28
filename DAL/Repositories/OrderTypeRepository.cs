using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class OrderTypeRepository : IRepository<OrderType>
    {
        private GCdb db;

        public OrderTypeRepository(GCdb dbcontext)
        {
            this.db = dbcontext;
        }

        public List<OrderType> GetList()
        {
            return db.OrderType.ToList();
        }

        public OrderType GetItem(int id)
        {
            return db.OrderType.Find(id);
        }

        public void Create(OrderType item)
        {
            db.OrderType.Add(item);
        }

        public void Update(OrderType item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            OrderType item = db.OrderType.Find(id);
            if (item != null)
                db.OrderType.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
