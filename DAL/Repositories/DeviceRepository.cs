using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class DeviceRepository : IRepository<Device>
    {
        private GCdb db;

        public DeviceRepository(GCdb dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Device> GetList()
        {
            return db.Device.ToList();
        }

        public Device GetItem(int id)
        {
            return db.Device.Find(id);
        }

        public void Create(Device item)
        {
            db.Device.Add(item);
        }

        public void Update(Device item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Device item = db.Device.Find(id);
            if (item != null)
                db.Device.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
