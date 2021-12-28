using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private GCdb db;

        public ProductRepository(GCdb dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Product> GetList()
        {
            return db.Product.ToList();
        }

        public Product GetItem(int id)
        {
            return db.Product.Find(id);
        }

        public void Create(Product item)
        {
            db.Product.Add(item);
        }

        public void Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product item = db.Product.Find(id);
            if (item != null)
                db.Product.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
