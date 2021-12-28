using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class DeviceTypeRepository : IRepository<DeviceType>
    {
        private GCdb db;

        public DeviceTypeRepository(GCdb dbcontext)
        {
            this.db = dbcontext;
        }

        public List<DeviceType> GetList()
        {
            return db.DeviceType.ToList();
        }

        public DeviceType GetItem(int id)
        {
            return db.DeviceType.Find(id);
        }

        public void Create(DeviceType item)
        {
            db.DeviceType.Add(item);
        }

        public void Update(DeviceType item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            DeviceType item = db.DeviceType.Find(id);
            if (item != null)
                db.DeviceType.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
